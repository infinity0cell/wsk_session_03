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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSearchFlights());
        }
    }
}
