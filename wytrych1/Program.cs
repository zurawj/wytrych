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
               
                Clear();
                menu.WyswietlMenu();
                Skrzynia skrzynia = new Skrzynia(menu);
                ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                if (keyPressed.Key == ConsoleKey.D1)
                {
                    Gra gra = new Gra();
                    menu.IloscPunktow = 0;
                    menu.IloscSkrzyni = 0;
                    menu.IloscWytrychow = menu.TempIloscWytrychow;

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
                            Console.WriteLine("koniec");
                            break;
                            }
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
                    while (true)
                    {
                        Clear();
                        menu.WyswietlOpcje();
                        keyPressed = Console.ReadKey(true);
                        if (keyPressed.Key == ConsoleKey.D1)
                        {
                            Clear();
                            menu.WyswietlUstawieniaPoziomuTrudnosci();
                            keyPressed = Console.ReadKey(true);
                            Clear();
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
                            else if (keyPressed.Key == ConsoleKey.D0);
                            else
                            {
                                Console.WriteLine("Nieznana komenda!");
                                menu.SleepAndClearConsole();
                            }

                        }
                        else if (keyPressed.Key == ConsoleKey.D2)
                        {
                            Clear();
                            menu.WyswietlUstawieniaWytrycha();
                            keyPressed = Console.ReadKey(true);

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
                            else if (keyPressed.Key == ConsoleKey.D0)
                            { 
                                Clear(); 
                            }
                            else
                            {
                                Console.WriteLine("Nieznana komenda!");
                                menu.SleepAndClearConsole();

                            }

                        }
                        else if (keyPressed.Key == ConsoleKey.D0)
                        {
                        break;

                        }
                        else
                        {
                            Clear();
                            Console.WriteLine("Nieznana komenda!");
                            menu.SleepAndClearConsole();
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
                {   Clear();
                    Console.WriteLine("Nieznana komenda!");
                    menu.SleepAndClearConsole();
                }
            }


            


        }
        static void Clear()
        {
            Console.Clear();
        }
    }
}
