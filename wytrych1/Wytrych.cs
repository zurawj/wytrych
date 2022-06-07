using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wytrych1
{
    internal class Wytrych
    {

        //metoda z duzej litery
        public bool zlamanieWytrycha(int szansa)
        {
            //statyczne
            Random rnd = new Random();
           
            //co to jest 0 i 99 ?? moze zmienne const?
                int los = rnd.Next(0, 99);
            //return (los <= szansa);
            if (los > szansa)
            {
                return false;
            }
            else return true;
      
        }

        
    }
}
