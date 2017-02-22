using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Windows_PDV.Controller;
using Windows_PDV.Database;

namespace Windows_PDV.View {
    public partial class frmProduto : MetroForm {
        /// <summary>
        /// Quando o campo código é alterado, esse valor é usado como referência para ser alterado na tabela.
        /// </summary>
        string codigo_velho;

        /// <summary>
        /// Lista de fornecedores.
        /// </summary>
        List<Fornecedor> Fornecedor;

        /// <summary>
        /// Encontra o fornecedor na lista e retorna o indice.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private int EncontrarIndex(int id) {
            for(var index = 0; index < Fornecedor.Count; index++) {
                if (Fornecedor[index].ID == id) { return index; }
            }

            return 0;
        }

        #region Formulário

        public frmProduto() {
            InitializeComponent();
        }

        /// <summary>
        /// Configura a posição dos controles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProdutoForm_Load(object sender, EventArgs e) {
            tabcontrol.Dock = DockStyle.Fill;
            gridview.Size = new Size(tabcontrol.Size.Width - 2, tabcontrol.Size.Height - 96);
            btn_atualizar.Location = new Point((this.Size.Width / 2) - 72, tabcontrol.Height - 82);

            this.Text = "Produto : " + DBProduto.QuantidadeProduto() + " Cadastrados";

            //Carrega os fornecedores e apresenta no combobox
            Fornecedor = DBFornecedor.CarregarFornecedores(false);

            for (var index = 0; index < Fornecedor.Count; index++) {
                cmb_fornecedor.Items.Add(Fornecedor[index].Empresa);
            }

            cmb_fornecedor.SelectedIndex = 0;
        }
        
        /// <summary>
        /// Define a posição dos controles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProdutoForm_Resize(object sender, EventArgs e) {
            gridview.Size = new Size(tabcontrol.Size.Width - 2, tabcontrol.Size.Height - 96);
            btn_atualizar.Location = new Point((this.Size.Width / 2) - 72, tabcontrol.Height - 82);
        }

        #endregion

        #region Botões
        /// <summary>
        /// Limpa todos os campos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpar_Click(object sender, EventArgs e) {
            btn_deletar.Enabled = false;
            btn_inserir.Enabled = true;
            btn_pesquisar.Text = "Pesquisar";
            codigo_velho = string.Empty;

            LimparCampos();
        }

        /// <summary>
        /// Insere o produto no banco.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInserir_Click(object sender, EventArgs e) {
            //se os campos não estiverem validados, retornar
            if (!ValidarCampos()) { return; }

            var codigo = txt_codigo.Text.Trim();

            //se o fornecedor for inserido, limpa os campos
            if (DBProduto.InserirProduto(CriarProduto())) {
                LimparCampos();
                AtualizarQuantidadeProduto();
            } else {
                MostrarMensagem("Aviso", "Ocorreu um erro ao gravar o produto.");
            }
        }

        /// <summary>
        /// Realiza uma pesquisa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_pesquisar_Click(object sender, EventArgs e) {
            //Verifica se o campo de código está vazio.
            if (CodigoEstaVazio(true)) { return; }

            if (btn_pesquisar.Text == "Pesquisar") {
                if (ProdutoExiste(true)) { return; }

                btn_inserir.Enabled = false;
                btn_deletar.Enabled = true;
                btn_pesquisar.Text = "Salvar";
                ExecutarPesquisa();
            }
            else {
                btn_deletar.Enabled = false;
                btn_inserir.Enabled = true;
                btn_pesquisar.Text = "Pesquisar";

                var result = MostrarMensagem("Aviso", "O produto será alterado. Deseja continuar?", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) { return; }

                DBProduto.AtualizarProduto(CriarProduto(), codigo_velho);
                LimparCampos();
            }

        }

        /// <summary>
        /// Deleta o produto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_deletar_Click(object sender, EventArgs e) {
            ApagarProduto();
        }

        /// <summary>
        /// Atualiza o grid com as informações.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_atualizar_Click(object sender, EventArgs e) {
            CompletarGridProdutos();

            gridview.Columns[0].Visible = false; //id 
            gridview.Columns[1].HeaderText = "Código";
            gridview.Columns[2].HeaderText = "Descrição";
            gridview.Columns[3].Visible = false; //fornecedor id
            gridview.Columns[4].HeaderText = "Fornecedor";
            gridview.Columns[5].HeaderText = "Fabricante";
            gridview.Columns[6].HeaderText = "Preço de Custo";
            gridview.Columns[7].HeaderText = "Preço de Venda";
            gridview.Columns[8].HeaderText = "Margem de Lucro";
            gridview.Columns[9].HeaderText = "Estoque";
            gridview.Columns[10].HeaderText = "Estoque Mínimo";
        }

        /// <summary>
        /// Deleta todos os produtos do banco de dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_apagartudo_Click(object sender, EventArgs e) {
            var result = MostrarMensagem("Importante", "Essa ação é irreversível.\nDeseja apagar todos os produtos?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) { return; }

            var count = DBProduto.DeletarProdutos();

            AtualizarQuantidadeProduto();
            MostrarMensagem("Importante", $"Foram deletados {count} produtos");
            LimparCampos(); 
        }

        #endregion

        #region TextBox
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) return;

            if (CodigoEstaVazio(true)) { return; }
            if (!ProdutoExiste(true)) { return; }

            if (btn_pesquisar.Text == "Pesquisar") {
                btn_inserir.Enabled = false;
                btn_deletar.Enabled = true;
                btn_pesquisar.Text = "Salvar";
            }

            ExecutarPesquisa();
        }

        private void txtPrecoCusto_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) return;

            txt_precocusto.Text = txt_precocusto.Text.Replace(',', '.');

            var text = txt_precocusto.Text.Replace("R$", "").Trim();

            txt_precocusto.Text = "R$ " + text;

        }

        private void txtPrecoVenda_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) return;

            txt_precovenda.Text = txt_precovenda.Text.Replace(',', '.');
        
            var text = txt_precovenda.Text.Replace("R$", "").Trim();

            txt_precovenda.Text = "R$ " + text;
        }

        private void txtMargemLucro_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) return;

            var text = string.Empty;
            text = txt_margemlucro.Text.Replace("%", "");

            txt_margemlucro.Text = "% " + text;
        }
        #endregion

        /// <summary>
        /// Verifica se o campo código está vazio.
        /// </summary>
        /// <returns></returns>
        private bool CodigoEstaVazio(bool exibirMensagem) {
            if (txt_codigo.Text.Trim().Length < 1) {
                if (exibirMensagem) { MostrarMensagem("Aviso", "O campo código não pode estar vazio"); }
                return true;
            }

            return false;
        }

        /// <summary>
        /// Verifica se o codigo de produto existe no banco.
        /// </summary>
        /// <param name="exibirMensagem"></param>
        /// <returns></returns>
        private bool ProdutoExiste(bool exibirMensagem) {
            if (!DBProduto.ExisteProduto(txt_codigo.Text.Trim())) {
                if (exibirMensagem) { MostrarMensagem("Aviso", "O código de produto não foi encontrado."); }
                return false;
            }

            return true;
        }

        /// <summary>
        /// Insere um novo produto no banco de dados.
        /// </summary>
        private void InserirProduto() {
            //se os campos não estiverem validados, retornar
            if (!ValidarCampos()) { return; }

            var codigo = txt_codigo.Text.Trim();

            //se nenhum código existir, inserir um novo
            if (!DBProduto.ExisteProduto(codigo)) {

                //se o fornecedor for inserido, limpa os campos
                if (DBProduto.InserirProduto(CriarProduto())) {
                    LimparCampos();
                    AtualizarQuantidadeProduto();
                }

                return;
            }

            var result = MostrarMensagem("Aviso", "O código já pertence à um fornecedor, deseja atualizar?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) { return; }
        }

        /// <summary>
        /// Realiza a pesquisa e carrega as informações do fornecedor
        /// </summary>
        private void ExecutarPesquisa() {
            var produto = DBProduto.CarregarProduto(txt_codigo.Text.Trim());

            codigo_velho = produto.Codigo;
            txt_codigo.Text = produto.Codigo;
            txt_descricao.Text = produto.Descricao;
            cmb_fornecedor.SelectedIndex = EncontrarIndex(produto.FornecedorID);
            txt_fabricante.Text = produto.Fabricante;
            txt_precocusto.Text = "R$ " + produto.PrecoCusto.ToString();
            txt_precovenda.Text = "R$ " + produto.PrecoVenda.ToString();
            txt_margemlucro.Text = "% " + produto.MargemLucro.ToString();
            txt_estoqueatual.Text = produto.Estoque.ToString();
            txt_estoquemin.Text = produto.EstoqueMinimo.ToString();
        }

        /// <summary>
        /// Apaga o fornecedor do banco de dados
        /// </summary>
        private void ApagarProduto() {
            //Verifica se o campo de código está vazio.
            if (CodigoEstaVazio(true)) { return; }
            if (!ProdutoExiste(true)) { return; }

            var result = MostrarMensagem("Aviso", $"Deseja apagar o produto {txt_codigo.Text.Trim()}?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) { return; }

            DBProduto.DeletarProduto(txt_codigo.Text.Trim());
            LimparCampos();
            AtualizarQuantidadeProduto();
        }

        /// <summary>
        /// Atualiza e completa o gridview.
        /// </summary>
        private void CompletarGridProdutos() {
            gridview.DataSource = DBProduto.CarregarProdutos();
        }

        /// <summary>
        /// Verifica se os campos estão corretos para o novo produto.
        /// </summary>
        /// <returns></returns>
        private bool ValidarCampos() {
            //Verifica se o campo de código está vazio.
            if (CodigoEstaVazio(true)) { return false; }

            if (ProdutoExiste(false)) {
                MostrarMensagem("Aviso", "Esse código já está sendo usado por outro produto.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Limpa todos os campos do formulario
        /// </summary>
        private void LimparCampos() {
            txt_codigo.Text = string.Empty;
            txt_descricao.Text = string.Empty;
            cmb_fornecedor.SelectedIndex = 0;
            txt_fabricante.Text = string.Empty;
            txt_precocusto.Text = "R$ 0,00";
            txt_precovenda.Text = "R$ 0,00";
            txt_margemlucro.Text = "% 0";
            txt_estoqueatual.Text = "0";
            txt_estoquemin.Text = "0";
        }

        /// <summary>
        /// Retorna fornecedor preenchido
        /// </summary>
        /// <returns></returns>
        private Produto CriarProduto() {
            var produto = new Produto();
            produto.Codigo = txt_codigo.Text.Trim();
            produto.Descricao = txt_descricao.Text.Trim();
            produto.FornecedorID = Fornecedor[cmb_fornecedor.SelectedIndex].ID;   
            produto.Fabricante = txt_fabricante.Text.Trim();

            txt_precocusto.Text = txt_precocusto.Text.Replace(',', '.');
            txt_precovenda.Text = txt_precovenda.Text.Replace(',', '.');
 
            produto.PrecoCusto = decimal.Parse(txt_precocusto.Text.Replace("R$", "").Trim(), System.Globalization.CultureInfo.InvariantCulture);
            produto.PrecoVenda = decimal.Parse(txt_precovenda.Text.Replace("R$", "").Trim(), System.Globalization.CultureInfo.InvariantCulture);
            produto.MargemLucro = Convert.ToInt32(txt_margemlucro.Text.Replace("%", "").Trim());
            produto.Estoque = Convert.ToInt32(txt_estoqueatual.Text.Trim());
            produto.EstoqueMinimo = Convert.ToInt32(txt_estoquemin.Text.Trim());

            return produto;
        }

        /// <summary>
        /// Exibe a caixa de mensagem.
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="texto"></param>
        private void MostrarMensagem(string titulo, string texto) {
            MetroMessageBox.Show(this, texto, titulo, 110);
        }

        /// <summary>
        /// Exibe a caixa de mensagem com botões.
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="texto"></param>
        /// <param name="botao"></param>
        private DialogResult MostrarMensagem(string titulo, string texto, MessageBoxButtons botao) {
            return MetroMessageBox.Show(this, texto, titulo, botao, 110);
        }

        /// <summary>
        /// Atualiza a quantidade de produtos.
        /// </summary>
        private void AtualizarQuantidadeProduto() {
            this.Text = "Produto : " + DBProduto.QuantidadeProduto() + " Cadastrados";
            this.Refresh();
        }
    }
}

