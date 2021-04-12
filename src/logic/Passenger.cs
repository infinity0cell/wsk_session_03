using session_03.src.logic.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_03.src.logic
{
    public class Passenger
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string PassportNumber { get; set; }
        public Country PassportCountry { get; set; }
        public string Phone { get; set; }
    }
}
