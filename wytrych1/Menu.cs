using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace wytrych1
{
    public class Menu
    {
       // public int IloscWytrychow { get; set; }
       // public int TempIloscWytrychow;
        public int Szansa { get; set; }
        public int DlugoscSekwencji { get; set; }

        public int IloscSkrzyni { get; set; }

        public int IloscPunktow { get; set; }

        public ConsoleKeyInfo keyPressed;
        public int SzansaLatwy = 20;
        public int SzansaSredni = 50;
        public int SzansaTrudny = 80;

        private Random Rnd = new Random();
        public Szansa szansa = new Szansa();
        public Menu()
        {   //domyslny poziom latwy <-- maszjakies zmienne typu SznsaXXX - moze to tutaj tzeba uzyc
            szansa.SetSzansaLatwy();
           // UstawPoziom(szansa);
        }



        public void UstawPoziomLatwy()
        {
            //UstawPoziom(20, 4, SzansaLatwy);//SzansaXXX powinna byc klasa i powinna miec w sobie to 20 i 4
            //i powinna byc metoda Ustawpoziom, ktora jakos bierze SzansaXXX i jak jej podstawie wszystko ustawia oraz wyswietla
            szansa.SetSzansaLatwy();
            Console.WriteLine("Ustawiono poziom łatwy");
            Console.WriteLine("Ilosc wytrychów: " + szansa.IloscWytrychow + "\nDługość sekwencji: " + szansa.DlugoscSekwencji);
            SleepAndClearConsole(2000);
        }
        public void UstawPoziomSredni()
        {
            szansa.SetSzansaSredni();
            Console.WriteLine("Ustawiono poziom średni");
            Console.WriteLine("Ilosc wytrychów: " + szansa.IloscWytrychow + "\nDługość sekwencji: " + szansa.DlugoscSekwencji);
            SleepAndClearConsole(2000);
        }
        public void UstawPoziomTrudny()
        {
            szansa.SetSzansaTrudny();
            Console.WriteLine("Ustawiono poziom trudny");
            Console.WriteLine("Ilosc wytrychów: " + szansa.IloscWytrychow + "\nDługość sekwencji: " + szansa.DlugoscSekwencji);
            SleepAndClearConsole(2000);
        }

        public void UstawSzanseZlamaniaWytrycha(Szansa szansa)
        {
            Console.Clear();
            if (szansa.Chance == szansa.Latwy)
            {  
                Szansa = szansa.Latwy;
                Console.WriteLine("Ustawiono małą szanse złamania wytrycha");
            }
            else if (szansa.Chance == szansa.Trudny)
            {
                Szansa = szansa.Trudny;
                Console.WriteLine("Ustawiono dużą szanse złamania wytrycha");
            }
            else
            {
                
                Szansa = szansa.Sredni;
                Console.WriteLine("Ustawiono średnią szanse złamania wytrycha");
               
            }

            
            SleepAndClearConsole();
        }
        public int GenerujIloscPunktow(Szansa szansa) 
        {
            if(szansa.min != szansa.max)
            {
                return Rnd.Next(szansa.min, szansa.max);
            }
            else return 0;
        

        }

        public void Reset()
        {
            IloscPunktow = 0;
            IloscSkrzyni = 0;
            szansa.IloscWytrychow = szansa.TempIloscWytrychow;
        }
        public void OptionsKeyPressedD1()
        {
            Clear();
            Opcje.WyswietlOpcje(Opcje.LEVEL);
            keyPressed = Console.ReadKey(true);
            Clear();
            if (keyPressed.Key == ConsoleKey.D1)
            {
                UstawPoziomLatwy();
            }
            else if (keyPressed.Key == ConsoleKey.D2)
            {
                UstawPoziomSredni();
            }
            else if (keyPressed.Key == ConsoleKey.D3)
            {
                UstawPoziomTrudny();
            }
            else if (keyPressed.Key == ConsoleKey.D0) ;
            else
            {
                Console.WriteLine("Nieznana komenda!");
                SleepAndClearConsole();
            }
        }

        public void OptionsKeyPressedD2()
        {
            Clear();
            Opcje.WyswietlOpcje(Opcje.CHANCE);
            keyPressed = Console.ReadKey(true);

            if (keyPressed.Key == ConsoleKey.D1)
            {
                UstawSzanseZlamaniaWytrycha(szansa);
            }
            else if (keyPressed.Key == ConsoleKey.D2)
            {
                UstawSzanseZlamaniaWytrycha(szansa);
            }
            else if (keyPressed.Key == ConsoleKey.D3)
            {
                UstawSzanseZlamaniaWytrycha(szansa);
            }
            else if (keyPressed.Key == ConsoleKey.D0)
            {
                Clear();
            }
            else
            {
                Console.WriteLine("Nieznana komenda!");
                SleepAndClearConsole();

            }
        }
        public void ShowInstructions()
        {
            Clear();
            Opcje.WyswietlInstrukcje();
            Console.WriteLine("Nacisnij dowlny przycisk aby wrócić");
            Console.ReadKey(true);
            Clear();
        }
        public void UnknownCommand()
        {
            Clear();
            Console.WriteLine("Nieznana komenda!");
            SleepAndClearConsole();
        }
        public void SleepAndClearConsole()
        {
            SleepAndClearConsole(1000);
        }
        public void SleepAndClearConsole(int time)
        {
            Thread.Sleep(time);
            Console.Clear();
        }
        static void Clear()
        {
            Console.Clear();
        }
    }
}
