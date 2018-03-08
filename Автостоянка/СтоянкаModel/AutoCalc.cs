using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace СтоянкаModel
{
    class CarCalc : ICalcPrice
    {
        public decimal GetPrice(Auto auto)
        {
            //обычный автомобиль расчёт аренды ведётся в зависимости от часов, сколько автомобиль стоит на стоянке;
            return auto.EachPrice * auto.TimeCount;
        }
    }
}
