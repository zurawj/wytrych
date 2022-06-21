using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wytrych1
{
    public class Szansa
    {
         public int Latwy = 30;
         public int Sredni = 50;
         public int Trudny = 80;
        public int min = 0;
        public int max = 0;
        public int IloscWytrychow { get; set; }
        public int TempIloscWytrychow;
        public int Chance { get; set; }
        public int DlugoscSekwencji { get; set; }

        public Szansa GetChanceEasy()
        {
          return null;
        }
        public void SetSzansaLatwy()
        {
            Chance = Latwy;
            IloscWytrychow = 20;
            TempIloscWytrychow = IloscWytrychow;
            DlugoscSekwencji = 4;
            min = 5;
            max = 15;
        }
        public void SetSzansaSredni()
        {
            Chance = Sredni;
            IloscWytrychow = 10;
            TempIloscWytrychow = IloscWytrychow;
            DlugoscSekwencji = 7;
            min = 5;
            max = 15;
        }
        public void SetSzansaTrudny()
        {
            Chance = Trudny;
            IloscWytrychow = 5;
            TempIloscWytrychow = IloscWytrychow;
            DlugoscSekwencji = 10;
            min = 5;
            max = 15;
        }
        public void GetMinMax(int szansa)
        {
            if (szansa == Latwy)
            {
                min = 5;
                max = 20;

            }
            else if (szansa == Sredni)
            {
                min = 15;
                max = 30;
            }
            else if (szansa == Trudny)
            {
                min = 25;
                max = 40;

            }
        }


    }
}
