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
            //zeby to bylo obiektowo to klasa gra powinna miec pewnie klasa Menu w sobie (bo Menu jest powiazane z gra) oraz Skrzynia
            //i tutaj powinienies tylko tworzyc obiekt klasy Gra i wysolac metode Graj czy cos takiego.
            //reszta powinna sie dziac w środku.

            Menu menu = new Menu();
            while (true)
            {
               
                Clear();
                Opcje.WyswietlOpcje(Opcje.MENU);
                Skrzynia skrzynia = new Skrzynia(menu);
                ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                if (keyPressed.Key == ConsoleKey.D1)
                {
                    Gra gra = new Gra();
                    menu.Reset();


                    while (true)
                    {
                        Clear();
                        Console.WriteLine("Otwórz skrzynie");
                        skrzynia.GenerowanieSekwencji(menu);

                            
                            menu.IloscPunktow += gra.Graj(skrzynia, menu);
                            if (gra.otwartoSkrzynie)
                            {
                                menu.IloscSkrzyni++;
                            }
                            if (gra.fail)
                            {
                                break;
                            }
                           
                        while (true)
                        {
                            Console.WriteLine("Grasz dalej?\n1.Tak\n2.Nie");
                            keyPressed = Console.ReadKey(true);
                            if (keyPressed.Key == ConsoleKey.D2)
                            {
                                Clear();
                                Console.WriteLine("Zdobywasz " + menu.IloscPunktow + " punktów!\nIlość otwartych skrzyni: " + menu.IloscSkrzyni);
                                menu.SleepAndClearConsole(3000);
                                break;
                            }
                            else if (keyPressed.Key == ConsoleKey.D1)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Nieznana komenda!");
                                menu.SleepAndClearConsole();
                                continue;
                            }
 
                        }


                        if (keyPressed.Key == ConsoleKey.D2)
                        {
                            break;
                        }

                    }
                   
                }

                else if (keyPressed.Key == ConsoleKey.D2)
                {
                    while (true)
                    {
                        Clear();
                        Opcje.WyswietlOpcje(Opcje.OPTIONS);
                        keyPressed = Console.ReadKey(true);
                        if (keyPressed.Key == ConsoleKey.D1)
                        {
                            //takie bloki kodu jak ten ponizej powinny byc w jakiejsc metodzie zrobione
                            menu.optionsKeyPressedD1();

                        }
                        else if (keyPressed.Key == ConsoleKey.D2)
                        {
                            menu.optionsKeyPressedD2();

                        }
                        else if (keyPressed.Key == ConsoleKey.D0)
                        {
                        break;

                        }
                        else
                        {
                            menu.unknownCommand();
                        }

                    }
                }
                else if (keyPressed.Key == ConsoleKey.D3)
                {
                    Clear();
                    menu.WyswietlInstrukcje();
                    Console.WriteLine("Nacisnij dowlny przycisk aby wrócić");
                    Console.ReadKey(true);
                    Clear();
                }
                else if (keyPressed.Key == ConsoleKey.D0)
                {
                    Clear();
                    break;
                }
                else
                {
                    menu.unknownCommand();
                }
            }

        }
        static void Clear()
        {
            Console.Clear();
        }
    }
}
