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
                // String input = Console.ReadLine();
                //Console.Clear();
                Skrzynia skrzynia = new Skrzynia(menu);
                // ConsoleKey key = Console.ReadKey().Key;
                ConsoleKeyInfo keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.D1)
                {
                    Gra gra = new Gra();
                    menu.IloscPunktow = 0;
                    menu.IloscSkrzyni = 0;


                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Otwórz skrzynie");
                        skrzynia.GenerowanieSekwencji(menu);

                        menu.IloscPunktow += gra.Graj(skrzynia, menu);
                        if (gra.otwartoSkrzynie)
                        {
                            menu.IloscSkrzyni++;
                        }
                        Console.WriteLine("Grasz dalej?\n1.Tak\n2.Nie");
                        keyPressed = Console.ReadKey();
                        if (keyPressed.Key == ConsoleKey.D2)
                        {
                            Console.Clear();
                            Console.WriteLine("Zdobywasz " + menu.IloscPunktow + " punktów!\nIlość otwartych skrzyni: " + menu.IloscSkrzyni);
                            menu.SleepAndClearConsole(3000);
                            break;
                        }
                        else if (keyPressed.Key == ConsoleKey.D1)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Nieznana komenda!");
                            menu.SleepAndClearConsole();
                        }
                    }


                }
                else if (keyPressed.Key == ConsoleKey.D2)
                {
                    menu.WyswietlOpcje();
                    keyPressed = Console.ReadKey();
                    if(keyPressed.Key == ConsoleKey.D1)
                    {
                        menu.WyswietlUstawieniaPoziomuTrudnosci();
                        keyPressed = Console.ReadKey();
                        Console.Clear();
                        if (keyPressed.Key == ConsoleKey.D1)
                        {
                            menu.UstawPoziomLatwy();
                        }
                        else if (keyPressed.Key == ConsoleKey.D2)
                        {
                            menu.UstawPoziomSredni();
                        }
                        else if (keyPressed.Key == ConsoleKey.D3)
                        {
                            menu.UstawPoziomTrudny();
                        }
                        else if (keyPressed.Key == ConsoleKey.D0) ; //break;
                        else
                        {
                            Console.WriteLine("Nieznana komenda!");
                            menu.SleepAndClearConsole();
                        }

                    }
                    else if (keyPressed.Key == ConsoleKey.D2)
                    {
                        menu.WyswietlUstawieniaWytrycha();
                        keyPressed = Console.ReadKey();

                        if (keyPressed.Key == ConsoleKey.D1)
                        {
                            menu.UstawSzanseZlamaniaWytrycha(menu.SzansaLatwy);
                        }
                        else if (keyPressed.Key == ConsoleKey.D2)
                        {
                            menu.UstawSzanseZlamaniaWytrycha(menu.SzansaSredni);
                        }
                        else if (keyPressed.Key == ConsoleKey.D3)
                        {
                            menu.UstawSzanseZlamaniaWytrycha(menu.SzansaTrudny);
                        }
                        else if (keyPressed.Key == ConsoleKey.D0);
                        else
                        {
                            Console.WriteLine("Nieznana komenda!");
                            menu.SleepAndClearConsole();

                        }

                    }
                    else if (keyPressed.Key == ConsoleKey.D0)
                    {
                      //  break;

                    }
                    else
                    {
                        Console.WriteLine("Nieznana komenda!");
                        menu.SleepAndClearConsole();
                    }


                }
                else if (keyPressed.Key == ConsoleKey.D3)
                {

                }
                else if (keyPressed.Key == ConsoleKey.D0)
                {
                    
                }
                else
                {
                    Console.WriteLine("Nieznana komenda!");
                    menu.SleepAndClearConsole();
                }
            }





        }

    }
}
