using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wytrych1
{
    public class Skrzynia
    {
        public char[] skrzynia { get; set; }
        Random rnd = new Random();

        public Skrzynia(int dlugosc)
        {
            this.skrzynia = new char[dlugosc];
        }
        public void GenerowanieSekwencji(int dlugosc)
        {
            
            for (int i = 0; i < dlugosc; i++)
            {
                int los = rnd.Next(0, 2);
                if (los > 0)
                {
                    this.skrzynia[i] = 'L';
                }
                else this.skrzynia[i] = 'P';
            }
        }


        public bool zlamanieWytrycha(int szansa)
        {

            int los = rnd.Next(0, 99);
            if (los > szansa)
            {
                return false;
            }
            else return true;



        }

    }
}
