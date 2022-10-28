using System;
using System.Collections.Generic;

// Twoim zadaniem domowym w tym module jest napisanie programu, który poprosi użytkownika o podaje liczby.
// Następnie poprosi go o podanie jakiejś liczby tyle razy ile wpisał za pierwszym razem (czyli jeżeli na początku wpisał 5 to musi teraz podać 5 liczb).
// Dodaj każdą liczbę do listy. Kiedy użytkownik poda wszystkie liczby wypisz na ekranie tylko te liczby, które są większe od 100.

namespace LoopsList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");
            string giveNumber = Console.ReadLine();
            int given = int.Parse(giveNumber);
            List<int> list = new List<int>();

            for (int i = 1; i <= given; i++)
            {
                Console.WriteLine("Give more numbers: ");
                string read = Console.ReadLine();
                int num = int.Parse(read);
                list.Add(num);
            }
            Console.WriteLine($"Here are numbers greater than 100: ");
            foreach (int num in list)
            {
                if (num > 100)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
