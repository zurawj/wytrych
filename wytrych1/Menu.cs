using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace wytrych1
{
    internal class Menu
    {
        public int IloscWytrychow { get; set; }
        public int Szansa { get; set; }
        public int DlugoscSekwencji { get; set; }

        public int IloscSkrzyni { get; set; }

        public int IloscPunktow { get; set; }

        private Random rnd = new Random();
        public Menu()
        {   //domyslny poziom latwy
            IloscWytrychow = 10;
            DlugoscSekwencji = 4;
            Szansa = 30;
            IloscSkrzyni = 0;
            IloscPunktow = 0;
        }
        public void WyswietlMenu()
        {
            Console.WriteLine("1. Nowa gra");
            Console.WriteLine("2. Opcje");
            Console.WriteLine("3. Instrukcja");
            Console.WriteLine("4. Zakończ grę");
            Console.WriteLine("0. Wyjdź");
        }
        public void WyswietlOpcje()
        {
            Console.WriteLine("1. Ustaw poziom trudnosci");
            Console.WriteLine("2. Ustaw szanse zlamania wytrycha");
            Console.WriteLine("0. Cofnij");
        }
        public void WyswietlUstawieniaPoziomuTrudnosci()
        {   
            Console.WriteLine("Wybierz poziom trudności:");
            Console.WriteLine("1. Łatwy");
            Console.WriteLine("2. Średni");
            Console.WriteLine("3. Trudny");
            Console.WriteLine("0. Cofnij");

        }

        public void WyswietlUstawieniaWytrycha()
        {
            Console.WriteLine("Ustawienia szansy złamania wytrycha");
            Console.WriteLine("1. Mała szansa złamania wytrycha");
            Console.WriteLine("2. Średnia szansa złamania wytrycha");
            Console.WriteLine("2. Duża szansa złamania wytrycha");
            Console.WriteLine("0. Cofnij");
        }

        public void WyswietlInstrukcje()
        {
            Console.WriteLine("INSTRUKCJA");
        }

        public void UstawPoziomLatwy()
        {
            IloscWytrychow = 20;
            DlugoscSekwencji = 4;
            Szansa = 20;
        }
        public void UstawPoziomSredni()
        {
            IloscWytrychow = 10;
            DlugoscSekwencji = 7;
            Szansa = 30;
        }
        public void UstawPoziomTrudny()
        {
            IloscWytrychow = 5;
            DlugoscSekwencji = 10;
            Szansa = 40;
        }

        public int GenerujIloscPunktow(int szansa) 
        {
            
            if(szansa == 10)
            {
                int los = rnd.Next(5, 20); //przydziela od 5 do 20 punktów
                return los;
            }
            else if(szansa == 20)
            {
                int los = rnd.Next(15, 30);
                return los;
            }
            else if(szansa == 30)
            {
                int los = rnd.Next(25, 40);
                return los;
            }
            else return 0;
            

        }

        public void SleepAndClearConsole()
        {   
            Thread.Sleep(1000);
            Console.Clear();
        }
        public void SleepAndClearConsole(int time)
        {
            Thread.Sleep(time);
            Console.Clear();
        }
    }
}
