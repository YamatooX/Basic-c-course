using CityBase.Utils;
using System;
using System.Collections.Generic;

// Dodaj do projektu dwa rodzaje nieruchomości – biuro(Office) i działka(Parcel). Klasa Estate powinna być ich bazą.
// Klasa biura powinna posiadać dodatkowo podaną liczbę pięter i maksymalną liczbę osób. Klasa działki powinna zawierać informację o typie – „Budowlana”/”Rolna”.
// Dodaj do klasy Estate wirtualną metodę AdditionalInfo, zwracającą listę tekstów.
// W klasach biura i działki zaimplementuj funkcję AdditionalInfo tak aby zwracała listę wartości unikalnych dla danego typu. Przykładowo dla biura będzie to:

// „Liczba pięter: 4”
// „Maksymalna liczba osób: 150”

namespace CityBase.Estates
{
    public class Parcel : Estate
    {
        private ParcelType _type;
        
        public Parcel(string address, Property property, ParcelType type, double width, double length, double price, DateTime date) : 
                    base(address, property, width, length, price, date) 
        {
            _type = type;
        }
        public Parcel(int id, string address, Property property, ParcelType type, double width, double length, double price, DateTime date) :
                    base(id, address, property, width, length, price, date)
        {
            _type = type;
        }

        public override IEnumerable<string> AdditionalInfo()
        {
            return new List<string>() 
            { 
                $"Type: {(_type == ParcelType.Agricultural ? "Building" : "Agricultural")}" 
            }; 
        }
        public ParcelType Type
        {
            get
            {
                return _type;
            }
        }
    }
}
