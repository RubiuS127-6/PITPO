using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace СтоянкаModel
{
    public class Auto
    {
        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public decimal EachPrice { get; set; }

        public int TimeCount { get; set; }

        public int CategoryId { get; set; }

        public int PlaceCount { get; set; }

        private ICalcPrice CalcPrice;

        public decimal GetPrice()
        {
            Validation();

            switch (CategoryId)
            {
                case 2: CalcPrice = new TruckCalc(); break;
                case 3: CalcPrice = new MunicipalCalc(); break;
                case 1:
                default: CalcPrice = new CarCalc(); break;
            }

            return CalcPrice.GetPrice(this);
        }

        private void Validation()
        {
            //if (Start > End) throw new Exception("Время начала больше чем время окончания стоянки");
            //if () throw new Exception();
        }
    }
}
