using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        /* metoda ktora sprawdza czy tablice maja takie same dlugosci i po posortowaniu sa sobie rowne
         - warunek konieczny aby zachodzila permutacja */
        public static bool tabliceTakieSame(int[] tab1, int[] tab2)
        {
            int n = tab1.Length;
            int m = tab2.Length;

            // sprawdzenie czy dlugosci obu tablic sa rowne 
         
            if (n != m)
                return false;

            // sortowanie obydwu tablic
            Array.Sort(tab1);
            Array.Sort(tab2);

            // po posortowaniu nalezy porownac po kolei wszystkie elementy obydwu tablic
            for (int i = 0; i < n; i++)
                if (tab1[i] != tab2[i])
                    return false;

            // jezeli wszystkie elementy obydwu tablic sa rowne
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy pierwszej:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj rozmiar tablicy drugiej:");
            int n = int.Parse(Console.ReadLine());

            int[] tab1 = new int[m];
            int[] tab2 = new int[n];

            // nie ma sensu wprowadzac danych poniewaz dlugosci tablic roznia sie
            if (m != n)
            {
                Console.WriteLine("Dlugosci tablic roznia sie, wiec nie ma mozliwosci aby zaszly permutacje");
                Console.ReadKey();
                Environment.Exit(0); 
            }

            // wczytanie elementow tablic
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine("Podaj " + (i + 1) + " element tablicy pierwszej:");
                tab1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tab2.Length; i++)
            {
                Console.WriteLine("Podaj " + (i + 1) + " element tablicy drugiej:");
                tab2[i] = int.Parse(Console.ReadLine());
            }

            // wypisanie podanych przez uzytkownika elementow tablic 1 i 2
            Console.WriteLine("Podano:");
          
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.Write(tab1[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < tab2.Length; i++)
            {
                Console.Write(tab2[i]);
            }
            Console.WriteLine();

            // wywolanie metody sprawdzajacej czy tablice sa po posortowaniu sa sobie rowne
            if (tabliceTakieSame(tab1, tab2))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");


            Console.ReadKey();
        }
    }
}
