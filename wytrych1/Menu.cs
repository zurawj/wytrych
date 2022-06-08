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

        public const int SzansaLatwy = 20;
        public const int SzansaSredni = 30;
        public const int SzansaTrudny = 80;

        private Random rnd = new Random();
        public Menu()
        {   //domyslny poziom latwy
            IloscWytrychow = 10;
            DlugoscSekwencji = 4;
            Szansa = 20;
        }
        public void WyswietlMenu()
        {   
            string[] listaOpcji = { "1. Nowa gra", "2. Opcje", "3. Instrukcja", "0. Wyjdz" };
            List<string> MenuOpcje = new List<string>(listaOpcji);
            WyswietlListeOpcji(MenuOpcje);
        }
        public void WyswietlOpcje()
        {
            string[] listaOpcji = { "1. Ustaw poziom trudnosci", "2. Ustaw szanse zlamania wytrycha", "0. Cofnij" };
            List<string> MenuOpcje = new List<string>(listaOpcji);
            WyswietlListeOpcji(MenuOpcje);
        }
        public void WyswietlUstawieniaPoziomuTrudnosci()
        {
            string[] listaOpcji = { "Wybierz poziom trudności:", "1. Łatwy", "2. Średni", "3. Trudny" , "0. Cofnij" };
            List<string> MenuOpcje = new List<string>(listaOpcji);
            WyswietlListeOpcji(MenuOpcje);
        }

        public void WyswietlUstawieniaWytrycha()
        {
            string[] listaOpcji = { "Ustawienia szansy złamania wytrycha", "1. Mała szansa złamania wytrycha", "2. Średnia szansa złamania wytrycha",
                "3. Duża szansa złamania wytrycha", "0. Cofnij" };
            List<string> MenuOpcje = new List<string>(listaOpcji);
            WyswietlListeOpcji(MenuOpcje);
        }

        public void WyswietlInstrukcje()
        {
            Console.WriteLine("INSTRUKCJA");
            Console.WriteLine("Gra polega na otwieraniu zamków w skrzyniach.\n" +
                "Aby rozpocząć grę wybierz 'Nowa Gra' w menu." + "\nAby przekręcić wytrych w lewo należy wpisać L i nacisnąć ENTER,\n" +
                "aby przekręcić wytrych w prawo należy wpisać P i nacisnąć ENTER.\n" +
                "Po przekręceniu wytrycha w złą stronę gracz zaczyna od początku sekwencji.\n" +
                "Przy złym ruchu istnieje szansa na złamanie wytrycha.\n" +
                "Gra kończy się gdy graczowi skończą się wytrychy, lub naciśnie '0' podczas rozgrywki.\n"+
                "Za każdą otwartą skrzynię gracz otrzymuje punkty. Ilość przydzielonych punktów zależna jest od poziomu trudności.");

            Console.WriteLine("--------------------------");
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
            UstawPoziom(20, 4, SzansaLatwy);
        }
        public void UstawPoziomSredni()
        {
            UstawPoziom(10, 7, SzansaSredni);
        }
        public void UstawPoziomTrudny()
        {
            UstawPoziom(5, 10, SzansaTrudny);
        }
        private void UstawPoziom(int IloscWytrychow, int DlugoscSekwencji, int Szansa)
        {
            this.IloscWytrychow = IloscWytrychow;
            this.DlugoscSekwencji = DlugoscSekwencji;
            this.Szansa = Szansa;
        }
        public int GenerujIloscPunktow(int szansa) 
        {
            
            if(szansa == SzansaLatwy)
            {
                int los = rnd.Next(5, 20); //przydziela od 5 do 20 punktów
                return los;
            }
            else if(szansa == SzansaSredni)
            {
                int los = rnd.Next(15, 30);
                return los;
            }
            else if(szansa == SzansaTrudny)
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
