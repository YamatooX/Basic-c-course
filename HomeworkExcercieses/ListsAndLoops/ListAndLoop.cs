using System;
using System.Collections.Generic;

// Twoim zadaniem domowym w tym module jest napisanie programu, który poprosi użytkownika o podaje liczby.
// Następnie poprosi go o podanie jakiejś liczby tyle razy ile wpisał za pierwszym razem (czyli jeżeli na początku wpisał 5 to musi teraz podać 5 liczb).
// Dodaj każdą liczbę do listy. Kiedy użytkownik poda wszystkie liczby wypisz na ekranie tylko te liczby, które są większe od 100.

namespace HomeworkExcercieses.ListsAndLoops
{
    class ListAndLoop
    {
        public void ListNumbersGreaterThenHunderd()
        {
            Console.WriteLine("Give me a number: ");
            string giveNumber = Console.ReadLine();

            if (string.IsNullOrEmpty(giveNumber))
            {
                Console.WriteLine("No number!");
                return;
            }

            giveNumber.Trim();
            int given;

            if(!int.TryParse(giveNumber, out given ))
            {
                Console.WriteLine("Nooooo... It's not a number!");
                return;
            }

            List<int> list = new List<int>();

            for (int i = 0; i < given; i++)
            {
                int num;
                string read;
                do
                {
                    Console.WriteLine($"Give {given - i} more numbers: ");
                    read = Console.ReadLine();
                } while (string.IsNullOrEmpty(read) || !int.TryParse(read, out num));

                if (num > 100)
                {
                    list.Add(num); 
                }
            }

            Console.WriteLine("Here are numbers greater than 100: ");

            foreach (int num in list)
            {
                Console.WriteLine(num);
            }
        }
    }
}
