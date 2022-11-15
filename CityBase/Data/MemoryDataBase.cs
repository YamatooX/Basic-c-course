using CityBase.Estates;
using System;
using System.Collections.Generic;
using System.Linq;

// Zamień wszystkie operacje na listach przy pomocy LINQ

namespace CityBase.Data
{
    class MemoryDataBase : IDataBase
    {
        private List<Estate> _estates;

        public MemoryDataBase()
        {
            _estates = new List<Estate>();
        }

        public void AddEstate(Estate estate)
        {
            _estates.Add(estate);
        }

        public IEnumerable<Estate> GetAllEstates()
        {
            return _estates;
        }

        public void RemoveEstate(int id)
        {
            Estate estate = _estates.SingleOrDefault(x => x.Id == id);
            try
            {
                _estates.Remove(estate);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Estate is null!");
            }
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
