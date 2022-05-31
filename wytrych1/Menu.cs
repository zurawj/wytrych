using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wytrych1
{
    internal class Menu
    {
        public int iloscWytrychow { get; set; }
        public int szansa { get; set; }
        public int dlugosc { get; set; }

        public int iloscSkrzyni { get; set; }

        public int iloscPunktow { get; set; }
        public void WyswietlMenu()
        {
            Console.WriteLine("1. Nowa gra");
            Console.WriteLine("2. Opcje");
            Console.WriteLine("3. Instrukcja");
            Console.WriteLine("4. Zakończ grę");
            Console.WriteLine("0. Wyjdź");
        }
        public void WyswietlOpcje()
        {
            Console.WriteLine("1. Ustaw poziom trudnosci");
            Console.WriteLine("2. Ustaw dzwiek przy zlamaniu wytrycha");
            Console.WriteLine("0. Cofnij");
        }
        public void WyswietlUstawieniaPoziomuTrudnosci()
        {   
            Console.WriteLine("Wybierz poziom trudności:");
            Console.WriteLine("1. Łatwy");
            Console.WriteLine("2. Średni");
            Console.WriteLine("3. Trudny");
            Console.WriteLine("0. Cofnij");

        }

        public void WyswietlUstawieniaDzwieku()
        {
            Console.WriteLine("Ustawienia dźwięku");
            Console.WriteLine("1. Włącz dźwięk przy złamaniu wytrycha");
            Console.WriteLine("2. Wyłącz dźwięk przy złamaniu wytrycha");
            Console.WriteLine("0. Cofnij");
        }

        public void WyswietlInstrukcje()
        {
            Console.WriteLine("Instrukcja");
        }



        public int UstawSzanseZlamaniaWytrychu(int szansa)
        {
            switch (szansa)
            {
                case 1:
                    return 10;
                    
                case 2:
                    return 20;
                  
                case 3:
                    return 30;
                  
                default:
                    return 20;
              

            }
        }
        public int generujIloscPunktow(int szansa)
        {
            Random rnd = new Random();

            if(szansa == 10)
            {
                int los = rnd.Next(5, 20);
                return los;
            }
            else if(szansa == 20)
            {
                int los = rnd.Next(15, 30);
                return los;
            }
            else if(szansa == 30)
            {
                int los = rnd.Next(25, 40);
                return los;
            }
            else return 0;
            

        }
    }
}
