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

            EstatePrinter.PrintAllEstates(cityManager.GetAllEstates());

            foreach(Estate estate in cityManager.GetAllEstates())
            {
                EstatePrinter.PrintEstate(estate);
            }

            double length = 18.6;
            double width = 24.1;
            double price = 1889456;

            cityManager.AddEstate(new Office("ul. Kijowa 324/5", Property.Other, width, length, price, 10, 1500, DateTime.Now));
            cityManager.AddEstate(new Parcel("pl. Legowisko 43/78", Property.Private, ParcelType.Agricultural, width, length, price, DateTime.Now));

            EstatePrinter.PrintAllEstates(cityManager.GetAllEstates());

            // Dodaje dwa różne rekordy o tym samym id => Naprawić
            // Dodać asynchroniczność - doczytać więcej
            // Dodać updatowanie pliku
        }
    }
}
