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
        private List<Estate> _dataBase;
        private string _path;

        public FileDataBase()
        {
            _dataBase = new List<Estate>();
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
                    _dataBase.Add(HandleToRead(toSplit));
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

        public void UpdateFile()
        {
            using (StreamWriter writer = new StreamWriter(_path))
            {
                foreach (Estate estate in _dataBase)
                {
                    string s = string.Empty;
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
        }

        private Office ReadOffice(string[] line)
        {
            int id;
            if (!int.TryParse(line[0], out id))
            {
                Console.WriteLine("Incorrect id");
            }
            string address = line[1];
            Property property = Enum.Parse<Property>(line[2]);

            double length, width, price;
            if (!double.TryParse(line[4], out length))
            {
                Console.WriteLine("Incorrect length");
            }
            if (!double.TryParse(line[5], out width))
            {
                Console.WriteLine("Incorrect width");
            }
            if (!double.TryParse(line[6], out price))
            {
                Console.WriteLine("Incorrect price");
            }

            int floors, maxCapacity;
            if (!int.TryParse(line[7], out floors))
            {
                Console.WriteLine("Incorrect floors");
            }
            if (!int.TryParse(line[7], out maxCapacity))
            {
                Console.WriteLine("Incorrect capacity");
            }

            DateTime addedDate = DateTime.ParseExact(line[9], "dd-MM-yyyy", null);

            return new Office(id, address, property, width, length, price, floors, maxCapacity, addedDate);
        }

        private Parcel ReadParcel(string[] line)
        {
            int id;
            if (!int.TryParse(line[0], out id))
            {
                Console.WriteLine("Incorrect id");
            }

            string address = line[1];
            Property property = Enum.Parse<Property>(line[2]);

            double length, width, price;
            if (!double.TryParse(line[4], out length))
            {
                Console.WriteLine("Incorrect length");
            }
            if (!double.TryParse(line[5], out width))
            {
                Console.WriteLine("Incorrect width");
            }
            if (!double.TryParse(line[6], out price))
            {
                Console.WriteLine("Incorrect price");
            }

            ParcelType type = Enum.Parse<ParcelType>(line[7]);
            DateTime addedDate = DateTime.ParseExact(line[8], "dd-MM-yyyy", null);

            return new Parcel(id, address, property, type, width, length, price, addedDate);
        }

        public void Add(Estate estate)
        {
            AddEstate(estate);
            UpdateFile();
        }

        private void AddEstate(Estate estate)
        {
            int id = GenerateId();

            if (ExistsOnList(estate.Id))
            {
                RemoveEstate(estate.Id);
            }
            if (estate.Id == 0)
            { 
                if (estate is Office)
                {
                    Office office = (Office)estate;
                    _dataBase.Add(new Office(id, estate.Address, estate.Property, estate.Width, estate.Length, estate.Price, office.FloorNumber, office.MaxCapacity, DateTime.Now));
                }
                if (estate is Parcel)
                {
                    Parcel parcel = (Parcel)estate;
                    _dataBase.Add(new Parcel(id, estate.Address, estate.Property, parcel.Type, estate.Width, estate.Length, estate.Price, DateTime.Now));
                }
            }
        }

        private int GenerateId()
        {
            if(_dataBase.Count == 0)
            {
                return 1;
            }
            return _dataBase.Max( x=> x.Id + 1) ;
        }

        private bool ExistsOnList(int id)
        {
            return _dataBase.Any(x => x.Id == id);
        }

        public void RemoveEstate(int id)
        {
            Estate estate = GetEstate(id);
            if (estate == null)
            {
                return;
            }
            _dataBase.Remove(estate);
            UpdateFile();
        }

        public Estate GetEstate(int id)
        {
            Estate estate = _dataBase.SingleOrDefault(x => x.Id == id);
            return estate;
        }

        public IEnumerable<Estate> GetAllEstates()
        {
            return _dataBase;
        }

        public List<Estate> DataBase
        {
            get
            {
                return _dataBase;
            }
        }
    }
}
