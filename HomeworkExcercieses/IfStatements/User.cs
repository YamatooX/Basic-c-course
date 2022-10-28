using System;
using System.Globalization;

// Napisz program, który poprosi użytkownika o podanie liczby.
// Następnie oblicz wartość rabatu wg następującej reguły:
// Jeżeli liczba jest większa od 300 to rabat ma wynosić 10%.
// Jeżeli liczba jest większa od 200 to rabat ma wynosić 15%.
// Jeżeli liczba jest mniejsza niż 200 to rabat ma wynosić 20%.
// Dodaj enum UserType z dwoma wartościami – Standard, Premium.
// Do kodu z poprzedniego punktu dopisz kod, który przypisze
// do zmiennej typ użytkownika jako Premium jeżeli podana przez
// użytkownika liczba po odjęciu rabatu (podana_liczba - wartosc_rabatu)
// jest większa niż 400. W przeciwnym razie przypisz wartość Standard.
// Następnie wypisz na ekranie tekst zależnie od ustawionego przed chwilą typu.
// Jeżeli jest to Standard wypisz „Użytkowniku, dziękujemy za zakupy”.
// Jeżeli jest to Premium to wypisz „Użytkowniku! Serdecznie dziękujemy za zakupy!”.

namespace HomeworkExcercieses.IfStatements
{
    public class User
    {
        public string Name;
        public double Money;
        public UserType userType;

        public User(double money)
        {
            Name = "Jarek";
            Money = money;
            PrintInfoAboutUser();
        }

        public User() { }

        public void PrintInfoAboutUser()
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

            double number = Money;
            double priceAfterDiscount;

            if (number > 300)
            {
                priceAfterDiscount = number * 0.9;
                Console.WriteLine($"You have 10% discount => {priceAfterDiscount.ToString("N", nfi)}");
                if (priceAfterDiscount > 400)
                {
                    userType = UserType.Premium;
                }
            }
            else if (number > 200)
            {
                priceAfterDiscount = number * 0.85;
                Console.WriteLine($"You have 15% discount => {priceAfterDiscount.ToString("N", nfi)}");
                userType = UserType.Standard;
            }
            else
            {
                priceAfterDiscount = number * 0.80;
                Console.WriteLine($"You have 20% discount => {priceAfterDiscount.ToString("N", nfi)}");
                userType = UserType.Standard;
            }
            Console.WriteLine($"Thank you for your money {Name} {userType}");
        }
    }

    public enum UserType
    {
        Premium,
        Standard
    }
}
