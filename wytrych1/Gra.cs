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
        public Gra()
        {

        }
        public int Graj(Skrzynia skrzynia, Menu menu)
        {

            int counter = 0;
            while (counter < skrzynia.skrzynia.Length)
            {
                String input = Console.ReadLine();
                if (input.Length == 1)
                {
                    char znak = char.Parse(input);
                    if ((znak == skrzynia.skrzynia[counter]) && (znak == L || znak == P)) //dodac regex?
                    {
                        Console.WriteLine("OK");
                        counter++;
                        menu.IloscPunktow = menu.GenerujIloscPunktow(menu.Szansa);

                    }
                    else if ((znak != skrzynia.skrzynia[counter]) && (znak == L || znak == P))
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
                        menu.SleepAndClearConsole();

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nieznana komenda!");
                        menu.SleepAndClearConsole();

                    }
                }
                else
                {
                    Console.WriteLine("Nieznana komenda!");
                    menu.SleepAndClearConsole();

                }


            }
            Console.WriteLine("Otwarto skrzynię! Zdobywasz " + menu.IloscPunktow + " punktów!");
            return menu.IloscPunktow;
        }

    }
}
