namespace Windows_PDV.View {
    partial class CustomRow {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_id = new MetroFramework.Controls.MetroLabel();
            this.lbl_codigo = new MetroFramework.Controls.MetroLabel();
            this.lbl_preco = new MetroFramework.Controls.MetroLabel();
            this.lbl_quantidade = new MetroFramework.Controls.MetroLabel();
            this.lbl_descricao = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_id.Location = new System.Drawing.Point(3, 2);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(38, 20);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_id.Click += new System.EventHandler(this.Select);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_codigo.Location = new System.Drawing.Point(47, 2);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(118, 20);
            this.lbl_codigo.TabIndex = 1;
            this.lbl_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_codigo.Click += new System.EventHandler(this.Select);
            // 
            // lbl_preco
            // 
            this.lbl_preco.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_preco.Location = new System.Drawing.Point(642, 2);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(114, 20);
            this.lbl_preco.TabIndex = 4;
            this.lbl_preco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_preco.Click += new System.EventHandler(this.Select);
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_quantidade.Location = new System.Drawing.Point(562, 2);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(74, 20);
            this.lbl_quantidade.TabIndex = 3;
            this.lbl_quantidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_quantidade.Click += new System.EventHandler(this.Select);
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_descricao.Location = new System.Drawing.Point(171, 2);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(385, 20);
            this.lbl_descricao.TabIndex = 2;
            this.lbl_descricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_descricao.Click += new System.EventHandler(this.Select);
            // 
            // CustomRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_id);
            this.Name = "CustomRow";
            this.Size = new System.Drawing.Size(757, 22);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_id;
        private MetroFramework.Controls.MetroLabel lbl_codigo;
        private MetroFramework.Controls.MetroLabel lbl_preco;
        private MetroFramework.Controls.MetroLabel lbl_quantidade;
        private MetroFramework.Controls.MetroLabel lbl_descricao;
    }
}
