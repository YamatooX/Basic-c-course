using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Homework4
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
            printInfoAboutUser();
        }

        public void printInfoAboutUser()
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
