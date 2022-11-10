using CityBase.Estates;
using System.IO;
using System.Collections.Generic;
using System.Text;
using CityBase.Utils;
using System;
using System.Linq;
using System.Threading.Tasks;


// Dodaj klasę FileDatabase implementującą interfejs IDatabase.
// Niech klasa FileDatabase przechowuje nieruchomości na liście ale podczas dodawania albo usuwania niech aktualizuje plik z listą nieruchomości.
// Użyj klasy FileDatabase zamiast klasy MemoryDatabase w klasie CityManager.
// Dodaj konstruktor w klasie FileDatabase, który będzie przyjmował nazwę pliku z listą nieruchomości
// Dodaj wczytywanie listy nieruchomości z pliku w konstruktorze z poprzedniego punktu

//Skorzystaj z asynchronicznych wersji funkcji do odczytu i zapisu pliku i czekaj na ich zakończenie poprzez słowo await.

namespace CityBase.Data
{
    public class FileDataBase : IDataBase
    {
        private List<Estate> _estates;
        private string _path;

        public FileDataBase()
        {
            _estates = new List<Estate>();
            _path = @"D:\KursC#\CityBase\Estates.txt";
            ReadFromFile();
        }

        private void ReadFromFile()
        {
            using (StreamReader reader = File.OpenText(_path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] toSplit = line.Split("|");
                    AddEstate(HandleToRead(toSplit));
                }
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

        public void WriteIntoFile(Estate estate)
        {
            using (StreamWriter writer = new StreamWriter(_path, append: true))
            {
                string s= "";
                if (estate is Office)
                {
                    Office office = (Office)estate;
                    s = $"{office.Id}|{office.Address}|{office.Property}|Office|{office.Width}|{office.Length}|{office.Price}|{office.FloorNumber}|{office.MaxCapacity}|{office.Date.ToString("dd-MM-yyyy")}";
                    //  9|Ul.Kwiatowa 11|City|Office|40|20|2000000|4|100|11-02-2020

                }
                if (estate is Parcel)
                {
                    Parcel parcel = (Parcel)estate;
                    s = $"{parcel.Id}|{parcel.Address}|{parcel.Property}|Parcel|{parcel.Width}|{parcel.Length}|{parcel.Price}|{parcel.Type}|{parcel.Date.ToString("dd-MM-yyyy")}";
                    //  10|Ul.Stara 22|Other|Parcel|100|400|10000000|Agricultural|10-10-2019
                }

                writer.WriteLine(s);
            }
        }

        private Office ReadOffice(string[] line)
        {
            int number = int.Parse(line[0]);
            string address = line[1];
            Property property = Enum.Parse<Property>(line[2]);
            double length = double.Parse(line[4]);
            double width = double.Parse(line[5]);
            double price = double.Parse(line[6]);
            int floors = int.Parse(line[7]);
            int maxCapacity = int.Parse(line[8]);
            DateTime addedDate = DateTime.ParseExact(line[9], "dd-MM-yyyy", null);

            return new Office(number, address, property, width, length, price, floors, maxCapacity, addedDate);
        }
        private Parcel ReadParcel(string[] line)
        {
            int number = int.Parse(line[0]);
            string address = line[1];
            Property property = Enum.Parse<Property>(line[2]);
            double length = double.Parse(line[4]);
            double width = double.Parse(line[5]);
            double price = double.Parse(line[6]);
            ParcelType type = Enum.Parse<ParcelType>(line[7]);
            DateTime addedDate = DateTime.ParseExact(line[8], "dd-MM-yyyy", null);

            return new Parcel(number, address, property, type, width, length, price, addedDate);
        }

        public void AddEstate(Estate estate)
        {
            _estates.Add(estate);
        }

        public void RemoveEstate(int id)
        {
            Estate estate = _estates.SingleOrDefault(x => x.Id == id);
            _estates.Remove(estate);
        }

        public IEnumerable<Estate> GetAllEstates()
        {
            return _estates;
        }

        public Estate GetEstate(int id)
        {
            Estate estate = _estates.SingleOrDefault(x => x.Id == id);
            return estate;
        }

        public List<Estate> Estates
        {
            get
            {
                return _estates;
            }
        }
    }
}
