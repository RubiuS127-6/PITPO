using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace СтоянкаModel
{
    class MunicipalCalc : ICalcPrice
    {
        public decimal GetPrice(Auto auto)
        {
            // муниципальный транспорт, расчёт ведётся в зависимости от часов аренды с понижающим коэффициентом.
            return auto.EachPrice * auto.TimeCount * auto.PlaceCount * 0.5M;
        }
    }
}
