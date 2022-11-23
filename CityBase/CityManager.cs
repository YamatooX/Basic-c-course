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
        private IDataBase _dataBase;    

        public CityManager()
        {
            _dataBase = new FileDataBase();
        }

        public void AddEstate(Estate estate)
        {
            _dataBase.Add(estate);
        }

        public IEnumerable<Estate> GetAllEstates()
        { 
            return _dataBase.GetAllEstates();
        }
    }
}
