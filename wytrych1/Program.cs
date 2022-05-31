using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace wytrych1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            
           
            while (true)
            {
                menu.iloscWytrychow = 10;
                menu.dlugosc = 4;
                menu.szansa = 30;
                menu.iloscSkrzyni = 0;
                menu.iloscPunktow = 0;
                menu.WyswietlMenu();
                String input = Console.ReadLine();

                

                Console.Clear();
                
                if (input == "1")
                {
                    
                    while (true)
                    {
                        Console.WriteLine("Otwórz skrzynie");
                        Skrzynia skrzynia = new Skrzynia(menu.dlugosc);

                        skrzynia.GenerowanieSekwencji(menu.dlugosc);
                        
                        menu.iloscPunktow += Gra(menu.iloscWytrychow, menu.dlugosc, skrzynia.skrzynia, menu.iloscPunktow, menu.szansa);
                        menu.iloscSkrzyni++;
                        while (true)
                        {
                            Console.WriteLine("Grasz dalej?\n1.Tak\n2.Nie");
                            input = Console.ReadLine();
                            if (input == "1")
                            {
                                skrzynia = new Skrzynia(menu.dlugosc);

                                skrzynia.GenerowanieSekwencji(menu.dlugosc);

                                menu.iloscPunktow += Gra(menu.iloscWytrychow, menu.dlugosc, skrzynia.skrzynia, menu.iloscPunktow, menu.szansa);
                                menu.iloscSkrzyni++;
                            }
                            else if (input == "2")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Nieznana komenda!");
                                Thread.Sleep(1000);
                                Console.Clear();
                            }

                        }
                        break;
 
                    }
                }
                else if (input == "2")
                {

                    while (true)
                    {
                        menu.WyswietlOpcje();
                        input = Console.ReadLine();
                       
                        Console.Clear();
                        if (input == "1")
                        {
                            while (true)
                            {
                                menu.WyswietlUstawieniaPoziomuTrudnosci();
                                input = Console.ReadLine();
                               
                                Console.Clear();
                                if (input == "1")
                                {
                                    Console.WriteLine("Ustawiono poziom łatwy");
                                    menu.iloscWytrychow = 20;
                                    menu.dlugosc = 5;
                                    menu.szansa = 20;
                                    Thread.Sleep(1000);
                                    Console.Clear();

                                }
                                else if (input == "2")
                                {
                                    Console.WriteLine("Ustawiono poziom średni");
                                    menu.iloscWytrychow = 10;
                                    menu.dlugosc = 7;
                                    menu.szansa = 30;
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }
                                else if (input == "3")
                                {
                                    Console.WriteLine("Ustawiono poziom trudny");
                                    menu.iloscWytrychow = 5;
                                    menu.dlugosc = 10;
                                    menu.szansa = 40;
                                    Thread.Sleep(1000);
                                    Console.Clear();

                                }
                                else if (input == "0") break;
                                else
                                {
                                    Console.WriteLine("Nieznana komenda!");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }
                            }

                        }
                        else if (input == "2")
                        {
                            while (true)
                            {
                                menu.WyswietlUstawieniaDzwieku();
                                input = Console.ReadLine();
                                
                                Console.Clear();


                                if (input == "1")
                                {
                                    Console.WriteLine("Włączono dźwiek przy złamaniu wytrycha");
                                }
                                else if (input == "2")
                                {
                                    Console.WriteLine("Wyłączono dźwiek przy złamaniu wytrycha");
                                }
                                else if (input == "3") break;
                                else
                                {
                                    Console.WriteLine("Nieznana komenda!");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }


                            }


                        }

                        else if (input == "0") break;
                        else
                        {
                            Console.WriteLine("Nieznana komenda!");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }




                    }
                }
            

                else if (input == "0") break;
                else
                {
                    Console.WriteLine("Nieznana komenda!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }


            
           
        }

        

        private static void GenerowanieSekwencji(char[] sekwencja)
        {
            Random rnd = new Random();
            for (int i = 0; i < sekwencja.Length; i++)
            {
                int los = rnd.Next(0, 99);
                if (los > 50)
                {
                    sekwencja[i] = 'L';
                }
                else sekwencja[i] = 'P';
            }
        }
        private static bool zlamanieWytrycha(int szansa)
        {
            Random rnd = new Random();

            int los = rnd.Next(0, 99);
            if (los > szansa)
            {
                return false;
            }
            else return true;

        }
        private static int generujIloscPunktow(int szansa)
        {
            Random rnd = new Random();

            if (szansa == 10)
            {
                int los = rnd.Next(5, 20);
                return los;
            }
            else if (szansa == 20)
            {
                int los = rnd.Next(15, 30);
                return los;
            }
            else if (szansa == 30)
            {
                int los = rnd.Next(25, 40);
                return los;
            }
            else return 0;


        }
        private static int Gra(int iloscWytrychow, int dlugosc, char[] sekwencja,int iloscPunktow, int szansa)
        {
            
            int counter = 0;
            while (counter < dlugosc)
            {
                String input = Console.ReadLine();
                if (input.Length == 1)
                {
                    char znak = char.Parse(input);
                    if ((znak == sekwencja[counter]) && (znak == 'L' || znak == 'P'))
                    {
                        Console.WriteLine("OK");
                        counter++;
                        iloscPunktow=generujIloscPunktow(szansa);

                    }
                    else if ((znak != sekwencja[counter]) && (znak == 'L' || znak == 'P'))
                    {
                        if (zlamanieWytrycha(szansa))
                        {
                            Console.WriteLine("Zlamany wytrych! Zaczynasz od nowa.");
                            iloscWytrychow--;
                            counter = 0;
                            if (iloscWytrychow == 0)
                            {
                                Console.WriteLine("Nie masz więcej wytrychów! Koniec Gry!");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Zły ruch! Zaczynasz od nowa.");
                            counter = 0;
                        }

                    }

                    else if (znak == '0')
                    {
                        Console.WriteLine("Koniec gry!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nieznana komenda!");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
                else 
                {
                    Console.WriteLine("Nieznana komenda!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                

            }
            Console.WriteLine("Otwarto skrzynię! Zdobywasz "+iloscPunktow+" punktów!");
            return iloscPunktow;
        }
    }
}
