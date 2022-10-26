using System;
using System.IO;

namespace UserInteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();            
            string number = Console.ReadLine();
            double theNumber = Convert.ToDouble(number);

            Console.WriteLine($"Drogi użytkowniku {name}\n" +
                $"Uważasz, że liczba {number} jest właściwa?\n" +
                $"Czy {number} ma dla Ciebie takie znaczenie ?\n" +
                $"Dziwnie {name}, że wybrana przez Ciebie liczba to {number}\n." +
                $"A może podając LICZBA miałeś na myśli {++theNumber}?\n" +
                $"Jak sądzisz {name}?");
        }
    }
}
