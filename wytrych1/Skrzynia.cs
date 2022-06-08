using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wytrych1
{
    public class Skrzynia
    {   
        //property z duzej litery
        public char[] skrzynia { get; set; }
       
        //troche dziwnie to wyglada, bo inicjujesz publiczne property w konstruktorze...
        public Skrzynia(int dlugosc)
        {
            this.skrzynia = new char[dlugosc];
        }
        public void GenerowanieSekwencji(int dlugosc)
        {
            //random - moze statyczne??
            Random rnd = new Random();
            for (int i = 0; i < dlugosc; i++)
            {
                int los = rnd.Next(0, 99);
                if (los > 50)
                {
                    //L,P - consty
                    this.skrzynia[i] = 'L';
                }
                else this.skrzynia[i] = 'P';
            }
        }


      
    }
   
}
