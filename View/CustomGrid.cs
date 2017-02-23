using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Windows_PDV.View {
    public partial class CustomGrid : MetroUserControl {
        public Point base_position = new Point(0, 0);
        public List<CustomRow> Line = new List<CustomRow>();

        public CustomGrid() {
            InitializeComponent();
        }

        /// <summary>
        /// Adiciona uma nova linha
        /// </summary>
        public void Add() {
            var count = Line.Count;
            //cria o controle
            Line.Add(new CustomRow(0, count * 22));
            //adiciona o controle
            metroPanel1.Controls.Add(Line[count]);
            //adiciona o evento
            Line[count].ControlClick += GridRowClick;

            metroPanel1.Size = new Size(770, (count * 22));

            scrollbar.Maximum = metroPanel1.Size.Height;
        }

        private void CustomGrid_Resize(object sender, EventArgs e) {
            scrollbar.Size = new Size(22, this.Size.Height - 53);
        }

        /// <summary>
        /// Quando o scroll é movido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scrollbar_Scroll(object sender, ScrollEventArgs e) {
            metroPanel1.Location = new Point(5, -scrollbar.Value + (48));
        }


        private void GridRowClick(object sender, EventArgs e) {
            var linha = (CustomRow)sender;

            linha.AplicarBorda();

            for (var index = 0; index < Line.Count; index++)
                if (linha.CompraID != Line[index].CompraID) { Line[index].RetirarBorda(); }
        }
    }
}
