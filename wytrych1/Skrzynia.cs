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
       
        public Skrzynia(int dlugosc)
        {
            this.skrzynia = new char[dlugosc];
        }
        public void GenerowanieSekwencji(int dlugosc)
        {
            Random rnd = new Random();
            for (int i = 0; i < dlugosc; i++)
            {
                int los = rnd.Next(0, 99);
                if (los > 50)
                {
                    this.skrzynia[i] = 'L';
                }
                else this.skrzynia[i] = 'P';
            }
        }


      
    }
   
}
