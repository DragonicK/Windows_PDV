namespace Windows_PDV.View {
    partial class frmFornecedor {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabcontrol = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btn_apagartudo = new MetroFramework.Controls.MetroButton();
            this.chk_ie = new MetroFramework.Controls.MetroCheckBox();
            this.chk_cnpj = new MetroFramework.Controls.MetroCheckBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.btn_limpar = new MetroFramework.Controls.MetroButton();
            this.btn_pesquisar = new MetroFramework.Controls.MetroButton();
            this.btn_deletar = new MetroFramework.Controls.MetroButton();
            this.btn_inserir = new MetroFramework.Controls.MetroButton();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.txt_ie = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.txt_cnpj = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.txt_telefone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.txt_cep = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txt_cidade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_bairro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txt_endereco = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_empresa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_codigo = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btn_atualizar = new MetroFramework.Controls.MetroButton();
            this.gridview = new MetroFramework.Controls.MetroGrid();
            this.cmb_estado = new MetroFramework.Controls.MetroComboBox();
            this.tabcontrol.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.metroTabPage1);
            this.tabcontrol.Controls.Add(this.metroTabPage2);
            this.tabcontrol.Location = new System.Drawing.Point(23, 63);
            this.tabcontrol.Margin = new System.Windows.Forms.Padding(0);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(812, 413);
            this.tabcontrol.TabIndex = 19;
            this.tabcontrol.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabcontrol.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroPanel2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(804, 371);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Inclusão e Modificação";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.cmb_estado);
            this.metroPanel2.Controls.Add(this.btn_apagartudo);
            this.metroPanel2.Controls.Add(this.chk_ie);
            this.metroPanel2.Controls.Add(this.chk_cnpj);
            this.metroPanel2.Controls.Add(this.metroDateTime1);
            this.metroPanel2.Controls.Add(this.btn_limpar);
            this.metroPanel2.Controls.Add(this.btn_pesquisar);
            this.metroPanel2.Controls.Add(this.btn_deletar);
            this.metroPanel2.Controls.Add(this.btn_inserir);
            this.metroPanel2.Controls.Add(this.metroLabel23);
            this.metroPanel2.Controls.Add(this.txt_email);
            this.metroPanel2.Controls.Add(this.metroLabel22);
            this.metroPanel2.Controls.Add(this.metroLabel21);
            this.metroPanel2.Controls.Add(this.txt_ie);
            this.metroPanel2.Controls.Add(this.metroLabel20);
            this.metroPanel2.Controls.Add(this.txt_cnpj);
            this.metroPanel2.Controls.Add(this.metroLabel19);
            this.metroPanel2.Controls.Add(this.txt_telefone);
            this.metroPanel2.Controls.Add(this.metroLabel18);
            this.metroPanel2.Controls.Add(this.txt_cep);
            this.metroPanel2.Controls.Add(this.metroLabel17);
            this.metroPanel2.Controls.Add(this.metroLabel14);
            this.metroPanel2.Controls.Add(this.txt_cidade);
            this.metroPanel2.Controls.Add(this.metroLabel9);
            this.metroPanel2.Controls.Add(this.txt_bairro);
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.Controls.Add(this.txt_endereco);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.txt_empresa);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.txt_codigo);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(794, 361);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btn_apagartudo
            // 
            this.btn_apagartudo.Location = new System.Drawing.Point(538, 33);
            this.btn_apagartudo.Name = "btn_apagartudo";
            this.btn_apagartudo.Size = new System.Drawing.Size(213, 23);
            this.btn_apagartudo.TabIndex = 32;
            this.btn_apagartudo.Text = "Apagar todos os fornecedores";
            this.btn_apagartudo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_apagartudo.UseSelectable = true;
            this.btn_apagartudo.Click += new System.EventHandler(this.btn_apagartudo_Click);
            // 
            // chk_ie
            // 
            this.chk_ie.AutoSize = true;
            this.chk_ie.Checked = true;
            this.chk_ie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ie.Location = new System.Drawing.Point(504, 101);
            this.chk_ie.Name = "chk_ie";
            this.chk_ie.Size = new System.Drawing.Size(156, 15);
            this.chk_ie.TabIndex = 14;
            this.chk_ie.Text = "Validar Inscrição Estadual";
            this.chk_ie.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chk_ie.UseSelectable = true;
            this.chk_ie.CheckedChanged += new System.EventHandler(this.chk_ie_CheckedChanged);
            // 
            // chk_cnpj
            // 
            this.chk_cnpj.AutoSize = true;
            this.chk_cnpj.Checked = true;
            this.chk_cnpj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_cnpj.Location = new System.Drawing.Point(504, 80);
            this.chk_cnpj.Name = "chk_cnpj";
            this.chk_cnpj.Size = new System.Drawing.Size(90, 15);
            this.chk_cnpj.TabIndex = 13;
            this.chk_cnpj.Text = "Validar CNPJ";
            this.chk_cnpj.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chk_cnpj.UseSelectable = true;
            this.chk_cnpj.CheckedChanged += new System.EventHandler(this.chk_cnpj_CheckedChanged);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(13, 321);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 11;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(457, 33);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 18;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_limpar.UseSelectable = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(376, 33);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisar.TabIndex = 17;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseSelectable = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Enabled = false;
            this.btn_deletar.Location = new System.Drawing.Point(295, 33);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_deletar.TabIndex = 16;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseSelectable = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(214, 33);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 15;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseSelectable = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(240, 299);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(41, 19);
            this.metroLabel23.TabIndex = 31;
            this.metroLabel23.Text = "Email";
            this.metroLabel23.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(250, 2);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(240, 321);
            this.txt_email.MaxLength = 120;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(270, 22);
            this.txt_email.TabIndex = 12;
            this.txt_email.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(13, 299);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(93, 19);
            this.metroLabel22.TabIndex = 29;
            this.metroLabel22.Text = "Data Cadastro";
            this.metroLabel22.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(265, 252);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(111, 19);
            this.metroLabel21.TabIndex = 27;
            this.metroLabel21.Text = "Inscrição Estadual";
            this.metroLabel21.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_ie
            // 
            // 
            // 
            // 
            this.txt_ie.CustomButton.Image = null;
            this.txt_ie.CustomButton.Location = new System.Drawing.Point(199, 2);
            this.txt_ie.CustomButton.Name = "";
            this.txt_ie.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_ie.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ie.CustomButton.TabIndex = 1;
            this.txt_ie.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ie.CustomButton.UseSelectable = true;
            this.txt_ie.CustomButton.Visible = false;
            this.txt_ie.Lines = new string[0];
            this.txt_ie.Location = new System.Drawing.Point(265, 274);
            this.txt_ie.MaxLength = 35;
            this.txt_ie.Name = "txt_ie";
            this.txt_ie.PasswordChar = '\0';
            this.txt_ie.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ie.SelectedText = "";
            this.txt_ie.SelectionLength = 0;
            this.txt_ie.SelectionStart = 0;
            this.txt_ie.ShortcutsEnabled = true;
            this.txt_ie.Size = new System.Drawing.Size(219, 22);
            this.txt_ie.TabIndex = 10;
            this.txt_ie.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ie.UseSelectable = true;
            this.txt_ie.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ie.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ie_KeyPress);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(13, 252);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(40, 19);
            this.metroLabel20.TabIndex = 25;
            this.metroLabel20.Text = "CNPJ";
            this.metroLabel20.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_cnpj
            // 
            // 
            // 
            // 
            this.txt_cnpj.CustomButton.Image = null;
            this.txt_cnpj.CustomButton.Location = new System.Drawing.Point(213, 2);
            this.txt_cnpj.CustomButton.Name = "";
            this.txt_cnpj.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_cnpj.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cnpj.CustomButton.TabIndex = 1;
            this.txt_cnpj.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cnpj.CustomButton.UseSelectable = true;
            this.txt_cnpj.CustomButton.Visible = false;
            this.txt_cnpj.Lines = new string[0];
            this.txt_cnpj.Location = new System.Drawing.Point(13, 274);
            this.txt_cnpj.MaxLength = 18;
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.PasswordChar = '\0';
            this.txt_cnpj.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cnpj.SelectedText = "";
            this.txt_cnpj.SelectionLength = 0;
            this.txt_cnpj.SelectionStart = 0;
            this.txt_cnpj.ShortcutsEnabled = true;
            this.txt_cnpj.Size = new System.Drawing.Size(233, 22);
            this.txt_cnpj.TabIndex = 9;
            this.txt_cnpj.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cnpj.UseSelectable = true;
            this.txt_cnpj.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cnpj.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(298, 203);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(57, 19);
            this.metroLabel19.TabIndex = 23;
            this.metroLabel19.Text = "Telefone";
            this.metroLabel19.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_telefone
            // 
            // 
            // 
            // 
            this.txt_telefone.CustomButton.Image = null;
            this.txt_telefone.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txt_telefone.CustomButton.Name = "";
            this.txt_telefone.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_telefone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_telefone.CustomButton.TabIndex = 1;
            this.txt_telefone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_telefone.CustomButton.UseSelectable = true;
            this.txt_telefone.CustomButton.Visible = false;
            this.txt_telefone.Lines = new string[0];
            this.txt_telefone.Location = new System.Drawing.Point(298, 225);
            this.txt_telefone.MaxLength = 25;
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.PasswordChar = '\0';
            this.txt_telefone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_telefone.SelectedText = "";
            this.txt_telefone.SelectionLength = 0;
            this.txt_telefone.SelectionStart = 0;
            this.txt_telefone.ShortcutsEnabled = true;
            this.txt_telefone.Size = new System.Drawing.Size(186, 22);
            this.txt_telefone.TabIndex = 8;
            this.txt_telefone.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_telefone.UseSelectable = true;
            this.txt_telefone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_telefone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(13, 203);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(33, 19);
            this.metroLabel18.TabIndex = 21;
            this.metroLabel18.Text = "CEP";
            this.metroLabel18.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_cep
            // 
            // 
            // 
            // 
            this.txt_cep.CustomButton.Image = null;
            this.txt_cep.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txt_cep.CustomButton.Name = "";
            this.txt_cep.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_cep.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cep.CustomButton.TabIndex = 1;
            this.txt_cep.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cep.CustomButton.UseSelectable = true;
            this.txt_cep.CustomButton.Visible = false;
            this.txt_cep.Lines = new string[0];
            this.txt_cep.Location = new System.Drawing.Point(13, 225);
            this.txt_cep.MaxLength = 25;
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.PasswordChar = '\0';
            this.txt_cep.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cep.SelectedText = "";
            this.txt_cep.SelectionLength = 0;
            this.txt_cep.SelectionStart = 0;
            this.txt_cep.ShortcutsEnabled = true;
            this.txt_cep.Size = new System.Drawing.Size(186, 22);
            this.txt_cep.TabIndex = 7;
            this.txt_cep.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cep.UseSelectable = true;
            this.txt_cep.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cep.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(295, 152);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(48, 19);
            this.metroLabel17.TabIndex = 19;
            this.metroLabel17.Text = "Estado";
            this.metroLabel17.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(13, 155);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(51, 19);
            this.metroLabel14.TabIndex = 17;
            this.metroLabel14.Text = "Cidade";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_cidade
            // 
            // 
            // 
            // 
            this.txt_cidade.CustomButton.Image = null;
            this.txt_cidade.CustomButton.Location = new System.Drawing.Point(271, 2);
            this.txt_cidade.CustomButton.Name = "";
            this.txt_cidade.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_cidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cidade.CustomButton.TabIndex = 1;
            this.txt_cidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cidade.CustomButton.UseSelectable = true;
            this.txt_cidade.CustomButton.Visible = false;
            this.txt_cidade.Lines = new string[0];
            this.txt_cidade.Location = new System.Drawing.Point(13, 177);
            this.txt_cidade.MaxLength = 30;
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.PasswordChar = '\0';
            this.txt_cidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cidade.SelectedText = "";
            this.txt_cidade.SelectionLength = 0;
            this.txt_cidade.SelectionStart = 0;
            this.txt_cidade.ShortcutsEnabled = true;
            this.txt_cidade.Size = new System.Drawing.Size(268, 22);
            this.txt_cidade.TabIndex = 5;
            this.txt_cidade.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cidade.UseSelectable = true;
            this.txt_cidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(326, 105);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(45, 19);
            this.metroLabel9.TabIndex = 15;
            this.metroLabel9.Text = "Bairro";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_bairro
            // 
            // 
            // 
            // 
            this.txt_bairro.CustomButton.Image = null;
            this.txt_bairro.CustomButton.Location = new System.Drawing.Point(138, 2);
            this.txt_bairro.CustomButton.Name = "";
            this.txt_bairro.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_bairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_bairro.CustomButton.TabIndex = 1;
            this.txt_bairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_bairro.CustomButton.UseSelectable = true;
            this.txt_bairro.CustomButton.Visible = false;
            this.txt_bairro.Lines = new string[0];
            this.txt_bairro.Location = new System.Drawing.Point(326, 127);
            this.txt_bairro.MaxLength = 40;
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.PasswordChar = '\0';
            this.txt_bairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_bairro.SelectedText = "";
            this.txt_bairro.SelectionLength = 0;
            this.txt_bairro.SelectionStart = 0;
            this.txt_bairro.ShortcutsEnabled = true;
            this.txt_bairro.Size = new System.Drawing.Size(158, 22);
            this.txt_bairro.TabIndex = 4;
            this.txt_bairro.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_bairro.UseSelectable = true;
            this.txt_bairro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_bairro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(13, 105);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(64, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Endereço";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_endereco
            // 
            // 
            // 
            // 
            this.txt_endereco.CustomButton.Image = null;
            this.txt_endereco.CustomButton.Location = new System.Drawing.Point(271, 2);
            this.txt_endereco.CustomButton.Name = "";
            this.txt_endereco.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_endereco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_endereco.CustomButton.TabIndex = 1;
            this.txt_endereco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_endereco.CustomButton.UseSelectable = true;
            this.txt_endereco.CustomButton.Visible = false;
            this.txt_endereco.Lines = new string[0];
            this.txt_endereco.Location = new System.Drawing.Point(13, 127);
            this.txt_endereco.MaxLength = 150;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.PasswordChar = '\0';
            this.txt_endereco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_endereco.SelectedText = "";
            this.txt_endereco.SelectionLength = 0;
            this.txt_endereco.SelectionStart = 0;
            this.txt_endereco.ShortcutsEnabled = true;
            this.txt_endereco.Size = new System.Drawing.Size(291, 22);
            this.txt_endereco.TabIndex = 3;
            this.txt_endereco.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_endereco.UseSelectable = true;
            this.txt_endereco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_endereco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(13, 58);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(60, 19);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "Empresa";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txt_empresa
            // 
            // 
            // 
            // 
            this.txt_empresa.CustomButton.Image = null;
            this.txt_empresa.CustomButton.Location = new System.Drawing.Point(451, 2);
            this.txt_empresa.CustomButton.Name = "";
            this.txt_empresa.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_empresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_empresa.CustomButton.TabIndex = 1;
            this.txt_empresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_empresa.CustomButton.UseSelectable = true;
            this.txt_empresa.CustomButton.Visible = false;
            this.txt_empresa.Lines = new string[0];
            this.txt_empresa.Location = new System.Drawing.Point(13, 80);
            this.txt_empresa.MaxLength = 200;
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.PasswordChar = '\0';
            this.txt_empresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_empresa.SelectedText = "";
            this.txt_empresa.SelectionLength = 0;
            this.txt_empresa.SelectionStart = 0;
            this.txt_empresa.ShortcutsEnabled = true;
            this.txt_empresa.Size = new System.Drawing.Size(471, 22);
            this.txt_empresa.TabIndex = 2;
            this.txt_empresa.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_empresa.UseSelectable = true;
            this.txt_empresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_empresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Código";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.txt_codigo.Location = new System.Drawing.Point(13, 33);
            this.txt_codigo.MaxLength = 80;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.PasswordChar = '\0';
            this.txt_codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_codigo.SelectedText = "";
            this.txt_codigo.SelectionLength = 0;
            this.txt_codigo.SelectionStart = 0;
            this.txt_codigo.ShortcutsEnabled = true;
            this.txt_codigo.Size = new System.Drawing.Size(186, 22);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.UseSelectable = true;
            this.txt_codigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_codigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_KeyDown);
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
            this.metroTabPage2.Size = new System.Drawing.Size(804, 371);
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
            this.btn_atualizar.TabIndex = 20;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseSelectable = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // gridview
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.AllowUserToDeleteRows = false;
            this.gridview.AllowUserToOrderColumns = true;
            this.gridview.AllowUserToResizeRows = false;
            this.gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridview.ColumnHeadersHeight = 35;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridview.EnableHeadersVisualStyles = false;
            this.gridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridview.HighLightPercentage = 0.9F;
            this.gridview.Location = new System.Drawing.Point(0, 0);
            this.gridview.Margin = new System.Windows.Forms.Padding(0);
            this.gridview.Name = "gridview";
            this.gridview.ReadOnly = true;
            this.gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridview.RowTemplate.Height = 35;
            this.gridview.RowTemplate.ReadOnly = true;
            this.gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview.Size = new System.Drawing.Size(800, 319);
            this.gridview.TabIndex = 21;
            this.gridview.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.ItemHeight = 23;
            this.cmb_estado.Items.AddRange(new object[] {
            "AC - Acre ",
            "AL - Alagoas",
            "AP - Amapá",
            "AM - Amazonas",
            "BA - Bahia",
            "CE - Ceará",
            "DF - Distrito Federal",
            "ES - Espírito Santo",
            "GO - Goiás",
            "MA - Maranhão",
            "MT - Mato Grosso",
            "MS - Mato Grosso do Sul",
            "MG - Minas Gerais",
            "PA - Pará",
            "PB - Paraíba",
            "PR - Paraná",
            "PE - Pernambuco",
            "PI - Piauí",
            "RJ - Rio de Janeiro",
            "RN - Rio Grande do Norte",
            "RS - Rio Grande do Sul",
            "RO - Rondônia",
            "RR - Roraima",
            "SC - Santa Catarina",
            "SP - São Paulo",
            "SE - Sergipe",
            "TO - Tocantins"});
            this.cmb_estado.Location = new System.Drawing.Point(295, 172);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(189, 29);
            this.cmb_estado.TabIndex = 33;
            this.cmb_estado.UseSelectable = true;
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 498);
            this.Controls.Add(this.tabcontrol);
            this.KeyPreview = true;
            this.Name = "frmFornecedor";
            this.Padding = new System.Windows.Forms.Padding(50, 60, 20, 20);
            this.Resizable = false;
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.Fornecedor_Load);
            this.Resize += new System.EventHandler(this.FornecedorForm_Resize);
            this.tabcontrol.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabcontrol;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btn_pesquisar;
        private MetroFramework.Controls.MetroButton btn_deletar;
        private MetroFramework.Controls.MetroButton btn_inserir;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroTextBox txt_ie;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox txt_cnpj;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroTextBox txt_telefone;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTextBox txt_cep;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txt_cidade;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_bairro;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txt_endereco;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txt_empresa;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_codigo;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroGrid gridview;
        private MetroFramework.Controls.MetroButton btn_limpar;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroCheckBox chk_ie;
        private MetroFramework.Controls.MetroCheckBox chk_cnpj;
        private MetroFramework.Controls.MetroButton btn_atualizar;
        private MetroFramework.Controls.MetroButton btn_apagartudo;
        private MetroFramework.Controls.MetroComboBox cmb_estado;
    }
}