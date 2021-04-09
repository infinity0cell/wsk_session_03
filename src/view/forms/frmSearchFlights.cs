using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using session_03.src.logic;
using session_03.src.logic.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session_03.src.view.forms
{
    public partial class frmSearchFlights : Form
    {
        private FlightsSearchOptions FlightsSearchOptions { get; set; }
        public frmSearchFlights()
        {
            InitializeComponent();
            FlightsSearchOptions = new FlightsSearchOptions();
        }

        private async void frmSearchFlights_Load(object sender, EventArgs e)
        {
            var allAirports = await Program.DB.Airports.ToListAsync();
            cmbxSearchFrom.DataSource = allAirports.ToArray();
            cmbxSearchFrom.SelectedIndex = 0;
            cmbxSearchTo.DataSource = allAirports.ToArray();
            cmbxSearchTo.SelectedIndex = 1;

            var allCabinTypes = await Program.DB.CabinTypes.ToListAsync();
            cmbxSearchCabinType.DataSource = allCabinTypes;
            cmbxSearchCabinType.SelectedIndex = 0;

            //dtpSearchOutbound.Value = DateTime.Today;
            dtpSearchOutbound.Value = DateTime.Parse("05/10/2017");
            dtpSearchReturn.Value = dtpSearchReturn.Value.AddDays(10);


            // for dev
            //var allSchedules = await Program.DB.Schedules.ToListAsync();
            //var distinctSchedules = allSchedules
            //    .Select((sc) => sc.RouteID)
            //    .Distinct()
            //    .Select((RouteID) => allSchedules.First((el) => el.RouteID == RouteID))
            //    .ToList();
            //var allStr = "";
            //foreach (var item in allSchedules)
            //    allStr += $"{item.Route.DepartureAirport.IATACode} --> {item.Route.ArrivalAirport.IATACode}\n";
            //var distStr = "";
            //foreach (var item in distinctSchedules)
            //    distStr += $"{item.Route.DepartureAirport.IATACode} --> {item.Route.ArrivalAirport.IATACode}\n";
            //MessageBox.Show(allStr);
        }
        private async void btnSearchApply_Click(object sender, EventArgs e)
        {
            var errText = string.Empty;
            var from = cmbxSearchFrom.SelectedItem as Airport;
            var to = cmbxSearchTo.SelectedItem as Airport;
            var cabinType = cmbxSearchCabinType.SelectedItem as CabinType;
            var isWithReturn = rbntSearchReturn.Checked;
            var outboundDate = dtpSearchOutbound.Value;
            var returnDate = dtpSearchReturn.Value;
            var nDaysBeforeAndAfterOutbound = cbxIsNDaysBeforeAndAfterOutbound.Checked ? 3 : 0;
            var nDaysBeforeAndAfterReturn = cbxIsNDaysBeforeAndAfterReturn.Checked ? 3 : 0;

            #region Validation
            if (from == null) errText += "From airport is invalid\n";
            if (to == null) errText += "To airport is invalid\n";
            if (from != null && to != null && from == to) errText += "From and To airport must not be the same\n";
            if (cabinType == null) errText += "Cabin type is invalid\n";
            if (returnDate <= outboundDate) errText += "Return date must be after outbound\n";

            if (!string.IsNullOrWhiteSpace(errText))
            {
                MessageBox.Show(errText);
                return;
            }
            #endregion

            FlightsSearchOptions = new FlightsSearchOptions()
            {
                From = from,
                To = to,
                CabinType = cabinType,
                IsWithReturn = isWithReturn,
                OutboundDate = outboundDate,
                ReturnDate = returnDate,
                NDaysBeforeAndAfterOutbound = nDaysBeforeAndAfterOutbound,
                NDaysBeforeAndAfterReturn = nDaysBeforeAndAfterReturn,
            };
            var searcher = new FlightsSearcher(FlightsSearchOptions);
            var searchResult = await searcher.Search();

            outboundFlightBindingSource.DataSource = new SortableBindingList<Flight>(searchResult.OutboundFlights);
            returnFlightBindingSource.DataSource = new SortableBindingList<Flight>(searchResult.ReturnFlights);
        }
        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            // TODO: validate

            var frm = new frmBooking();
            frm.ShowDialog();
        }
    }
}
