using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using session_03.src.logic.db;

namespace session_03.src.logic
{
    public class FlightsSearcher
    {
        private FlightsSearchOptions SearchOptions { get; set; }
        public FlightsSearcher(FlightsSearchOptions searchOptions)
        {
            SearchOptions = searchOptions;
        }

        /// <summary>
        /// Returns list of the flights for given search options
        /// </summary>
        public List<Flight> Search()
        {
            throw new NotImplementedException();
        }
    }

    public class FlightsSearchOptions
    {
        public Airport From { get; set; }
        public Airport To { get; set; }
        public CabinType CabinType { get; set; }
        public bool IsWithReturn { get; set; }
        public DateTime OutboundDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsNDaysBeforeAndAfterOutbound { get; set; }
        public bool IsNDaysBeforeAndAfterReturn { get; set; }
        public int NDaysBeforeAndAfter { get; set; }
    }
}
