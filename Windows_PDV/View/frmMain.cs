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
using Windows_PDV.Database;

namespace Windows_PDV.View {
    public partial class frmMain : MetroForm {
        public frmMain() {
            InitializeComponent();
        }

        /// <summary>
        /// Inicialização
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e) {
            //Inicia o formulario para validar o usuário
            frmLogin login = new frmLogin();
            login.ShowDialog();      

           // lblFornecedor.Text = "Fornecedores Cadastrados: " + DBFornecedor.QuantidadeFornecedor();
        }


        /// <summary>
        /// Botão de fornecedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tile_fornecedor_Click(object sender, EventArgs e) {
            frmFornecedor fornecedor = new frmFornecedor();
            fornecedor.Show();
        }

        private void tile_produto_Click(object sender, EventArgs e) {
            frmProduto produto = new frmProduto();
            produto.Show();
        }
    }
}
