using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Interfaces;

namespace Windows_PDV.View {
    public partial class frmVenda : MetroForm, IMetroForm {
        public frmVenda() {
            InitializeComponent();
        }

        private void frmVenda_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void frmVenda_Resize(object sender, EventArgs e) {
           metroPanel1.Location = new Point(23, this.Size.Height - 192);
           customGrid1.Size = new Size(820, this.Size.Height - 255);
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            customGrid1.Add();
            customGrid1.Line[customGrid1.Line.Count - 1].Add(customGrid1.Line.Count, customGrid1.Line.Count, "975542132", "TIC TAC SABOR MORANGO", 1, 12.50m);
        }
    }
}
