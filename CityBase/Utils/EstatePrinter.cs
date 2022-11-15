// Dodaj do projektu klasę EstatePrinter w przestrzeni nazw CityBase.Utils.
// Dodaj w klasie EstatePrinter statyczną funkcję, która przyjmuje obiekt pojedynczej nieruchomości,
// wyświetla jej dane w następującym formacie (w miejsca wyrazów zapisanych dużymi literami podstaw wartości z obiektu nieruchomości.
// W miejscu własności wyświetl „Miasto„/”Prywatna„/”Inna” w zależności od wartości podanej w nieruchomości):
//NUMER – ADRES
//Własność: WŁASNOŚĆ
//Wymiary: DŁUGOŚĆ x SZEROKOŚĆ
//Powierzchnia: POWIERZCHNIA
//Cena za m2: CENA_ZA_METR
//Napisz w klasie EstatePrinter statyczną funkcję, która przyjmie i wyświetli listę nieruchomości w następującym formacie
//(zasady te same co w poprzednim punkcie. Po każdej nieruchomości dodane rozdzielenie złożone ze znaków równości):
//NUMER – ADRES(WŁASNOŚĆ)
//Powierzchnia: POWIERZCHNIA
//Cena: CENA
//================
//NUMER – ADRES (WŁASNOŚĆ)
//Powierzchnia: POWIERZCHNIA
//Cena: CENA
//================

// W funkcji wyświetlającej szczegóły jednej nieruchomości w klasie EstatePrinter dodaj wyświetlanie daty dodania i daty kontroli.

// W klasie EstatePrinter, w metodzie wyświetlającej szczegóły pojedynczej nieruchomości
// dopisz wyświetlanie wszystkich dodatkowych informacji o nieruchomości korzystając z metody dodanej w poprzednich punktach.

using CityBase.Estates;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBase.Utils
{
    public class EstatePrinter
    {
        public static void PrintEstate(Estate estate)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{estate.Id}. {estate.Address}");
            sb.AppendLine($"Ownership: {estate.Property}");
            sb.AppendLine($"Size: {estate.Length} x {estate.Width}");
            sb.AppendLine($"Area: {estate.Area}");
            sb.AppendLine($"Price per m2: {estate.PricePerMeter}");
            sb.AppendLine($"Total price: {estate.Price}");
            sb.AppendLine($"Object created: {estate.Date.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Control date: {estate.ControlDate.ToString("dd/MM/yyyy")}");
            
            foreach(string info in estate.AdditionalInfo())
            {
                sb.AppendLine(info);
            }
            Console.WriteLine(sb.ToString());
        }

        public static void PrintAllEstates(IEnumerable<Estate> estates)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Estate estate in estates)
            {
                sb.AppendLine($"{estate.Id}. {estate.Address} ({estate.Property})");
                sb.AppendLine($"Area: {estate.Area}");
                sb.AppendLine($"Total price: {estate.Price}");
                sb.AppendLine("=======================================================");
            }

            Console.WriteLine(sb.ToString());
        }

        public void PrintMenu()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("[1] Add new estate");
            sb.AppendLine("[2] Show estate");
            sb.AppendLine("[3] Show all estates");
            sb.AppendLine("[Default] Exit");

            Console.WriteLine(sb.ToString());
        }
    }
}
