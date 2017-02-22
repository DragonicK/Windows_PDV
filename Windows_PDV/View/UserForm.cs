using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MetroFramework;
using System.Windows.Forms;
using Windows_PDV.Database;
using Windows_PDV.Controller;

namespace Windows_PDV.View {
    public partial class UserForm : Form {
        private List<int> ID = new List<int>();

        int selectedIndex = -1;

        public UserForm() {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void UserForm_Load(object sender, EventArgs e) {
            metroComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            UpdateDeleteList();
        }

        /// <summary>
        /// Insere um novo usuário no banco de dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_insert_Click(object sender, EventArgs e) {
            var user = text_newuser.Text.Trim().ToLower();
            var pass = text_newpass.Text.Trim().ToLower();
            var confirm = text_newconfirm.Text.Trim().ToLower();
            var access = short.MaxValue;

            if (string.IsNullOrWhiteSpace(user)) return;
            if (string.IsNullOrWhiteSpace(pass)) return;
            if (string.IsNullOrWhiteSpace(confirm)) return;

            if (radio_access1.Checked) access = 1;
            if (radio_access2.Checked) access = 2;
            if (radio_access3.Checked) access = 3;
          
            if (user.Length < 4 || pass.Length < 4 || confirm.Length < 4) {
                MetroMessageBox.Show(this, "Nome e senha de usuário devem conter mais que 3 dígitos.");
                return;
            }

            if (DBUsuario.ExistUser(user)) {
                MetroMessageBox.Show(this, "Já existe um usuário cadastrado com este nome.");
                return;
            }

            if (string.CompareOrdinal(pass, confirm) != 0) {
                MetroMessageBox.Show(this, "Senhas não coincidem, digite novamente.");

                text_newpass.Text = string.Empty;
                text_newconfirm.Text = string.Empty;
                return; 
            }

            pass = Hash.Compute(pass);

            DBUsuario.NewUser(user, pass, access);

            if (DBUsuario.ExistUser(user)) {
                text_newuser.Text = string.Empty;
                text_newpass.Text = string.Empty;
                text_newconfirm.Text = string.Empty;
                MessageBox.Show("Usuário cadastrado.");
            }

        }

        /// <summary>
        /// Atualiza a lista de usuarios
        /// </summary>
        private void UpdateDeleteList() {
            selectedIndex = -1;
            metroComboBox1.Items.Clear();
            metroComboBox1.Text = string.Empty;

            DBUsuario.ListUser();

            var lenght = Users.ListUser.Count - 1;

            for(var index = 0; index <= lenght; index++) {
                 metroComboBox1.Items.Add($"Usuário: {Users.ListUser[index].User}");
            }
        }

        private void button_deleterefresh_Click(object sender, EventArgs e) {
            UpdateDeleteList();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            selectedIndex = metroComboBox1.SelectedIndex;

            if (selectedIndex == -1) return;

            label_deleteuser.Text = "Usuário: " + Users.ListUser[selectedIndex].User;
            label_deletename.Text = "Nome: " +Users.ListUser[selectedIndex].Name;
        }

        private void button_delete_Click(object sender, EventArgs e) {
            if (selectedIndex == -1) return;

            if (Users.ListUser[selectedIndex].User.CompareTo(Users.CurrentUser.User) == 0) {
                MetroMessageBox.Show(this, "Esse usuário está em uso e não pode ser deletado.");
                return;
            }

            DBUsuario.DeleteUser(Users.ListUser[selectedIndex].User, Users.ListUser[selectedIndex].ID);

            UpdateDeleteList();
        }
    }
}
