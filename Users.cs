using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MetroFramework;
using Windows_PDV.Controller;
using Windows_PDV.Database;
using Windows_PDV.View;

namespace Windows_PDV {
    public class Users {
        /// <summary>
        /// Atual usuário do sistema.
        /// </summary>
        public static Person CurrentUser { get; set; } = new Person();

        public static List<Person> ListUser { get; set; } = new List<Person>();

        /// <summary>
        /// Realiza o login no sistema.
        /// </summary>
        /// <param name="user">nome de usuário</param>
        /// <param name="password">senha de usuário</param>
        public static void Login(string user, string password) {      
            //computa o hash para proteger a senha de sniffers.
            var pass = Hash.Compute(password);

            //verifica se nome e senha estão corretos.
            var result = DBUsuario.ExistUser(user , pass);

            if (!result) {
                MetroMessageBox.Show(null, "Usuário ou senha incorretos.", "Aviso");
                return;
            }

            DBUsuario.LoadUserProfile(user);

            //vá para a próxima tela.
          //  Program.MainForm.Show();
        }
    }
}
