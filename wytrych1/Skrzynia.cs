using System;

namespace wytrych1
{
    public class Skrzynia
    {
        private const char L = 'L';
        private const char P = 'P';
        private const int Min = 0;
        private const int Max = 99;

        public char[] SkrzyniaArray { get; set; }
        private Random Rnd = new Random();

        public Skrzynia(Menu menu)
        {
            this.SkrzyniaArray = new char[menu.szansa.DlugoscSekwencji];
        }
        public void GenerowanieSekwencji(Menu menu)
        {
            
            for (int i = 0; i < menu.szansa.DlugoscSekwencji; i++)
            {  
                if (Rnd.Next(0, 2) > 0)
                {
                    this.SkrzyniaArray[i] = L;
                }
                else this.SkrzyniaArray[i] = P;
            }
        }


        public bool ZlamanieWytrycha(int szansa)
        {
            return (Rnd.Next(Min, Max) <= szansa);
        }

    }
}
