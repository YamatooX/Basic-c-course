using System;
using System.Text;

// Twoją pracą domową w tym module jest pobranie od użytkownika imienia i liczby.
// Następnie wyświetl poniższy tekst, z zachowaniem podziału na linie,
// a w miejscach oznaczonych IMIE i LICZBA mają być wyświetlane imię i liczba wpisane przez użytkownika.
// A w miejscu oznaczonym jako WIĘKSZA_LICZBA ma być wyświetlana liczba większa o 1 od tej, którą podał użytkownik.

// Drogi użytkowniku IMIE.
// Uważasz, że liczba LICZBA jest właściwa?
// Czy LICZBA ma dla Ciebie takie znaczenie?
// Dziwnie IMIE, że wybrana przez Ciebie liczba to LICZBA.
// A może podając LICZBA miałeś na myśli WIĘKSZA_LICZBA?
// Jak sądzisz IMIE?

namespace HomeworkExcercieses.UserInteraction
{
    public class UserInteractor
    {
        public void Interact()
        {
            Console.WriteLine("Give me your name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                name = "Default";
                Console.WriteLine($"Do you have any name? Now i call you {name} then");
                return;
            }

            Console.WriteLine("Give me a number: ");
            string number = Console.ReadLine();

            if (string.IsNullOrEmpty(number))
            {
                Console.WriteLine("Incorrect number");
                return;
            }

            number.Trim();
            int theNumber;

            if (!int.TryParse(number, out theNumber))
            {
                Console.WriteLine("Couldn't parse your number");
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Drogi użytkowniku {name}");
            sb.AppendLine($"Uważasz, że liczba {number} jest właściwa?");
            sb.AppendLine($"Czy {number} ma dla Ciebie takie znaczenie?");
            sb.AppendLine($"Dziwnie {name}, że wybrana przez Ciebie liczba to {number}.");
            sb.AppendLine($"A może podając {number} miałeś na myśli {++theNumber}?");
            sb.AppendLine($"Jak sądzisz {name}?");

            Console.WriteLine(sb.ToString());
        }
    }
}
