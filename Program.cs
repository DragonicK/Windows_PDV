using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_PDV.View;

namespace Windows_PDV {
    static class Program {
        public static frmMain MainForm { get; set; } = new frmMain();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(MainForm);
        }
    }
}
