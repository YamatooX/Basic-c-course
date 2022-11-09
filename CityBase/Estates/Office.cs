using CityBase.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBase.Estates
{
    public class Office : Estate
    {
        private int _floorNumber;
        private int _maxCapacity;
        public Office(string address, Property property, double width, double length, double price, int floors, int capacity, DateTime date) : 
            base(address, property, width, length, price, date)
        {
            _floorNumber = floors;
            _maxCapacity = capacity;
        }
        public Office(int id, string address, Property property, double width, double length, double price, int floors, int capacity, DateTime date) :
            base(id, address, property, width, length, price, date)
        {
            _floorNumber = floors;
            _maxCapacity = capacity;
        }
        public override IEnumerable<string> AdditionalInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();

            return new List<string>() {
                $"Number of floors: {_floorNumber}",
                $"Capacity: {_maxCapacity}"
            };
        }

        public int FloorNumber
        {
            get
            {
                return _floorNumber;
            }
        }

        public int MaxCapacity
        {
            get
            {
                return _maxCapacity;
            }
        }
    }
}
