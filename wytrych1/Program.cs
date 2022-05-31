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

                menu.WyswietlMenu();
                String input = Console.ReadLine();
                              

                Console.Clear();
                
                if (input == "1")
                {
                    Skrzynia skrzynia = new Skrzynia(menu.DlugoscSekwencji);
                    while (true)
                    {
                        Console.WriteLine("Otwórz skrzynie");
                        

                        skrzynia.GenerowanieSekwencji(menu.DlugoscSekwencji);
                        
                        menu.IloscPunktow += Graj(skrzynia,menu); 
                        menu.IloscSkrzyni++;
                        while (true)
                        {
                            Console.WriteLine("Grasz dalej?\n1.Tak\n2.Nie");
                            input = Console.ReadLine();
                            if (input == "1")
                            {
                                Console.WriteLine("Otwórz skrzynie");
                                skrzynia.GenerowanieSekwencji(menu.DlugoscSekwencji);

                                menu.IloscPunktow += Graj(skrzynia, menu);
                                menu.IloscSkrzyni++;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("Zdobyłeś " + menu.IloscPunktow + " punktów!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Nieznana komenda!");
                                menu.Sleep();
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
                                    menu.UstawPoziomLatwy();
                                    Console.WriteLine("Ilosc wytrychów: " + menu.IloscWytrychow + "\nDługość sekwencji: " + menu.DlugoscSekwencji);
                                    menu.Sleep(2000);
                                    Console.Clear();

                                }
                                else if (input == "2")
                                {
                                    Console.WriteLine("Ustawiono poziom średni");
                                    menu.UstawPoziomSredni();
                                    Console.WriteLine("Ilosc wytrychów: " + menu.IloscWytrychow + "\nDługość sekwencji: " + menu.DlugoscSekwencji);
                                    menu.Sleep(2000);
                                    Console.Clear();
                                }
                                else if (input == "3")
                                {
                                    Console.WriteLine("Ustawiono poziom trudny");
                                    menu.UstawPoziomTrudny();
                                    Console.WriteLine("Ilosc wytrychów: " + menu.IloscWytrychow + "\nDługość sekwencji: " + menu.DlugoscSekwencji);
                                    menu.Sleep(2000);
                                    Console.Clear();

                                }
                                else if (input == "0") break;
                                else
                                {
                                    Console.WriteLine("Nieznana komenda!");
                                    menu.Sleep();
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
                                    menu.Sleep();
                                    Console.Clear();
                                }


                            }


                        }

                        else if (input == "0") break;
                        else
                        {
                            Console.WriteLine("Nieznana komenda!");
                            menu.Sleep();
                            Console.Clear();
                        }




                    }
                }
            

                else if (input == "0") break;
                else
                {
                    Console.WriteLine("Nieznana komenda!");
                    menu.Sleep();
                    Console.Clear();
                }
            }


            
           
        }

        

       
        


        private static int Graj(Skrzynia skrzynia, Menu menu)
        {
            
            int counter = 0;
            while (counter < skrzynia.skrzynia.Length)
            {
                String input = Console.ReadLine();
                if (input.Length == 1)
                {
                    char znak = char.Parse(input);
                    if ((znak == skrzynia.skrzynia[counter]) && (znak == 'L' || znak == 'P')) //ustawic L i P na const, dodac regex?
                    {
                        Console.WriteLine("OK");
                        counter++;
                        menu.IloscPunktow=menu.GenerujIloscPunktow(menu.Szansa);

                    }
                    else if ((znak != skrzynia.skrzynia[counter]) && (znak == 'L' || znak == 'P'))
                    {
                        if (skrzynia.zlamanieWytrycha(menu.Szansa))
                        {
                            Console.WriteLine("Zlamany wytrych! Zaczynasz od nowa.");
                            menu.IloscWytrychow--;
                            counter = 0;
                            if (menu.IloscWytrychow == 0)
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
                        menu.Sleep();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nieznana komenda!");
                        menu.Sleep();
                        Console.Clear();
                    }
                }
                else 
                {
                    Console.WriteLine("Nieznana komenda!");
                    menu.Sleep();
                    Console.Clear();
                }
                

            }
            Console.WriteLine("Otwarto skrzynię! Zdobywasz "+menu.IloscPunktow+" punktów!");
            return menu.IloscPunktow;
        }
    }
}
