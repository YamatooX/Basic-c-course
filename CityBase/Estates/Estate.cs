using CityBase.Utils;
using System;
using System.Collections.Generic;
using System.Text;

// Zamień pola w klasie Estate na właściwości, które można odczytać poza obiektem, ale ustawić tylko w konstruktorze.
// Dodaj do klasy Estate konstruktor, który pozwoli ustawić istniejące właściwości. Dodaj też drugi konstruktor, który nie przyjmuje numeru nieruchomości i ustawia go na 0.
// Dodaj w klasie Estate właściwość, która zwróci pole nieruchomości.
// Dodaj w klasie Estate właściwość, która zwróci cenę za metr kwadratowy nieruchomości (zakładamy, że długość i szerokość są podane w metrach)


// Dodaj w klasie Estate właściwości z datą dodania i datą kontroli
// Zmień konstruktory klasy Estate i dodaj do nich przyjmowanie daty dodania.
// W konstruktorze z poprzedniego punktu ustawiaj datę kontroli na: data_dodania + 3 lata.

namespace CityBase.Estates
{
    public class Estate
    {
        private string _address;
        private int _id;
        private double _width;
        private double _length;
        private double _price;
        private double _area;
        private double _pricePerMeter;
        private Property _property;
        private DateTime _date;
        private DateTime _controlDate;
        
        public string Address
        {
            get
            {
                return _address;
            }
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public double Width
        {
            get
            {
                return _width;
            }
        }
        public double Length
        {
            get
            {
                return _length;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            private set
            {
                _price = value;
            }
        }
        public double Area
        {
            get
            {
                return _width * _length;
            }
        }
        public double PricePerMeter
        {
            get
            {
                return _price / _area;
            }
        }
        public Property Property
        {
            get
            {
                return _property;
            }
            set
            {
                _property = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        public DateTime ControlDate
        {
            get
            {
                return _controlDate;
            }
        }

        public Estate(int number, string address, Property property, double width, double length, double price, DateTime date)
        {
            _id = number;
            _address = address;
            _property = property;
            _width = width;
            _length = length;
            _price = price;
            _area = _length * _width;
            _pricePerMeter = _price / _area;
            _date = date;
            _controlDate = _date.AddYears(3);
        }

        public Estate(string address, Property property, double width, double length, double price, DateTime date)
        {
            _id = 0;
            _address = address;
            _property = property;
            _width = width;
            _length = length;
            _price = price;
            _area = _length * _width;
            _pricePerMeter = _price / _area;
            _date = date;
            _controlDate = _date.AddYears(3);
        }

        public virtual IEnumerable<string> AdditionalInfo()
        {
            return new List<string>();
        }
    }
}
