using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wytrych1
{
    internal class Wytrych //po co ta klasa
    {
        Random rnd = new Random();

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
