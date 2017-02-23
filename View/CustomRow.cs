using System;
using MetroFramework.Controls;
using System.Drawing;

namespace Windows_PDV.View {
    public partial class CustomRow : MetroUserControl {
        int _compraID, _quantidade;
        string _codigo, _descricao;
        decimal _preco;

        public event EventHandler ControlClick;
        /// <summary>
        /// Indice do controle.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// ID do produto.
        /// </summary>
        public int ProdutoID { get; set; }

        /// <summary>
        /// ID da compra.
        /// </summary>
        public int CompraID {
            get { return _compraID; }
            set {
                _compraID = value;
                lbl_id.Text = _compraID.ToString();
            }
        }

        /// <summary>
        /// Código do produto.
        /// </summary>
        public string Codigo {
            get { return _codigo; }
            set {
                _codigo = value;
                lbl_codigo.Text = _codigo;
            }
        }

        /// <summary>
        /// Descrição do produto.
        /// </summary>
        public string Descricao {
            get { return _descricao; }
            set {
                _descricao = value;
                lbl_descricao.Text = _descricao;
            }
        }
        
        /// <summary>
        /// Unidades
        /// </summary>
        public int Quantidade {
            get { return _quantidade; }
            set {
                _quantidade = value;
                lbl_quantidade.Text = _quantidade + " UN";
            }
        }

        /// <summary>
        /// Preço.
        /// </summary>
        public decimal Preco {
            get { return _preco; }
            set {
                _preco = value;
                lbl_preco.Text = "R$ " + _preco.ToString();
            }
        }
       
        /// <summary>
        /// Indica se o controle está selecionado ou não.
        /// </summary>
        public bool Selected { get; set; }

        public CustomRow() {
            InitializeComponent();
        }

        public CustomRow(int x, int y) {
            InitializeComponent();
            Location = new Point(x, y);
        }

        /// <summary>
        /// Adiciona as informações do produto.
        /// </summary>
        /// <param name="produtoID"></param>
        /// <param name="id"></param>
        /// <param name="codigo"></param>
        /// <param name="descricao"></param>
        /// <param name="quantidade"></param>
        /// <param name="preco"></param>
        public void Add(int produtoID, int compraID, string codigo, string descricao, int quantidade, decimal preco) {
            ProdutoID = produtoID;
            CompraID = compraID;
            Codigo = codigo;
            Descricao = descricao;
            Quantidade = quantidade;
            Preco = preco;
        }

        /// <summary>
        /// Quando ocorrer um clique no objeto, mudar a borda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Select(object sender, System.EventArgs e) {
            ControlClick?.Invoke(this, EventArgs.Empty);
        }

        public void AplicarBorda() {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Refresh();
        }

        public void RetirarBorda() {
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Refresh();
        }
    }
}
