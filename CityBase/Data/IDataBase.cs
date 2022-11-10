using CityBase.Estates;
using System.Collections.Generic;

namespace CityBase.Data
{
    public interface IDataBase
    {
        void AddEstate(Estate estate);
        void RemoveEstate(int id);
        IEnumerable<Estate> GetAllEstates();
        Estate GetEstate(int id);
    }
}
