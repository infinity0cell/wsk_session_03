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
    public partial class frmBooking : Form
    {
        private Flight SelectedOutboundFlight { get; set; }
        private Flight SelectedReturnFlight { get; set; }

        public frmBooking(Flight selectedOutboundFlight, Flight selectedReturnFlight)
        {
            SelectedOutboundFlight = selectedOutboundFlight;
            SelectedReturnFlight = selectedReturnFlight;
            
            InitializeComponent();
        }
        async private void frmBooking_Load(object sender, EventArgs e)
        {
            var allCountries = await Program.DB.Countries.ToListAsync();
            cmbxPassportCountry.DataSource = new BindingList<Country>(allCountries);
            cmbxPassportCountry.SelectedIndex = 0;

            lblOutboundFrom.Text = SelectedOutboundFlight.From.ToString();
            lblOutboundTo.Text = SelectedOutboundFlight.To.ToString();
            lblOutboundCabinType.Text = SelectedOutboundFlight.CabinType.ToString();
            lblOutboundFlightNumbers.Text = SelectedOutboundFlight.FlightNumbersStr;
            
            if (SelectedReturnFlight != null)
            {
                lblReturnFrom.Text = SelectedReturnFlight.From.ToString();
                lblReturnTo.Text = SelectedReturnFlight.To.ToString();
                lblReturnCabinType.Text = SelectedReturnFlight.CabinType.ToString();
                lblReturnFlightNumbers.Text = SelectedReturnFlight.FlightNumbersStr;
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            var firstname = tbxFirstname.Text;
            var lastname = tbxLastname.Text;
            var birthdate = dtpBirthdate.Value;
            var passportNumber = tbxPassportNumber.Text;
            var passportCountry = cmbxPassportCountry.SelectedItem as Country;
            var phone = mtbxPhone.Text;

            #region Validation
            var errText = "";
            if (firstname.Length <= 0) errText += "Invalid firstname\n";
            if (lastname.Length <= 0) errText += "Invalid lastname\n";
            if (birthdate.Date == null) errText += "Invalid birthdate\n";
            if (passportNumber.Length <= 0) errText += "Invalid passport number\n";
            if (passportCountry == null) errText += "Invalid passport country\n";
            if (phone.Replace(" ", "").Length <= 5) errText += "Invalid phone\n";
            if (!string.IsNullOrWhiteSpace(errText))
            {
                MessageBox.Show(errText);
                return;
            }
            #endregion

            var passenger = new Passenger()
            {
                Firstname = firstname,
                Lastname = lastname,
                Birthdate = birthdate,
                PassportNumber = passportNumber,
                PassportCountry = passportCountry,
                Phone = phone,
            };
            passengerBindingSource.Add(passenger);
        }

        private void btnRemovePassenger_Click(object sender, EventArgs e)
        {
            passengerBindingSource.RemoveCurrent();
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            var passengers = passengerBindingSource.List;
            if (!(passengers != null && passengers.Count > 0))
            {
                MessageBox.Show("Invalid passengers list");
                return;
            }

            var frm = new frmBillingConfirmation(SelectedOutboundFlight, SelectedReturnFlight, passengers);
            frm.ShowDialog();
        }
    }
}
