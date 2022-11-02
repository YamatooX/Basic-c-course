using CityBase.Estates;
using System;
using System.Collections.Generic;
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
        private List<Estate> _estates;
        public List<Estate> Estates
        {
            get
            {
                return _estates;
            }
        }

        public CityManager()
        {
            _estates = new List<Estate>();
        }

        public void AddEstate(Estate estate)
        {
            int id;
            if (_estates.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = _estates.Count + 1;
            }

            if (estate.Id == 0)
            {
                _estates.Add(new Estate(id, estate.Address, estate.Property, estate.Width, estate.Length, estate.Price));
                return;
            }

            for(int i = 0; i < _estates.Count; i++)
            {
                if (_estates[i].Id == estate.Id)
                {
                    _estates.Remove(_estates[i]);
                }
            }
            _estates.Add(estate);
        }

        public IEnumerable<Estate> GetAllEstates()
        {
            return _estates;
        }

        public Estate GetEstate(int id)
        {
            foreach (Estate estate in _estates)
            {
                if(estate.Id == id )
                {
                    return estate;
                }
            }
            return null;
        }
    }
}
