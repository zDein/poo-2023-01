using System;
using System.Collections.Generic;

namespace src.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int Hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            this.Hours = Hours;
        }

        public double totalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
