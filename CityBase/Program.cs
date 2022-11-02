using CityBase.Estates;
using CityBase.Utils;
using System;

namespace CityBase
{
    class Program
    {
        static void Main(string[] args)
        {
            CityManager cityManager = new CityManager();

            string address = "Kimononowicza 1234 Wożący Gbur 48-666";
            double length = 18.6;
            double width = 24.1;
            double price = 1889456;

            for(int i = 0; i < 10; i++)
            {
                cityManager.AddEstate(new Estate(i, address, Property.City,width, length, price));
                if (i == 3 || i == 1 || i == 7)
                    EstatePrinter.PrintEstate(cityManager.GetEstate(i));
            }

            cityManager.AddEstate(new Estate(3, "Inny adres", Property.Other,width, length, price));
            cityManager.AddEstate(new Estate( "Innnnnnnny adres", Property.Private, width, length, price));

            EstatePrinter.PrintAllEstates(cityManager.Estates);
        }
    }
}
