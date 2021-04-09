using session_03.src.logic.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_03.src.lib.Helpers
{
    public static class CabinPriceCalculator
    {
        public static decimal Calculate(IEnumerable<Schedule> schedules, CabinType cabinType)
        {
            decimal price = decimal.Zero;
            foreach (var sch in schedules)
            {
                switch (cabinType.ID)
                {
                    case 1:
                        price += sch.EconomyPrice;
                        break;
                    case 2:
                        price += sch.BusinessPrice;
                        break;
                    case 3:
                        price += sch.FirstClassPrice;
                        break;
                    default:
                        throw new ArgumentException($"Unknown cabin type with id {cabinType.ID}", "cabinType");
                }
            }
            return price;
        }
    }
}
