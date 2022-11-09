using CityBase.Data;
using CityBase.Estates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// Dodaj w klasie CityManager konstruktor, który będzie tworzył pustą listę nieruchomości w obiekcie.
// Dodaj w klasie CityManager funkcję, która przyjmuje obiekt klasy Estate i dodaje go do listy.
// Jeżeli nieruchomość z takim numerem już jest na liście to usuń istniejącą z listy i dodaj podaną do funkcji.
// Jeżeli obiekt ma numer ustawiony na 0 to utwórz nowy obiekt z takimi samymi danymi, ale ustaw jego numer na większy o 1 od największego numeru jaki jest na liście.
// Jeżeli lista jest pusta to ustaw numer 1.
// Zamień listę w klasie CityManager na prywatną. Dodaj funkcję, która zwróci listę wszystkich nieruchomości jako interfejs IEnumerable<Estate>.
// Dodaj w klasie CityManager funkcję, która zwróci nieruchomość o podanym numerze albo brak obiektu.

namespace CityBase
{
    public class CityManager
    {
        private MemoryDataBase _dataBase;    

        public CityManager()
        {
            _dataBase = new MemoryDataBase();
        }

        public void AddEstate(Estate estate)
        {
            int id = GenerateId();

            if (estate.Id == 0)
            {
                if (estate is Office)
                {
                    Office office = (Office)estate;
                    _dataBase.AddEstate(new Office(id, estate.Address, estate.Property, estate.Width, estate.Length, estate.Price, office.FloorNumber, office.MaxCapacity , DateTime.Now));
                }
                if(estate is Parcel)
                {
                    Parcel parcel = (Parcel)estate;
                    _dataBase.AddEstate(new Parcel(id, estate.Address, estate.Property, parcel.Type, estate.Width, estate.Length, estate.Price, DateTime.Now));
                }
            }
        }

        public IEnumerable<Estate> GetAllEstates()
        {
            return _dataBase.Estates;
        }

        private int GenerateId()
        {
            if (_dataBase.Estates.Count == 0)
            {
                return 1;
            }
            else
            {
                return _dataBase.Estates.Count + 1;
            }
        }

        public Estate GetEstate(int id)
        {
            return _dataBase.Estates.SingleOrDefault(x => x.Id == id);
        }
    }
}
