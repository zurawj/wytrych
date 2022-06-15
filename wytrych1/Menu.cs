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
        public int IloscWytrychow { get; set; }
        public int TempIloscWytrychow;
        public int Szansa { get; set; }
        public int DlugoscSekwencji { get; set; }

        public int IloscSkrzyni { get; set; }

        public int IloscPunktow { get; set; }

        public ConsoleKeyInfo keyPressed;
        public int SzansaLatwy = 20;
        public int SzansaSredni = 50;
        public int SzansaTrudny = 80;

        private Random Rnd = new Random();
        public Menu()
        {   //domyslny poziom latwy <-- maszjakies zmienne typu SznsaXXX - moze to tutaj tzeba uzyc
            IloscWytrychow = 10;
            TempIloscWytrychow = IloscWytrychow;
            DlugoscSekwencji = 4;
            Szansa = 20;
        }
        /*
         * 
         * To wyswietlanie opcji ja tym zrobil tak jak ponizej
        public static class Opcje{
            public static string[] MENU = { "1. Nowa gra", "2. Opcje", "3. Instrukcja", "0. Wyjdz" };
            public static string[] OPTIONS = { "1. Ustaw poziom trudnosci", "2. Ustaw szanse zlamania wytrycha", "0. Cofnij" };
            public static string[] LEVEL = { "1. Ustaw poziom trudnosci", "2. Ustaw szanse zlamania wytrycha", "0. Cofnij" };
            ....
        }

        public void WyswietlOpcje(string[] lista)
        {
            foreach (string l in lista)
            {
                Console.WriteLine(l);
            }
        }

        //Uzycie

        public void Usage()
        {
            WyswietlOpcje(Opcje.MENU);
            ...
            WyswietlOpcje(Opcje.LEVEL);
        }
        */

        public void WyswietlMenu()
        {
            Opcje.WyswietlOpcje(Opcje.MENU);

        }
        public void WyswietlOpcje()
        {
            Opcje.WyswietlOpcje(Opcje.OPTIONS);
        }
        public void WyswietlUstawieniaPoziomuTrudnosci()
        {
            Opcje.WyswietlOpcje(Opcje.LEVEL);
        }

        public void WyswietlUstawieniaWytrycha()
        {
            Opcje.WyswietlOpcje(Opcje.CHANCE);
        }

        
        public void WyswietlListeOpcji(List<string> lista)
        {

            foreach(string l in lista)
            {
                Console.WriteLine(l);
            }
            
        }

        public void UstawPoziomLatwy()
        {
            UstawPoziom(20, 4, SzansaLatwy);//SzansaXXX powinna byc klasa i powinna miec w sobie to 20 i 4
            //i powinna byc metoda Ustawpoziom, ktora jakos bierze SzansaXXX i jak jej podstawie wszystko ustawia oraz wyswietla
            
            Console.WriteLine("Ustawiono poziom łatwy");
            Console.WriteLine("Ilosc wytrychów: " + IloscWytrychow + "\nDługość sekwencji: " + DlugoscSekwencji);
            SleepAndClearConsole(2000);
        }
        public void UstawPoziomSredni()
        {
            UstawPoziom(10, 7, SzansaSredni);
            Console.WriteLine("Ustawiono poziom średni");
            Console.WriteLine("Ilosc wytrychów: " + IloscWytrychow + "\nDługość sekwencji: " + DlugoscSekwencji);
            SleepAndClearConsole(2000);
        }
        public void UstawPoziomTrudny()
        {
            UstawPoziom(5, 10, SzansaTrudny);
            Console.WriteLine("Ustawiono poziom trudny");
            Console.WriteLine("Ilosc wytrychów: " + IloscWytrychow + "\nDługość sekwencji: " + DlugoscSekwencji);
            SleepAndClearConsole(2000);
        }
        private void UstawPoziom(int IloscWytrychow, int DlugoscSekwencji,int Szansa)
        {
            this.IloscWytrychow = IloscWytrychow;
            TempIloscWytrychow = IloscWytrychow;
            this.DlugoscSekwencji = DlugoscSekwencji;
            this.Szansa = Szansa;
        }
        public void UstawSzanseZlamaniaWytrycha(int szansa)
        {
            Console.Clear();
            if (szansa == SzansaLatwy)
            {  
                Szansa = SzansaLatwy;
                Console.WriteLine("Ustawiono małą szanse złamania wytrycha");
            }
            else if (szansa == SzansaTrudny)
            {
                Szansa = SzansaTrudny;
                Console.WriteLine("Ustawiono dużą szanse złamania wytrycha");
            }
            else
            {
                
                Szansa = SzansaSredni;
                Console.WriteLine("Ustawiono średnią szanse złamania wytrycha");
               
            }

            
            SleepAndClearConsole();
        }
        public int GenerujIloscPunktow(int szansa) 
        {
            int min = 0;
            int max = 0;

            //a moze Szansa powinna byc osoba klasa, ktora zawiera min i max ?
            if (szansa == SzansaLatwy)
            {
                min = 5;
                max = 20;

            }
            else if(szansa == SzansaSredni)
            {
                min = 15;
                max = 30;
            }
            else if(szansa == SzansaTrudny)
            {
                min = 25;
                max = 40;
                
            }
            if(min != max)
            {
                return Rnd.Next(min, max);
            }
            else return 0;
            

        }

        public void Reset()
        {
            IloscPunktow = 0;
            IloscSkrzyni = 0;
            IloscWytrychow = TempIloscWytrychow;
        }
        public void optionsKeyPressedD1()
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

        public void optionsKeyPressedD2()
        {
            Clear();
            Opcje.WyswietlOpcje(Opcje.CHANCE);
            keyPressed = Console.ReadKey(true);

            if (keyPressed.Key == ConsoleKey.D1)
            {
                UstawSzanseZlamaniaWytrycha(SzansaLatwy);
            }
            else if (keyPressed.Key == ConsoleKey.D2)
            {
                UstawSzanseZlamaniaWytrycha(SzansaSredni);
            }
            else if (keyPressed.Key == ConsoleKey.D3)
            {
                UstawSzanseZlamaniaWytrycha(SzansaTrudny);
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
        public void showInstructions()
        {
            Clear();
            Opcje.WyswietlInstrukcje();
            Console.WriteLine("Nacisnij dowlny przycisk aby wrócić");
            Console.ReadKey(true);
            Clear();
        }
        public void unknownCommand()
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
