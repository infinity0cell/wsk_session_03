using session_03.src.logic.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_03.src.logic
{
    public class Flight
    {
        public Airport From { get; set; }
        public Airport To { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public List<string> FlightNumbers { get {
                return Path.Select(sch => sch.FlightNumber).ToList();
            } }
        public decimal CabinPrice { get; set; }
        public string CabinPriceStr { get {
                return $"${CabinPrice}";
            } }
        public int StopsNumber { get
            {
                return FlightNumbers.Count - 1;
            } }
        public string FlightNumbersStr { get {
                return String.Join(" - ", FlightNumbers);
            } }

        public CabinType CabinType { get; set; }
        public List<Schedule> Path { get; set; }
    }
}
