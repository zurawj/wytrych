using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wytrych1
{
    internal class Wytrych
    {

 
        public bool zlamanieWytrycha(int szansa)
        {
            Random rnd = new Random();
        //edit 
                int los = rnd.Next(0, 99);
            if (los > szansa)
            {
                return false;
            }
            else return true;
            
        }

        
    }
}
