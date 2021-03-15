using session_03.src.logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void frmSearchFlights_Load(object sender, EventArgs e)
        {

        }

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            // TODO: validate

            var frm = new frmBooking();
            frm.ShowDialog();
        }
    }
}
