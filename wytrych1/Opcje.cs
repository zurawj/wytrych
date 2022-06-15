using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wytrych1
{
    public static class Opcje
    {
        public static string[] MENU = { "1. Nowa gra", "2. Opcje", "3. Instrukcja", "0. Wyjdz" };
        public static string[] OPTIONS = { "1. Ustaw poziom trudnosci", "2. Ustaw szanse zlamania wytrycha", "0. Cofnij" };
        public static string[] LEVEL = { "Wybierz poziom trudności:", "1. Łatwy", "2. Średni", "3. Trudny", "0. Cofnij" };

        public static string[] CHANCE = { "Ustawienia szansy złamania wytrycha", "1. Mała szansa złamania wytrycha", "2. Średnia szansa złamania wytrycha",
                "3. Duża szansa złamania wytrycha", "0. Cofnij" };


        public static void WyswietlOpcje(string[] lista)
        {
            foreach (string l in lista)
            {
                Console.WriteLine(l);
            }
        }



    }
}
