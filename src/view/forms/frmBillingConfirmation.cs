using session_03.src.lib.Helpers;
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
    public partial class frmBillingConfirmation : Form
    {
        private readonly Flight SelectedOutboundFlight;
        private readonly Flight SelectedReturnFlight;
        private readonly List<Passenger> Passengers;
        public bool CloseParentForm = false;

        public frmBillingConfirmation(Flight selectedOutboundFlight, Flight selectedReturnFlight, List<Passenger> passengers)
        {
            InitializeComponent();
            SelectedOutboundFlight = selectedOutboundFlight;
            SelectedReturnFlight = selectedReturnFlight;
            Passengers = passengers;

            var outPrice = SelectedOutboundFlight.CabinPrice;
            var returnPrice = SelectedReturnFlight != null ? SelectedReturnFlight.CabinPrice : decimal.Zero;
            var finalPriceOnePassenger = outPrice + returnPrice;
            var finalPrice = finalPriceOnePassenger * Passengers.Count;

            lblTotalAmount.Text = finalPrice.ToString("0");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        async private void btnIssueTickets_Click(object sender, EventArgs e)
        {
            var bookingReference = await UniqueBookingReferenceGenerator.Generate(Program.DB);
            var tickets = new List<Ticket>();

            var outPaths = SelectedOutboundFlight != null ? SelectedOutboundFlight.Path : new List<Schedule>();
            var allPaths = SelectedOutboundFlight.Path.Concat(outPaths);
            var user = await Program.DB.Users.FirstAsync();
            foreach (var sch in allPaths)
            {
                // TODO: создать билеты
                foreach (var psngr in Passengers)
                {
                    var ticket = new Ticket()
                    {
                        User = user,
                        Schedule = sch,
                        CabinType = SelectedOutboundFlight.CabinType,
                        Firstname = psngr.Firstname,
                        Lastname = psngr.Lastname,
                        Email = null,
                        Phone = psngr.Phone,
                        PassportNumber = psngr.PassportNumber,
                        PassportCountryID = psngr.PassportCountry.ID,
                        BookingReference = bookingReference,
                        Confirmed = true,
                    };
                    tickets.Add(ticket);
                }
            }

            Program.DB.Tickets.AddRange(tickets);
            await Program.DB.SaveChangesAsync();
            CloseParentForm = true;

            MessageBox.Show($"Successfully created {tickets.Count} tickets");
            Close();
        }
    }
}
