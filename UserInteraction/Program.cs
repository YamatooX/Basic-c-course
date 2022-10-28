using System;
using System.IO;

// Twoją pracą domową w tym module jest pobranie od użytkownika imienia i liczby.
// Następnie wyświetl poniższy tekst, z zachowaniem podziału na linie, a w miejscach oznaczonych
// IMIE i LICZBA mają być wyświetlane imię i liczba wpisane przez użytkownika.
// A w miejscu oznaczonym jako WIĘKSZA_LICZBA ma być wyświetlana liczba większa o 1 od tej, którą podał użytkownik.

//Drogi użytkowniku IMIE.
//Uważasz, że liczba LICZBA jest właściwa?
//Czy LICZBA ma dla Ciebie takie znaczenie?
//Dziwnie IMIE, że wybrana przez Ciebie liczba to LICZBA.
//A może podając LICZBA miałeś na myśli WIĘKSZA_LICZBA?
//Jak sądzisz IMIE?


namespace UserInteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Give me a number: ");
            string number = Console.ReadLine();
            double theNumber = Convert.ToDouble(number);

            Console.WriteLine($"Drogi użytkowniku {name} { Environment.NewLine }" +
                $"Uważasz, że liczba {number} jest właściwa?{ Environment.NewLine }" +
                $"Czy {number} ma dla Ciebie takie znaczenie { Environment.NewLine }" +
                $"Dziwnie {name}, że wybrana przez Ciebie liczba to {number}{ Environment.NewLine }." +
                $"A może podając {number} miałeś na myśli {++theNumber}?{ Environment.NewLine }" +
                $"Jak sądzisz {name}?"); ;
        }
    }
}