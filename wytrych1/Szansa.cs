using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wytrych1
{
    public class Szansa
    {
         public int Latwy = 20;
         public int Sredni = 50;
         public int Trudny = 80;
        public int min = 0;
        public int max = 0;
        public int IloscWytrychow { get; set; }
        public int TempIloscWytrychow;
       // public int Szansa { get; set; }
        public int DlugoscSekwencji { get; set; }

        public Szansa GetChanceEasy()
        {
            return new Szansa();
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
