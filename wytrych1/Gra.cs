using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wytrych1
{
    internal class Gra
    {
        const char L = 'L';
        const char P = 'P';
        public bool fail = false;
        public bool otwartoSkrzynie = false;

        public int Graj(Skrzynia skrzynia, Menu menu)
        {
            fail = false;
            otwartoSkrzynie = false;
            int counter = 0;
            while (counter < skrzynia.SkrzyniaArray.Length)
            {   
               char znak = ZamienNaZnak(Console.ReadKey(true));
            
                    if ((znak == skrzynia.SkrzyniaArray[counter]) && (znak == L || znak == P)) 
                    {
                        Console.WriteLine("OK");
                        counter++;
                        menu.IloscPunktow = menu.GenerujIloscPunktow(menu.Szansa);

                    }
                    else if ((znak != skrzynia.SkrzyniaArray[counter]) && (znak == L || znak == P))
                    {
                        if (skrzynia.ZlamanieWytrycha(menu.Szansa))
                        {
                            menu.IloscWytrychow--;
                            Console.WriteLine("Zlamany wytrych! Zaczynasz od nowa. Pozostało "+menu.IloscWytrychow+" wytrychów." );
                            counter = 0;
                            if (menu.IloscWytrychow == 0)
                            {
                                Console.WriteLine("Nie masz więcej wytrychów! Koniec Gry!");
                                menu.SleepAndClearConsole(2000);
                                menu.IloscPunktow = 0;
                                fail = true;
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
                        fail = true;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nieznana komenda!");
                        menu.SleepAndClearConsole();

                    }
             


            }
            if (fail)
            {
                Console.Clear();
                Console.WriteLine("Koniec gry! Zdobywasz " + menu.IloscPunktow + " punktów!");
                menu.SleepAndClearConsole(2000);
                return menu.IloscPunktow;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Otwarto skrzynię! Zdobywasz " + menu.IloscPunktow + " punktów!");
                otwartoSkrzynie = true;
                menu.SleepAndClearConsole(2000);
                return menu.IloscPunktow;

            }

        }
        private char ZamienNaZnak(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.WriteLine("Lewo");
                return 'L';
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                Console.WriteLine("Prawo");
                return 'P';
            }
            else if (key.Key == ConsoleKey.D0)
            {
                return '0';
            }
            else return '1';
        }
    }
}
