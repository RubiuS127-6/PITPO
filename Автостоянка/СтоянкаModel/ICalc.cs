using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace СтоянкаModel
{
    public interface ICalcPrice
    {
        decimal GetPrice(Auto auto);
    }
}
