namespace Windows_PDV.View {
    partial class UserForm {
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_new = new MetroFramework.Controls.MetroTabPage();
            this.button_insert = new MetroFramework.Controls.MetroButton();
            this.radio_access3 = new MetroFramework.Controls.MetroRadioButton();
            this.radio_access2 = new MetroFramework.Controls.MetroRadioButton();
            this.radio_access1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.text_newconfirm = new MetroFramework.Controls.MetroTextBox();
            this.text_newpass = new MetroFramework.Controls.MetroTextBox();
            this.text_newuser = new MetroFramework.Controls.MetroTextBox();
            this.tab_edit = new MetroFramework.Controls.MetroTabPage();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton5 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton6 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.tab_delete = new MetroFramework.Controls.MetroTabPage();
            this.label_deletename = new MetroFramework.Controls.MetroLabel();
            this.label_deleteuser = new MetroFramework.Controls.MetroLabel();
            this.button_deleterefresh = new MetroFramework.Controls.MetroButton();
            this.button_delete = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.button_close = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.tab_new.SuspendLayout();
            this.tab_edit.SuspendLayout();
            this.tab_delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tab_new);
            this.metroTabControl1.Controls.Add(this.tab_edit);
            this.metroTabControl1.Controls.Add(this.tab_delete);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 55);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(363, 293);
            this.metroTabControl1.TabIndex = 0;
            // 
            // tab_new
            // 
            this.tab_new.Controls.Add(this.button_insert);
            this.tab_new.Controls.Add(this.radio_access3);
            this.tab_new.Controls.Add(this.radio_access2);
            this.tab_new.Controls.Add(this.radio_access1);
            this.tab_new.Controls.Add(this.metroLabel3);
            this.tab_new.Controls.Add(this.metroLabel2);
            this.tab_new.Controls.Add(this.metroLabel1);
            this.tab_new.Controls.Add(this.text_newconfirm);
            this.tab_new.Controls.Add(this.text_newpass);
            this.tab_new.Controls.Add(this.text_newuser);
            this.tab_new.HorizontalScrollbarBarColor = true;
            this.tab_new.Location = new System.Drawing.Point(4, 28);
            this.tab_new.Name = "tab_new";
            this.tab_new.Size = new System.Drawing.Size(355, 261);
            this.tab_new.TabIndex = 0;
            this.tab_new.Text = "Novo";
            this.tab_new.VerticalScrollbarBarColor = true;
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(118, 214);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(120, 23);
            this.button_insert.TabIndex = 7;
            this.button_insert.Text = "Cadastrar";
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // radio_access3
            // 
            this.radio_access3.AutoSize = true;
            this.radio_access3.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radio_access3.Location = new System.Drawing.Point(23, 161);
            this.radio_access3.Name = "radio_access3";
            this.radio_access3.Size = new System.Drawing.Size(114, 19);
            this.radio_access3.TabIndex = 6;
            this.radio_access3.Text = "Administrativo";
            // 
            // radio_access2
            // 
            this.radio_access2.AutoSize = true;
            this.radio_access2.Checked = true;
            this.radio_access2.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radio_access2.Location = new System.Drawing.Point(23, 140);
            this.radio_access2.Name = "radio_access2";
            this.radio_access2.Size = new System.Drawing.Size(101, 19);
            this.radio_access2.TabIndex = 5;
            this.radio_access2.TabStop = true;
            this.radio_access2.Text = "Colaborador";
            // 
            // radio_access1
            // 
            this.radio_access1.AutoSize = true;
            this.radio_access1.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radio_access1.Location = new System.Drawing.Point(23, 119);
            this.radio_access1.Name = "radio_access1";
            this.radio_access1.Size = new System.Drawing.Size(119, 19);
            this.radio_access1.TabIndex = 4;
            this.radio_access1.Text = "Frente de Caixa";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 79);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Confirmação:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Senha:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Usuário:";
            // 
            // text_newconfirm
            // 
            this.text_newconfirm.Location = new System.Drawing.Point(129, 79);
            this.text_newconfirm.MaxLength = 50;
            this.text_newconfirm.Name = "text_newconfirm";
            this.text_newconfirm.PasswordChar = '*';
            this.text_newconfirm.Size = new System.Drawing.Size(193, 23);
            this.text_newconfirm.TabIndex = 3;
            this.text_newconfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_newpass
            // 
            this.text_newpass.Location = new System.Drawing.Point(129, 50);
            this.text_newpass.MaxLength = 50;
            this.text_newpass.Name = "text_newpass";
            this.text_newpass.PasswordChar = '*';
            this.text_newpass.Size = new System.Drawing.Size(193, 23);
            this.text_newpass.TabIndex = 2;
            this.text_newpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_newuser
            // 
            this.text_newuser.Location = new System.Drawing.Point(129, 21);
            this.text_newuser.MaxLength = 50;
            this.text_newuser.Name = "text_newuser";
            this.text_newuser.Size = new System.Drawing.Size(193, 23);
            this.text_newuser.TabIndex = 1;
            this.text_newuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tab_edit
            // 
            this.tab_edit.Controls.Add(this.metroButton3);
            this.tab_edit.Controls.Add(this.metroRadioButton4);
            this.tab_edit.Controls.Add(this.metroRadioButton5);
            this.tab_edit.Controls.Add(this.metroRadioButton6);
            this.tab_edit.Controls.Add(this.metroLabel4);
            this.tab_edit.Controls.Add(this.metroLabel5);
            this.tab_edit.Controls.Add(this.metroLabel6);
            this.tab_edit.Controls.Add(this.metroTextBox4);
            this.tab_edit.Controls.Add(this.metroTextBox5);
            this.tab_edit.Controls.Add(this.metroTextBox6);
            this.tab_edit.HorizontalScrollbarBarColor = true;
            this.tab_edit.Location = new System.Drawing.Point(4, 28);
            this.tab_edit.Name = "tab_edit";
            this.tab_edit.Size = new System.Drawing.Size(355, 261);
            this.tab_edit.TabIndex = 1;
            this.tab_edit.Text = "Editar";
            this.tab_edit.VerticalScrollbarBarColor = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(118, 214);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(120, 23);
            this.metroButton3.TabIndex = 7;
            this.metroButton3.Text = "Pesquisar";
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButton4.Location = new System.Drawing.Point(23, 161);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(114, 19);
            this.metroRadioButton4.TabIndex = 6;
            this.metroRadioButton4.Text = "Administrativo";
            // 
            // metroRadioButton5
            // 
            this.metroRadioButton5.AutoSize = true;
            this.metroRadioButton5.Checked = true;
            this.metroRadioButton5.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButton5.Location = new System.Drawing.Point(23, 140);
            this.metroRadioButton5.Name = "metroRadioButton5";
            this.metroRadioButton5.Size = new System.Drawing.Size(101, 19);
            this.metroRadioButton5.TabIndex = 5;
            this.metroRadioButton5.TabStop = true;
            this.metroRadioButton5.Text = "Colaborador";
            // 
            // metroRadioButton6
            // 
            this.metroRadioButton6.AutoSize = true;
            this.metroRadioButton6.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButton6.Location = new System.Drawing.Point(23, 119);
            this.metroRadioButton6.Name = "metroRadioButton6";
            this.metroRadioButton6.Size = new System.Drawing.Size(119, 19);
            this.metroRadioButton6.TabIndex = 4;
            this.metroRadioButton6.Text = "Frente de Caixa";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 79);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 19);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Confirmação:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 50);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Senha:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 21);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Usuário:";
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.Enabled = false;
            this.metroTextBox4.Location = new System.Drawing.Point(129, 79);
            this.metroTextBox4.MaxLength = 50;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '*';
            this.metroTextBox4.Size = new System.Drawing.Size(193, 23);
            this.metroTextBox4.TabIndex = 3;
            this.metroTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.Enabled = false;
            this.metroTextBox5.Location = new System.Drawing.Point(129, 50);
            this.metroTextBox5.MaxLength = 50;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '*';
            this.metroTextBox5.Size = new System.Drawing.Size(193, 23);
            this.metroTextBox5.TabIndex = 2;
            this.metroTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroTextBox6
            // 
            this.metroTextBox6.Location = new System.Drawing.Point(129, 21);
            this.metroTextBox6.MaxLength = 50;
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.Size = new System.Drawing.Size(193, 23);
            this.metroTextBox6.TabIndex = 1;
            this.metroTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tab_delete
            // 
            this.tab_delete.Controls.Add(this.label_deletename);
            this.tab_delete.Controls.Add(this.label_deleteuser);
            this.tab_delete.Controls.Add(this.button_deleterefresh);
            this.tab_delete.Controls.Add(this.button_delete);
            this.tab_delete.Controls.Add(this.metroComboBox1);
            this.tab_delete.HorizontalScrollbarBarColor = true;
            this.tab_delete.Location = new System.Drawing.Point(4, 28);
            this.tab_delete.Name = "tab_delete";
            this.tab_delete.Size = new System.Drawing.Size(355, 261);
            this.tab_delete.TabIndex = 2;
            this.tab_delete.Text = "Deletar";
            this.tab_delete.VerticalScrollbarBarColor = true;
            // 
            // label_deletename
            // 
            this.label_deletename.AutoSize = true;
            this.label_deletename.Location = new System.Drawing.Point(40, 104);
            this.label_deletename.Name = "label_deletename";
            this.label_deletename.Size = new System.Drawing.Size(49, 19);
            this.label_deletename.TabIndex = 5;
            this.label_deletename.Text = "Nome:";
            // 
            // label_deleteuser
            // 
            this.label_deleteuser.AutoSize = true;
            this.label_deleteuser.Location = new System.Drawing.Point(40, 76);
            this.label_deleteuser.Name = "label_deleteuser";
            this.label_deleteuser.Size = new System.Drawing.Size(56, 19);
            this.label_deleteuser.TabIndex = 4;
            this.label_deleteuser.Text = "Usuário:";
            // 
            // button_deleterefresh
            // 
            this.button_deleterefresh.Location = new System.Drawing.Point(40, 160);
            this.button_deleterefresh.Name = "button_deleterefresh";
            this.button_deleterefresh.Size = new System.Drawing.Size(120, 23);
            this.button_deleterefresh.TabIndex = 2;
            this.button_deleterefresh.Text = "Atualizar";
            this.button_deleterefresh.Click += new System.EventHandler(this.button_deleterefresh_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(185, 160);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(120, 23);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Deletar";
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(40, 24);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(265, 29);
            this.metroComboBox1.TabIndex = 1;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(284, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(120, 23);
            this.button_close.TabIndex = 10;
            this.button_close.Text = "Fechar";
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 374);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tab_new.ResumeLayout(false);
            this.tab_new.PerformLayout();
            this.tab_edit.ResumeLayout(false);
            this.tab_edit.PerformLayout();
            this.tab_delete.ResumeLayout(false);
            this.tab_delete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tab_new;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox text_newconfirm;
        private MetroFramework.Controls.MetroTextBox text_newpass;
        private MetroFramework.Controls.MetroTextBox text_newuser;
        private MetroFramework.Controls.MetroTabPage tab_edit;
        private MetroFramework.Controls.MetroButton button_insert;
        private MetroFramework.Controls.MetroRadioButton radio_access3;
        private MetroFramework.Controls.MetroRadioButton radio_access2;
        private MetroFramework.Controls.MetroRadioButton radio_access1;
        private MetroFramework.Controls.MetroButton button_close;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton5;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroTabPage tab_delete;
        private MetroFramework.Controls.MetroButton button_deleterefresh;
        private MetroFramework.Controls.MetroButton button_delete;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel label_deletename;
        private MetroFramework.Controls.MetroLabel label_deleteuser;
    }
}