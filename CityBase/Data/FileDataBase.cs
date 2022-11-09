using CityBase.Estates;
using System.IO;
using System.Collections.Generic;
using System.Text;
using CityBase.Utils;
using System;

namespace CityBase.Data
{
    public class FileDataBase : IDataBase
    {
        private List<Estate> _estates;
        private string _path;
        public FileDataBase(List<Estate> list)
        {
            _estates = list;
            _path = @"D:\KursC#\CityBase\Estates.txt";
        }

        private void ReadFromFile()
        {
            using (StreamReader reader = File.OpenText(_path))
            {
                string line;
                while((line = reader.ReadLine()) != null )
                {
                    string[] toSplit = line.Split("|");
                    _estates.Add(HandleToRead(toSplit));
                }
            }
        }

        private void WriteIntoFile()
        {
            using (StreamWriter writer = new StreamWriter(_path))
            {
                // Podzielić Estate na elementy po znaku " | "

            }
        }

        private Estate HandleToRead(string[] line)
        {
            if (line[3] == "Office")
            {
                return ReadOffice(line);
            }
            if (line[3] == "Parcel")
            {
                return ReadParcel(line);
            }
            return null;
        }

        private void HandleToWrite()
        {
            // Podzielić Estate na elementy po znaku "|"

        }
        private Office ReadOffice(string[] line)
        {
            int number = int.Parse(line[0]);
            string address = line[1];
            Property property = Enum.Parse<Property>(line[2]);
            double length = double.Parse(line[3]);
            double width = double.Parse(line[4]);
            double price = double.Parse(line[5]);
            DateTime addedDate = DateTime.ParseExact(line[6], "dd-MM-yyyy", null);
            int floors = int.Parse(line[7]);
            int maxCapacity = int.Parse(line[8]);

            return new Office(number, address, property, width, length, price, floors, maxCapacity, addedDate);
        }
        private Parcel ReadParcel(string[] line)
        {
            int number = int.Parse(line[0]);
            string address = line[1];
            Property property = Enum.Parse<Property>(line[2]);
            ParcelType type = Enum.Parse<ParcelType>(line[3]);
            double length = double.Parse(line[4]);
            double width = double.Parse(line[5]);
            double price = double.Parse(line[6]);
            DateTime addedDate = DateTime.ParseExact(line[7], "dd-MM-yyyy", null);

            return new Parcel(number, address, property, type, width, length, price, addedDate);
        }

        public void AddEstate(Estate estate)
        {
            throw new NotImplementedException();
        }

        public void RemoveEstate(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Estate> GetAllEstates()
        {
            throw new NotImplementedException();
        }
    }
}
