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
                    Gra gra = new Gra();
                    menu.IloscPunktow = 0;
                    menu.IloscSkrzyni = 0;
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Otwórz skrzynie");

                        Skrzynia skrzynia = new Skrzynia(menu.DlugoscSekwencji);
                        skrzynia.GenerowanieSekwencji(menu.DlugoscSekwencji);
                        
                        menu.IloscPunktow += gra.Graj(skrzynia,menu); 
                        if(gra.otwartoSkrzynie)
                        {
                            menu.IloscSkrzyni++;
                            
                        } 
                        while (true)
                        {
                            
                            Console.WriteLine("Grasz dalej?\n1.Tak\n2.Nie");
                            input = Console.ReadLine();
                            if (input == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("Otwórz skrzynie");
                                skrzynia.GenerowanieSekwencji(menu.DlugoscSekwencji);

                                menu.IloscPunktow += gra.Graj(skrzynia, menu);
                                if (gra.otwartoSkrzynie)
                                {
                                    menu.IloscSkrzyni++;
                                   
                                }
                            }
                            else if (input == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("Zdobywasz " + menu.IloscPunktow + " punktów!\nIlość otwartych skrzyni: "+menu.IloscSkrzyni);
                                menu.SleepAndClearConsole(3000);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Nieznana komenda!");
                                menu.SleepAndClearConsole();
                                
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
                                    menu.SleepAndClearConsole(2000);
                                    

                                }
                                else if (input == "2")
                                {
                                    Console.WriteLine("Ustawiono poziom średni");
                                    menu.UstawPoziomSredni();
                                    Console.WriteLine("Ilosc wytrychów: " + menu.IloscWytrychow + "\nDługość sekwencji: " + menu.DlugoscSekwencji);
                                    menu.SleepAndClearConsole(2000);
                                    
                                }
                                else if (input == "3")
                                {
                                    Console.WriteLine("Ustawiono poziom trudny");
                                    menu.UstawPoziomTrudny();
                                    Console.WriteLine("Ilosc wytrychów: " + menu.IloscWytrychow + "\nDługość sekwencji: " + menu.DlugoscSekwencji);
                                    menu.SleepAndClearConsole(2000);
                                    

                                }
                                else if (input == "0") break;
                                else
                                {
                                    Console.WriteLine("Nieznana komenda!");
                                    menu.SleepAndClearConsole();
                                    
                                }
                            }

                        }
                        else if (input == "2")
                        {
                            while (true)
                            {
                                menu.WyswietlUstawieniaWytrycha();
                                input = Console.ReadLine();
                                
                                Console.Clear();


                                if (input == "1")
                                {
                                    menu.Szansa = 20;
                                    Console.WriteLine("Ustawiono małą szanse złamania wytrycha");
                                    menu.SleepAndClearConsole();
                                    
                                }
                                else if (input == "2")
                                {
                                    menu.Szansa = 30;
                                    Console.WriteLine("Ustawiono średnią szanse złamania wytrycha");
                                    menu.SleepAndClearConsole();
                                    
                                }
                                else if (input == "3")
                                {
                                    menu.Szansa = 50;
                                    Console.WriteLine("Ustawiono dużą szanse złamania wytrycha");
                                    menu.SleepAndClearConsole();
                                    
                                }
                                else if (input == "0") break;
                                else
                                {
                                    Console.WriteLine("Nieznana komenda!");
                                    menu.SleepAndClearConsole();
                                    
                                }


                            }


                        }
                       
                        else if (input == "0") break;
                        else
                        {
                            Console.WriteLine("Nieznana komenda!");
                            menu.SleepAndClearConsole();
                            
                        }

                    }
                }
                else if (input == "3")
                {

                    menu.WyswietlInstrukcje();
                    Console.WriteLine("Nacisnij dowlny przycisk aby wrócić");
                    Console.ReadKey();
                    Console.Clear();

                }

                else if (input == "0") break;
                else
                {
                    Console.WriteLine("Nieznana komenda!");
                    menu.SleepAndClearConsole();
                    
                }
            }


            
           
        }

    }
}
