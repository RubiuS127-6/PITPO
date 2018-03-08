using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace СтоянкаModel
{
    class TruckCalc : ICalcPrice
    {
        public decimal GetPrice(Auto auto)
        {
            //грузовой автомобиль, расчёт ведётся и с учётом часов и с учётом габаритов грузовика;
            return auto.EachPrice * auto.TimeCount * auto.PlaceCount;
        }
    }
}
