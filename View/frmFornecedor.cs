using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Windows_PDV.Database;
using Windows_PDV.Controller;

namespace Windows_PDV.View {
    public partial class frmFornecedor : MetroForm {

        /// <summary>
        /// Quando o campo código é alterado, esse valor é usado como referência para ser alterado na tabela.
        /// </summary>
        private string codigo_velho = string.Empty;
        private bool verificar_cnpj = true;
        private bool verificar_ie = true;

        #region Formulario

        public frmFornecedor() {
            InitializeComponent();
        }

        /// <summary>
        /// Confira a posição de alguns controles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fornecedor_Load(object sender, EventArgs e) {         
            cmb_estado.SelectedIndex = 0;
            tabcontrol.Dock = DockStyle.Fill;
            gridview.Size = new Size(tabcontrol.Size.Width -2, tabcontrol.Size.Height - 96);
            btn_atualizar.Location = new Point((this.Size.Width / 2) - 100, tabcontrol.Height - 82);

            this.Text = "Fornecedor : " + DBFornecedor.QuantidadeFornecedor() + " Cadastrados";
        }

        /// <summary>
        /// Altera a posição dos controles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FornecedorForm_Resize(object sender, EventArgs e) {
            gridview.Size = new Size(tabcontrol.Size.Width - 2, tabcontrol.Size.Height - 96);
            btn_atualizar.Location = new Point((this.Size.Width / 2) - 100, tabcontrol.Size.Height - 82);
        }

        #endregion

        #region Botões
        /// <summary>
        /// Limpa todos os campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_limpar_Click(object sender, EventArgs e) {
            //retorn os botões para o padrão
            btn_deletar.Enabled = false;
            btn_inserir.Enabled = true;
            btn_pesquisar.Text = "Pesquisar";
            codigo_velho = string.Empty;

            LimparCampos();
        }

        /// <summary>
        /// Insere o novo fornecedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_inserir_Click(object sender, EventArgs e) {
            InserirFornecedor();
        }

        /// <summary>
        /// Atualiza o gridview com os fornecedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_atualizar_Click(object sender, EventArgs e) {
            CompletarGridFornecedores();

            gridview.Columns[0].HeaderText = "ID";
            gridview.Columns[0].Visible = false;
            gridview.Columns[1].HeaderText = "Código";
            gridview.Columns[2].HeaderText = "Empresa";
            gridview.Columns[3].HeaderText = "Endereço";
            gridview.Columns[4].HeaderText = "Bairro";
            gridview.Columns[5].HeaderText = "Cidade";
            gridview.Columns[6].HeaderText = "Estado";
            gridview.Columns[7].HeaderText = "CEP";
            gridview.Columns[8].HeaderText = "Telefone";
            gridview.Columns[9].HeaderText = "CPNJ";
            gridview.Columns[10].HeaderText = "Inscrição Estadual";
            gridview.Columns[11].HeaderText = "Data do Cadastro";
            gridview.Columns[12].HeaderText = "Email";
        }

        /// <summary>
        /// Botão Apagar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_deletar_Click(object sender, EventArgs e) {
            ApagarFornecedor();
        }

        /// <summary>
        /// Botão Pesquisar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_pesquisar_Click(object sender, EventArgs e) {
            //se o código estiver vazio, abre mensagem e sai do procedimento
            if (CodigoEstaVazio(true)) { return; }

            //executa a pesquisa quando o botão estiver no modo de pesquisa
            if (btn_pesquisar.Text == "Pesquisar") {

                if (!FornecedorExiste(true)) { return; }

                btn_inserir.Enabled = false;
                btn_deletar.Enabled = true;
                btn_pesquisar.Text = "Salvar";
                ExecutarPesquisa();
            }
            else {
                //verifica o CNPJ e a IE antes de atualizar os dados
                if (verificar_cnpj) { if (!ValidarCNPJ(true)) { return; } }
                if (verificar_ie) { if (!ValidarIE(true)) { return; } }

                btn_deletar.Enabled = false;
                btn_inserir.Enabled = true;
                btn_pesquisar.Text = "Pesquisar";

                var result = MetroMessageBox.Show(this, "Os dados do fornecedor será alterado. Deseja continuar?", "Mensagem", MessageBoxButtons.YesNo, 100);
                if (result == DialogResult.No) { return; }

                DBFornecedor.AtualizarFornecedor(CriarFornecedor(), codigo_velho);
                LimparCampos();
            }
        }

        /// <summary>
        /// Deleta todos os fornecedores.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_apagartudo_Click(object sender, EventArgs e) {
            var result = MostrarMensagem("Importante", "Essa ação é irreversível.\nDeseja apagar todos os fornecedores?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) { return; }
           
            var count = DBFornecedor.DeletarFornecedores();

            AtualizarQuantidadeFornecedor();
            MostrarMensagem("Importante", $"Foram deletados {count} fornecedores");
            LimparCampos();
        }
        #endregion

        #region CheckBox
        /// <summary>
        /// Altera os dados quando clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_ie_CheckedChanged(object sender, EventArgs e) {
            verificar_ie = chk_ie.Checked;
        }

        /// <summary>
        /// Altera os dados quando clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_cnpj_CheckedChanged(object sender, EventArgs e) {
            verificar_cnpj = chk_cnpj.Checked;
        }
        #endregion

        #region TextBox
        /// <summary>
        /// KeyDown - Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_codigo_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) return;

            //Verifica se o campo de código está vazio.
            if (CodigoEstaVazio(true)) { return; }
            //Verifica se o código de fornecedor existe.
            if (!FornecedorExiste(true)) { return; }

            if (btn_pesquisar.Text == "Pesquisar") {
                btn_inserir.Enabled = false;
                btn_deletar.Enabled = true;
                btn_pesquisar.Text = "Salvar";
            }

            ExecutarPesquisa();
        }

        /// <summary>
        /// Somente números no campo IE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_ie_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {
                e.Handled = true;
            }
        }

        #endregion

        /// <summary>
        /// Verifica o CNPJ.
        /// </summary>
        /// <param name="exibirMensagem"></param>
        /// <returns></returns>
        private bool ValidarCNPJ(bool exibirMensagem) {    
            if (!Validar.CNPJ(txt_cnpj.Text.Trim())) {
                if (exibirMensagem) { MostrarMensagem("Aviso", "O CNPJ inserido é inválido."); }
                return false;
            }

            return true;
        }
        
        /// <summary>
        /// Verifica a inscrição estadual.
        /// </summary>
        /// <param name="exibirMensagem"></param>
        /// <returns></returns>
        private bool ValidarIE(bool exibirMensagem) {
            if (!Validar.IE(((Estados)cmb_estado.SelectedIndex).ToString(), txt_ie.Text)) {
                if (exibirMensagem) { MostrarMensagem("Aviso", "A inscrição estadual inserido é inválido."); }
                return false;
            }

            return true;
        }

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
        /// Verifica se o codigo de fornecedor existe no banco.
        /// </summary>
        /// <param name="exibirMensagem"></param>
        /// <returns></returns>
        private bool FornecedorExiste(bool exibirMensagem) {
            if (!DBFornecedor.ExisteFornecedor(txt_codigo.Text.Trim())) {
                if (exibirMensagem) { MostrarMensagem("Aviso", "O código de fornecedor não foi encontrado."); }
                return false;
            }

            return true;
        }
        
        /// <summary>
        /// Insere um novo fornecedor no banco de dados.
        /// </summary>
        private void InserirFornecedor() {
            //se os campos não estiverem validados, retornar
            if (!ValidarCampos()) { return; }

            var codigo = txt_codigo.Text.Trim();

            //se o fornecedor for inserido, limpa os campos
            if (DBFornecedor.InserirFornecedor(CriarFornecedor())) {
                LimparCampos();
                AtualizarQuantidadeFornecedor();

            }
        }

        /// <summary>
        /// Realiza a pesquisa e carrega as informações do fornecedor.
        /// </summary>
        private void ExecutarPesquisa() {
            var fornecedor = DBFornecedor.CarregarFornecedor(txt_codigo.Text.Trim());

            codigo_velho = fornecedor.Codigo;
            txt_codigo.Text = fornecedor.Codigo;
            txt_empresa.Text = fornecedor.Empresa;
            txt_endereco.Text = fornecedor.Endereco;
            txt_bairro.Text = fornecedor.Bairro;
            txt_cidade.Text = fornecedor.Cidade;
            cmb_estado.SelectedIndex = (int)Enum.Parse(typeof(Estados), fornecedor.Estado);
            txt_cep.Text = fornecedor.CEP;
            txt_telefone.Text = fornecedor.Telefone;
            txt_cnpj.Text = fornecedor.CNPJ;
            txt_ie.Text = fornecedor.IE;
            metroDateTime1.Value = fornecedor.DataCadastro;
            txt_email.Text = fornecedor.Email;
        }

        /// <summary>
        /// Apaga o fornecedor do banco de dados.
        /// </summary>
        private void ApagarFornecedor() {
            //Verifica se o campo de código está vazio.
            if (CodigoEstaVazio(true)) { return; }
            //Verifica se o fornecedor existe no banco.
            if (!FornecedorExiste(true)) { return; }
                     
            var result = MostrarMensagem("Importante", $"Todos os produtos cadastrados com esse fornecedor será alterado para nenhum fornecedor.\nTem certeza de que deseja apagar o fornecedor {txt_codigo.Text.Trim()}?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) { return; }

            DBProduto.AtualizarFornecedor(DBFornecedor.FornecedorID(txt_codigo.Text.Trim()));
            DBFornecedor.DeletarFornecedor(txt_codigo.Text.Trim());
            LimparCampos();

            AtualizarQuantidadeFornecedor();
        }

        /// <summary>
        /// Atualiza e completa o gridview.
        /// </summary>
        private void CompletarGridFornecedores() {
            gridview.DataSource = DBFornecedor.CarregarFornecedores(true);
        }

        /// <summary>
        /// Verifica se os campos estão corretos para o novo fornecedor.
        /// </summary>
        /// <returns></returns>
        private bool ValidarCampos() {
            if (CodigoEstaVazio(true)) { return false; }

            if (FornecedorExiste(false)) {
                MostrarMensagem("Aviso", "O código já está sendo usado por outro fornecedor.");
                return false;
            }

            if (txt_empresa.Text.Trim().Length < 1) {
                MostrarMensagem("Aviso", "O nome da empresa não pode ficar em branco.");
                return false;
            }

            if (verificar_cnpj) {
                if (!ValidarCNPJ(true)) { return false; }
            }

            if (verificar_ie) {
                if (!ValidarIE(true)) { return false; }
            }
            
            return true;
        }

        /// <summary>
        /// Limpa todos os campos.
        /// </summary>
        private void LimparCampos() {
            txt_codigo.Enabled = true;
            txt_codigo.Text = string.Empty;
            txt_empresa.Text = string.Empty;
            txt_endereco.Text = string.Empty;
            txt_bairro.Text = string.Empty;
            txt_cidade.Text = string.Empty;
            cmb_estado.SelectedIndex = 0;
            txt_cep.Text = string.Empty;
            txt_telefone.Text = string.Empty;
            txt_cnpj.Text = string.Empty;
            txt_ie.Text = string.Empty;
            txt_email.Text = string.Empty;
        }

        /// <summary>
        /// Retorna fornecedor preenchido.
        /// </summary>
        /// <returns></returns>
        private Fornecedor CriarFornecedor() {
            var fornecedor = new Fornecedor();
            fornecedor.Codigo = txt_codigo.Text.Trim();
            fornecedor.Empresa = txt_empresa.Text.Trim();
            fornecedor.Endereco = txt_endereco.Text.Trim();
            fornecedor.Bairro = txt_bairro.Text.Trim();
            fornecedor.Cidade = txt_cidade.Text.Trim();
            fornecedor.Estado = ((Estados)cmb_estado.SelectedIndex).ToString();
            fornecedor.CEP = txt_cep.Text.Trim();
            fornecedor.Telefone = txt_telefone.Text.Trim();
            fornecedor.CNPJ = txt_cnpj.Text.Trim();
            fornecedor.IE = txt_ie.Text.Trim();
            fornecedor.DataCadastro = metroDateTime1.Value;
            fornecedor.Email = txt_email.Text.Trim();

            return fornecedor;
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
        /// Atualiza a quantidade de fornecedores.
        /// </summary>
        private void AtualizarQuantidadeFornecedor() {
            this.Text = "Fornecedor : " + DBFornecedor.QuantidadeFornecedor() + " Cadastrados";
            this.Refresh();
        }
    }
}

