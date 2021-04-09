using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using session_03.src.lib.GraphAllPathsFinder;
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
        public async Task<FlightSearchResult> Search()
        {
            // получение полетов
            var allSchedules = await Program.DB.Schedules.OrderBy(sch => sch.EconomyPrice).Where(sch => sch.Confirmed).ToListAsync();
            var distinctSchedules = allSchedules // distincted by (from, to)
                .Select(sch => $"{sch.Route.DepartureAirport.IATACode}_{sch.Route.ArrivalAirport.IATACode}")
                .Distinct()
                .Select(fromToStr => 
                    allSchedules.FirstOrDefault(sch => sch.Route.DepartureAirport.IATACode == fromToStr.Split('_')[0]
                        && sch.Route.ArrivalAirport.IATACode == fromToStr.Split('_')[1])
                    )
                .ToList();

            foreach (var item in distinctSchedules)
                Console.WriteLine(item.Route);

            // билд нод
            var nodesByIATACode = new Dictionary<string, GraphNode>();
            foreach (var sch in distinctSchedules)
            {
                var fromAirport = sch.Route.DepartureAirport.IATACode;
                var toAirport = sch.Route.ArrivalAirport.IATACode;
                if (!nodesByIATACode.ContainsKey(fromAirport))
                    nodesByIATACode[fromAirport] = new GraphNode(fromAirport);
                if (!nodesByIATACode.ContainsKey(toAirport))
                    nodesByIATACode[toAirport] = new GraphNode(toAirport);

                nodesByIATACode[fromAirport].AddChildren(nodesByIATACode[toAirport], false);
            }

            Console.WriteLine();
            foreach (var kv in nodesByIATACode)
            {
                Console.WriteLine($"{kv.Key}:");
                foreach (var child in kv.Value.Children)
                {
                    Console.WriteLine($"  {child.DisplayName}");
                }
            }

            var pathsFinder = new GraphAllPathsFinder();

            var paths1 = pathsFinder.FindAllPaths(nodesByIATACode["CAI"], nodesByIATACode["ADE"]);
            //var paths2 = pathsFinder.FindAllPaths(nodesByIATACode["RUH"], nodesByIATACode["CAI"]);
            //var paths3 = pathsFinder.FindAllPaths(nodesByIATACode["ADE"], nodesByIATACode["AUH"]);
            //var paths4 = pathsFinder.FindAllPaths(nodesByIATACode["ADE"], new GraphNode("not existing node"));

            // фильтрация + добавление возможных путей
            var outboundPaths = pathsFinder.FindAllPaths(nodesByIATACode[SearchOptions.From.IATACode], nodesByIATACode[SearchOptions.To.IATACode]);

            var outboundFlights = new List<Flight>();
            var returnFlights = new List<Flight>();

            foreach (var path in outboundPaths)
            {
                var schedules = new List<Schedule>();
                var thisPathIsInvalid = false;
                if (path.Count < 2)
                    break;
                GraphNode prev = null;
                for (int i = 0; i < path.Count; i++)
                {
                    if (prev == null)
                    {
                        prev = path[i];
                        continue;
                    }

                    var leftIATA = prev.DisplayName;
                    var rightIATA = path[i].DisplayName;
                    var schedule = allSchedules.FirstOrDefault(sch => sch.Route.DepartureAirport.IATACode == leftIATA
                        && sch.Route.ArrivalAirport.IATACode == rightIATA
                        && SearchOptions.OutboundDate >= sch.Date.AddDays(-SearchOptions.NDaysBeforeAndAfter)
                        && SearchOptions.OutboundDate <= sch.Date.AddDays(SearchOptions.NDaysBeforeAndAfter)
                        );
                    if (schedule == null)
                    {
                        thisPathIsInvalid = true;
                        break;
                    }

                    schedules.Add(schedule);

                    prev = path[i];
                }

                if (thisPathIsInvalid || schedules.Count < 2)
                    continue;

                var firstSch = schedules.First();
                var flight = new Flight()
                {
                    From = firstSch.Route.DepartureAirport,
                    To = schedules.Last().Route.ArrivalAirport,
                    Date = firstSch.Date,
                    Time = firstSch.Time,
                    CabinPrice = lib.Helpers.CabinPriceCalculator.Calculate(schedules, SearchOptions.CabinType), // TODO: подумать над ценообразованием
                    CabinType = SearchOptions.CabinType,
                    Path = schedules,
                };
                outboundFlights.Add(flight);
            }

            if (SearchOptions.IsWithReturn)
            {
                var returnPaths = pathsFinder.FindAllPaths(nodesByIATACode[SearchOptions.To.IATACode], nodesByIATACode[SearchOptions.From.IATACode]);
                foreach (var path in returnPaths)
                {
                    var schedules = new List<Schedule>();
                    var thisPathIsInvalid = false;
                    if (path.Count < 2)
                        break;
                    GraphNode prev = null;
                    for (int i = 0; i < path.Count; i++)
                    {
                        if (prev == null)
                        {
                            prev = path[i];
                            continue;
                        }

                        var leftIATA = path[i].DisplayName;
                        var rightIATA = prev.DisplayName;
                        var schedule = allSchedules.FirstOrDefault(sch => sch.Route.ArrivalAirport.IATACode == leftIATA
                            && sch.Route.DepartureAirport.IATACode == rightIATA
                            && SearchOptions.ReturnDate >= sch.Date.AddDays(-SearchOptions.NDaysBeforeAndAfter)
                            && SearchOptions.ReturnDate <= sch.Date.AddDays(SearchOptions.NDaysBeforeAndAfter)
                            );
                        if (schedule == null)
                        {
                            thisPathIsInvalid = true;
                            break;
                        }

                        schedules.Add(schedule);

                        prev = path[i];
                    }

                    if (thisPathIsInvalid || schedules.Count < 2)
                        continue;

                    var firstSch = schedules.First();
                    var flight = new Flight()
                    {
                        From = firstSch.Route.DepartureAirport,
                        To = schedules.Last().Route.ArrivalAirport,
                        Date = firstSch.Date,
                        Time = firstSch.Time,
                        CabinPrice = lib.Helpers.CabinPriceCalculator.Calculate(schedules, SearchOptions.CabinType), // TODO: подумать над ценообразованием
                        CabinType = SearchOptions.CabinType,
                        Path = schedules,
                    };
                    returnFlights.Add(flight);
                }
            }

            // результат
            var result = new FlightSearchResult()
            {
                OutboundFlights = outboundFlights,
                ReturnFlights = returnFlights,
            };
            return result;
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
        public int NDaysBeforeAndAfter { get; set; } = 0;
    }

    public class FlightSearchResult
    {
        public List<Flight> OutboundFlights { get; set; }
        public List<Flight> ReturnFlights { get; set; }
    }
}
