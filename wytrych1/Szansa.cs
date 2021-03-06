using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wytrych1
{
    public class Szansa
    {
         public int Latwy = 30; //30% szansy na złamanie wytrycha przy złym ruchu
         public int Sredni = 50;
         public int Trudny = 80;
        public int min = 0;
        public int max = 0;
        public int IloscWytrychow { get; set; }
        public int TempIloscWytrychow; //zabezpieczenie przed naliczaniem ujemnych wytrychów
        public int Chance { get; set; }
        public int DlugoscSekwencji { get; set; }

        public void SetSzansaLatwy()
        {
            Chance = Latwy;
            IloscWytrychow = 20;
            TempIloscWytrychow = IloscWytrychow;
            DlugoscSekwencji = 4;
            min = 5;  //zakres ilości punktów jakie zostaną przydzielone po otwarciu skrzyni
            max = 20;
        }
        public void SetSzansaSredni()
        {
            Chance = Sredni;
            IloscWytrychow = 10;
            TempIloscWytrychow = IloscWytrychow;
            DlugoscSekwencji = 7;
            min = 15;
            max = 30;
        }
        public void SetSzansaTrudny()
        {
            Chance = Trudny;
            IloscWytrychow = 5;
            TempIloscWytrychow = IloscWytrychow;
            DlugoscSekwencji = 10;
            min = 25;
            max = 40;
        }

        public void UstawMalaSzanseZlamaniaWytrycha()
        {
            Chance = Latwy;
        }
        public void UstawSredniaSzanseZlamaniaWytrycha()
        {
            Chance = Sredni;
        }
        public void UstawDuzaSzanseZlamaniaWytrycha()
        {
            Chance = Trudny;
        }
    }
}
