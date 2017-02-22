namespace Windows_PDV.View {
    partial class frmProduto {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_apagartudo = new MetroFramework.Controls.MetroButton();
            this.btn_limpar = new MetroFramework.Controls.MetroButton();
            this.txt_estoqueatual = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txt_estoquemin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.txt_margemlucro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txt_precocusto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txt_precovenda = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.cmb_fornecedor = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_fabricante = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_descricao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_codigo = new MetroFramework.Controls.MetroTextBox();
            this.btn_pesquisar = new MetroFramework.Controls.MetroButton();
            this.btn_deletar = new MetroFramework.Controls.MetroButton();
            this.btn_inserir = new MetroFramework.Controls.MetroButton();
            this.tabcontrol = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btn_atualizar = new MetroFramework.Controls.MetroButton();
            this.gridview = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btn_apagartudo);
            this.metroPanel1.Controls.Add(this.btn_limpar);
            this.metroPanel1.Controls.Add(this.txt_estoqueatual);
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.txt_estoquemin);
            this.metroPanel1.Controls.Add(this.metroLabel16);
            this.metroPanel1.Controls.Add(this.txt_margemlucro);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.txt_precocusto);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.txt_precovenda);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.cmb_fornecedor);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txt_fabricante);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txt_descricao);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txt_codigo);
            this.metroPanel1.Controls.Add(this.btn_pesquisar);
            this.metroPanel1.Controls.Add(this.btn_deletar);
            this.metroPanel1.Controls.Add(this.btn_inserir);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 16);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(780, 341);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_apagartudo
            // 
            this.btn_apagartudo.Location = new System.Drawing.Point(547, 28);
            this.btn_apagartudo.Name = "btn_apagartudo";
            this.btn_apagartudo.Size = new System.Drawing.Size(213, 23);
            this.btn_apagartudo.TabIndex = 33;
            this.btn_apagartudo.Text = "Apagar todos os produtos";
            this.btn_apagartudo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_apagartudo.UseSelectable = true;
            this.btn_apagartudo.Click += new System.EventHandler(this.btn_apagartudo_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(469, 28);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 32;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseSelectable = true;
            this.btn_limpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txt_estoqueatual
            // 
            // 
            // 
            // 
            this.txt_estoqueatual.CustomButton.Image = null;
            this.txt_estoqueatual.CustomButton.Location = new System.Drawing.Point(93, 2);
            this.txt_estoqueatual.CustomButton.Name = "";
            this.txt_estoqueatual.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_estoqueatual.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_estoqueatual.CustomButton.TabIndex = 1;
            this.txt_estoqueatual.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_estoqueatual.CustomButton.UseSelectable = true;
            this.txt_estoqueatual.CustomButton.Visible = false;
            this.txt_estoqueatual.Lines = new string[] {
        "0"};
            this.txt_estoqueatual.Location = new System.Drawing.Point(286, 235);
            this.txt_estoqueatual.MaxLength = 32767;
            this.txt_estoqueatual.Name = "txt_estoqueatual";
            this.txt_estoqueatual.PasswordChar = '\0';
            this.txt_estoqueatual.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_estoqueatual.SelectedText = "";
            this.txt_estoqueatual.SelectionLength = 0;
            this.txt_estoqueatual.SelectionStart = 0;
            this.txt_estoqueatual.ShortcutsEnabled = true;
            this.txt_estoqueatual.Size = new System.Drawing.Size(113, 22);
            this.txt_estoqueatual.TabIndex = 28;
            this.txt_estoqueatual.Text = "0";
            this.txt_estoqueatual.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_estoqueatual.UseSelectable = true;
            this.txt_estoqueatual.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_estoqueatual.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(286, 260);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(126, 19);
            this.metroLabel15.TabIndex = 31;
            this.metroLabel15.Text = "Quantidade Mínima";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_estoquemin
            // 
            // 
            // 
            // 
            this.txt_estoquemin.CustomButton.Image = null;
            this.txt_estoquemin.CustomButton.Location = new System.Drawing.Point(93, 2);
            this.txt_estoquemin.CustomButton.Name = "";
            this.txt_estoquemin.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_estoquemin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_estoquemin.CustomButton.TabIndex = 1;
            this.txt_estoquemin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_estoquemin.CustomButton.UseSelectable = true;
            this.txt_estoquemin.CustomButton.Visible = false;
            this.txt_estoquemin.Lines = new string[] {
        "0"};
            this.txt_estoquemin.Location = new System.Drawing.Point(286, 282);
            this.txt_estoquemin.MaxLength = 32767;
            this.txt_estoquemin.Name = "txt_estoquemin";
            this.txt_estoquemin.PasswordChar = '\0';
            this.txt_estoquemin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_estoquemin.SelectedText = "";
            this.txt_estoquemin.SelectionLength = 0;
            this.txt_estoquemin.SelectionStart = 0;
            this.txt_estoquemin.ShortcutsEnabled = true;
            this.txt_estoquemin.Size = new System.Drawing.Size(113, 22);
            this.txt_estoquemin.TabIndex = 30;
            this.txt_estoquemin.Text = "0";
            this.txt_estoquemin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_estoquemin.UseSelectable = true;
            this.txt_estoquemin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_estoquemin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(286, 213);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(151, 19);
            this.metroLabel16.TabIndex = 29;
            this.metroLabel16.Text = "Quantidade em Estoque";
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_margemlucro
            // 
            // 
            // 
            // 
            this.txt_margemlucro.CustomButton.Image = null;
            this.txt_margemlucro.CustomButton.Location = new System.Drawing.Point(98, 2);
            this.txt_margemlucro.CustomButton.Name = "";
            this.txt_margemlucro.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_margemlucro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_margemlucro.CustomButton.TabIndex = 1;
            this.txt_margemlucro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_margemlucro.CustomButton.UseSelectable = true;
            this.txt_margemlucro.CustomButton.Visible = false;
            this.txt_margemlucro.Lines = new string[] {
        "% 0"};
            this.txt_margemlucro.Location = new System.Drawing.Point(152, 235);
            this.txt_margemlucro.MaxLength = 32767;
            this.txt_margemlucro.Name = "txt_margemlucro";
            this.txt_margemlucro.PasswordChar = '\0';
            this.txt_margemlucro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_margemlucro.SelectedText = "";
            this.txt_margemlucro.SelectionLength = 0;
            this.txt_margemlucro.SelectionStart = 0;
            this.txt_margemlucro.ShortcutsEnabled = true;
            this.txt_margemlucro.Size = new System.Drawing.Size(118, 22);
            this.txt_margemlucro.TabIndex = 26;
            this.txt_margemlucro.Text = "% 0";
            this.txt_margemlucro.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_margemlucro.UseSelectable = true;
            this.txt_margemlucro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_margemlucro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_margemlucro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMargemLucro_KeyDown);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(152, 213);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(115, 19);
            this.metroLabel13.TabIndex = 27;
            this.metroLabel13.Text = "Margem de Lucro";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_precocusto
            // 
            // 
            // 
            // 
            this.txt_precocusto.CustomButton.Image = null;
            this.txt_precocusto.CustomButton.Location = new System.Drawing.Point(93, 2);
            this.txt_precocusto.CustomButton.Name = "";
            this.txt_precocusto.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_precocusto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_precocusto.CustomButton.TabIndex = 1;
            this.txt_precocusto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_precocusto.CustomButton.UseSelectable = true;
            this.txt_precocusto.CustomButton.Visible = false;
            this.txt_precocusto.Lines = new string[] {
        "R$ 0.00"};
            this.txt_precocusto.Location = new System.Drawing.Point(20, 235);
            this.txt_precocusto.MaxLength = 32767;
            this.txt_precocusto.Name = "txt_precocusto";
            this.txt_precocusto.PasswordChar = '\0';
            this.txt_precocusto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_precocusto.SelectedText = "";
            this.txt_precocusto.SelectionLength = 0;
            this.txt_precocusto.SelectionStart = 0;
            this.txt_precocusto.ShortcutsEnabled = true;
            this.txt_precocusto.Size = new System.Drawing.Size(113, 22);
            this.txt_precocusto.TabIndex = 20;
            this.txt_precocusto.Text = "R$ 0.00";
            this.txt_precocusto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_precocusto.UseSelectable = true;
            this.txt_precocusto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_precocusto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_precocusto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecoCusto_KeyDown);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(20, 271);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(102, 19);
            this.metroLabel11.TabIndex = 25;
            this.metroLabel11.Text = "Preço de Venda";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_precovenda
            // 
            // 
            // 
            // 
            this.txt_precovenda.CustomButton.Image = null;
            this.txt_precovenda.CustomButton.Location = new System.Drawing.Point(93, 2);
            this.txt_precovenda.CustomButton.Name = "";
            this.txt_precovenda.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_precovenda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_precovenda.CustomButton.TabIndex = 1;
            this.txt_precovenda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_precovenda.CustomButton.UseSelectable = true;
            this.txt_precovenda.CustomButton.Visible = false;
            this.txt_precovenda.Lines = new string[] {
        "R$ 0.00"};
            this.txt_precovenda.Location = new System.Drawing.Point(20, 293);
            this.txt_precovenda.MaxLength = 32767;
            this.txt_precovenda.Name = "txt_precovenda";
            this.txt_precovenda.PasswordChar = '\0';
            this.txt_precovenda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_precovenda.SelectedText = "";
            this.txt_precovenda.SelectionLength = 0;
            this.txt_precovenda.SelectionStart = 0;
            this.txt_precovenda.ShortcutsEnabled = true;
            this.txt_precovenda.Size = new System.Drawing.Size(113, 22);
            this.txt_precovenda.TabIndex = 24;
            this.txt_precovenda.Text = "R$ 0.00";
            this.txt_precovenda.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_precovenda.UseSelectable = true;
            this.txt_precovenda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_precovenda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_precovenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecoVenda_KeyDown);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(20, 213);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(99, 19);
            this.metroLabel10.TabIndex = 21;
            this.metroLabel10.Text = "Preço de Custo";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cmb_fornecedor
            // 
            this.cmb_fornecedor.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmb_fornecedor.FormattingEnabled = true;
            this.cmb_fornecedor.ItemHeight = 19;
            this.cmb_fornecedor.Location = new System.Drawing.Point(20, 121);
            this.cmb_fornecedor.Name = "cmb_fornecedor";
            this.cmb_fornecedor.Size = new System.Drawing.Size(441, 25);
            this.cmb_fornecedor.TabIndex = 18;
            this.cmb_fornecedor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmb_fornecedor.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 149);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Fabricante";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_fabricante
            // 
            // 
            // 
            // 
            this.txt_fabricante.CustomButton.Image = null;
            this.txt_fabricante.CustomButton.Location = new System.Drawing.Point(421, 2);
            this.txt_fabricante.CustomButton.Name = "";
            this.txt_fabricante.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_fabricante.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_fabricante.CustomButton.TabIndex = 1;
            this.txt_fabricante.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_fabricante.CustomButton.UseSelectable = true;
            this.txt_fabricante.CustomButton.Visible = false;
            this.txt_fabricante.Lines = new string[0];
            this.txt_fabricante.Location = new System.Drawing.Point(20, 171);
            this.txt_fabricante.MaxLength = 32767;
            this.txt_fabricante.Name = "txt_fabricante";
            this.txt_fabricante.PasswordChar = '\0';
            this.txt_fabricante.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_fabricante.SelectedText = "";
            this.txt_fabricante.SelectionLength = 0;
            this.txt_fabricante.SelectionStart = 0;
            this.txt_fabricante.ShortcutsEnabled = true;
            this.txt_fabricante.Size = new System.Drawing.Size(441, 22);
            this.txt_fabricante.TabIndex = 14;
            this.txt_fabricante.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_fabricante.UseSelectable = true;
            this.txt_fabricante.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_fabricante.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(20, 102);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Fornecedor";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 54);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Descrição";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_descricao
            // 
            // 
            // 
            // 
            this.txt_descricao.CustomButton.Image = null;
            this.txt_descricao.CustomButton.Location = new System.Drawing.Point(421, 2);
            this.txt_descricao.CustomButton.Name = "";
            this.txt_descricao.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_descricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_descricao.CustomButton.TabIndex = 1;
            this.txt_descricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_descricao.CustomButton.UseSelectable = true;
            this.txt_descricao.CustomButton.Visible = false;
            this.txt_descricao.Lines = new string[0];
            this.txt_descricao.Location = new System.Drawing.Point(20, 77);
            this.txt_descricao.MaxLength = 32767;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.PasswordChar = '\0';
            this.txt_descricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_descricao.SelectedText = "";
            this.txt_descricao.SelectionLength = 0;
            this.txt_descricao.SelectionStart = 0;
            this.txt_descricao.ShortcutsEnabled = true;
            this.txt_descricao.Size = new System.Drawing.Size(441, 22);
            this.txt_descricao.TabIndex = 8;
            this.txt_descricao.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_descricao.UseSelectable = true;
            this.txt_descricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_descricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 7);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Código";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_codigo
            // 
            // 
            // 
            // 
            this.txt_codigo.CustomButton.Image = null;
            this.txt_codigo.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txt_codigo.CustomButton.Name = "";
            this.txt_codigo.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_codigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_codigo.CustomButton.TabIndex = 1;
            this.txt_codigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_codigo.CustomButton.UseSelectable = true;
            this.txt_codigo.CustomButton.Visible = false;
            this.txt_codigo.Lines = new string[0];
            this.txt_codigo.Location = new System.Drawing.Point(20, 29);
            this.txt_codigo.MaxLength = 32767;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.PasswordChar = '\0';
            this.txt_codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_codigo.SelectedText = "";
            this.txt_codigo.SelectionLength = 0;
            this.txt_codigo.SelectionStart = 0;
            this.txt_codigo.ShortcutsEnabled = true;
            this.txt_codigo.Size = new System.Drawing.Size(186, 22);
            this.txt_codigo.TabIndex = 6;
            this.txt_codigo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_codigo.UseSelectable = true;
            this.txt_codigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_codigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(388, 28);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisar.TabIndex = 4;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseSelectable = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Enabled = false;
            this.btn_deletar.Location = new System.Drawing.Point(307, 28);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_deletar.TabIndex = 3;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseSelectable = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(226, 28);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 2;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseSelectable = true;
            this.btn_inserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.metroTabPage1);
            this.tabcontrol.Controls.Add(this.metroTabPage2);
            this.tabcontrol.Location = new System.Drawing.Point(23, 63);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(803, 417);
            this.tabcontrol.TabIndex = 8;
            this.tabcontrol.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabcontrol.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(795, 375);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Inclusão e Modificação";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btn_atualizar);
            this.metroTabPage2.Controls.Add(this.gridview);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(795, 375);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Listagem";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(352, 330);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(100, 25);
            this.btn_atualizar.TabIndex = 7;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseSelectable = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // gridview
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.AllowUserToDeleteRows = false;
            this.gridview.AllowUserToResizeRows = false;
            this.gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview.ColumnHeadersHeight = 25;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridview.EnableHeadersVisualStyles = false;
            this.gridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridview.HighLightPercentage = 0.9F;
            this.gridview.Location = new System.Drawing.Point(0, 0);
            this.gridview.Margin = new System.Windows.Forms.Padding(0);
            this.gridview.Name = "gridview";
            this.gridview.ReadOnly = true;
            this.gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridview.RowTemplate.Height = 25;
            this.gridview.RowTemplate.ReadOnly = true;
            this.gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview.Size = new System.Drawing.Size(795, 313);
            this.gridview.TabIndex = 5;
            this.gridview.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 498);
            this.Controls.Add(this.tabcontrol);
            this.KeyPreview = true;
            this.Name = "frmProduto";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.ProdutoForm_Load);
            this.Resize += new System.EventHandler(this.ProdutoForm_Resize);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.tabcontrol.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txt_estoqueatual;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txt_estoquemin;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox txt_margemlucro;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txt_precocusto;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txt_precovenda;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox cmb_fornecedor;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_fabricante;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_descricao;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_codigo;
        private MetroFramework.Controls.MetroButton btn_pesquisar;
        private MetroFramework.Controls.MetroButton btn_deletar;
        private MetroFramework.Controls.MetroButton btn_inserir;
        private MetroFramework.Controls.MetroTabControl tabcontrol;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton btn_limpar;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton btn_atualizar;
        private MetroFramework.Controls.MetroGrid gridview;
        private MetroFramework.Controls.MetroButton btn_apagartudo;
    }
}