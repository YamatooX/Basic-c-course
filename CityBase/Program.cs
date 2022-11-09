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

            double length = 18.6;
            double width = 24.1;
            double price = 1889456;

            cityManager.AddEstate(new Office("Inny adres", Property.Other, width, length, price, 10, 1500, DateTime.Now));
            cityManager.AddEstate(new Parcel("Innny adres", Property.Private, ParcelType.Agricultural, width, length, price, DateTime.Now));
            cityManager.AddEstate(new Office("Innnnny adres", Property.Other, width, length, price, 10, 1500, DateTime.Now));
            cityManager.AddEstate(new Parcel("Innnnnnnny adres", Property.Private, ParcelType.Agricultural, width, length, 14886666666, DateTime.Now));
            cityManager.AddEstate(new Office("Innnnnnnnnny adres", Property.Other, width, length, price, 10, 1500, DateTime.Now));
            cityManager.AddEstate(new Parcel("Innnnnnnnnnny adres", Property.Private, ParcelType.Agricultural, width, length, price, DateTime.Now));
            cityManager.AddEstate(new Office("Innnnnnnnnnnnnny adres", Property.Other, width, length, price, 10, 1500, DateTime.Now));
            cityManager.AddEstate(new Parcel("Innnnnnnnnnnnnnny adres", Property.Private, ParcelType.Agricultural, width, length, 9000000, DateTime.Now));

            EstatePrinter.PrintAllEstates(cityManager.GetAllEstates());

            foreach(Estate estate in cityManager.GetAllEstates())
            {
                EstatePrinter.PrintEstate(estate);
            }
        }
    }
}
