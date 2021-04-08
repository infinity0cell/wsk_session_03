using session_03.src.logic.db;
using session_03.src.view.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session_03.src
{
    static class Program
    {
        static private DatabaseContext _DB { get; set; }
        static public DatabaseContext DB { get
            {
                if (_DB != null)
                    return _DB;
                _DB = new DatabaseContext();
                return _DB;
            } }


        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var allAirports = DB.Airports.ToList();
            var allCabinTypes = DB.CabinTypes.ToList();
            var opts = new logic.FlightsSearchOptions()
            {
                From = allAirports.Find(a => a.IATACode == "DOH"),
                To = allAirports.Find(a => a.IATACode == "BAH"),
                CabinType = allCabinTypes.First(),
                IsWithReturn = false,
                IsNDaysBeforeAndAfterOutbound = false,
                IsNDaysBeforeAndAfterReturn = false,
                NDaysBeforeAndAfter = 0,
                OutboundDate = DateTime.Parse("05/10/2017"),
            };
            var flightsSearcher = new logic.FlightsSearcher(opts);
            var result = flightsSearcher.Search();

            result.Wait();
            //return;

            //lib.GraphAllPathsFinder.GraphsTest.Main_();
            //Console.ReadKey();
            //return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSearchFlights());
        }
    }
}
