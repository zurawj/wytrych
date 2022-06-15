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

        public static void WyswietlInstrukcje()
        {
            Console.WriteLine("INSTRUKCJA");
            Console.WriteLine("Gra polega na otwieraniu zamków w skrzyniach.\n" +
                "Aby rozpocząć grę wybierz 'Nowa Gra' w menu." + "\nAby przekręcić wytrych w lewo należy nacisnąć STRZAŁKĘ W LEWO,\n" +
                "aby przekręcić wytrych w prawo należy nacisnąć STRZAŁKĘ W PRAWO.\n" +
                "Po przekręceniu wytrycha w złą stronę gracz zaczyna od początku sekwencji.\n" +
                "Przy złym ruchu istnieje szansa na złamanie wytrycha.\n" +
                "Gra kończy się gdy graczowi skończą się wytrychy, lub naciśnie '0' podczas rozgrywki.\n" +
                "Za każdą otwartą skrzynię gracz otrzymuje punkty. Ilość przydzielonych punktów zależna jest od poziomu trudności.");

            Console.WriteLine("--------------------------");
        }



    }
}
