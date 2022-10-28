using System;
using System.Collections.Generic;
using System.Text;

namespace CityBase.Estates
{
    class Estate
    {
        string address;
        int number;
        double width;
        double length;
        decimal price;
        State state;
    }

    enum State
    {
        City,
        Private,
        Other
    }
}
