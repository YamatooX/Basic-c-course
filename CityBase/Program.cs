using CityBase.Estates;
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
                cityManager.AddEstate(new Estate(i, address, width, length, price));
            }

            foreach(Estate e in CityManager.Estates)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
