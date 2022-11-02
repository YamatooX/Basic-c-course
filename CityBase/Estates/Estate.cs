using System;
using System.Collections.Generic;
using System.Text;

// Zamień pola w klasie Estate na właściwości, które można odczytać poza obiektem, ale ustawić tylko w konstruktorze.
// Dodaj do klasy Estate konstruktor, który pozwoli ustawić istniejące właściwości. Dodaj też drugi konstruktor, który nie przyjmuje numeru nieruchomości i ustawia go na 0.
// Dodaj w klasie Estate właściwość, która zwróci pole nieruchomości.
// Dodaj w klasie Estate właściwość, która zwróci cenę za metr kwadratowy nieruchomości (zakładamy, że długość i szerokość są podane w metrach)

namespace CityBase.Estates
{
    class Estate
    {
        private string _address;
        private int _id;
        private double _width;
        private double _length;
        private double _price;
        private double _area;
        private double _pricePerMeter;

        public Estate(int number, string address, double width, double length, double price)
        {
            _address = address;
            _id = number;
            _width = width;
            _length = length;
            _price = price;
            _area = _length * _width;
            _pricePerMeter = _price / _area;
        }

        public Estate(string address, double width, double length, double price)
        {
            _id = 0;
            _address = address;
            _width = width;
            _length = length;
            _price = price;
            _area = _length * _width;
            _pricePerMeter = _price / _area;
        }

        public string Address
        {
            get
            {
                return _address;
            }
            private set
            {
                _address = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            private set
            {
                _width = value;
            }
        }

        public double Length
        {
            get
            {
                return _length;
            }
            private set
            {
                _length = value;
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
                return _area;
            }
        }

        public double PricePerMeter
        {
            get
            {
                return _pricePerMeter;
            }
        }

        public override string ToString()
        {
            return $"{_id}. {_address} {_width} {_length} {_price} {_area} {_pricePerMeter}";
        }
    }
}
