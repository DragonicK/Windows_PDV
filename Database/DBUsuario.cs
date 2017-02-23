using System;
using System.Text;
using MySql.Data.MySqlClient;
using Windows_PDV.Controller;

namespace Windows_PDV.Database {
    public class DBUsuario {
        /// <summary>
        /// Verifica se o usuário existe no banco.
        /// </summary>
        /// <param name="user">nome de usuário</param>
        /// <returns></returns>
        public static bool ExistUser(string user) {
            var query = $"SELECT usuario FROM usuario WHERE usuario='{user}'";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var reader = cmd.ExecuteReader();
            var read = reader.Read();  
   
            reader.Close();
            Configuration2.Connection.CloseConnection();

            return read;
        }

        /// <summary>
        /// Verifica se o usuário e senha existem.
        /// </summary>
        /// <param name="user">nome de usuário</param>
        /// <param name="password">senha de usuário</param>
        /// <returns></returns>
        public static bool ExistUser(string user, string password) {
            var query = $"SELECT usuario, senha FROM usuario WHERE usuario='{user}'";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var reader = cmd.ExecuteReader();
            var read = reader.Read();

            if (!read) {
                reader.Close();
                Configuration2.Connection.CloseConnection();
                return false;
            }

            var _password = reader["senha"].ToString();
            //re-utilizar a variavel 'read'
            if (string.CompareOrdinal(_password, password) != 0) read = false;
 
            reader.Close();
            Configuration2.Connection.CloseConnection();
            return read;
        }

        /// <summary>
        /// Insere um novo usuário no banco de dados.
        /// </summary>
        /// <param name="user">nome de usuário</param>
        /// <param name="password">senha de usuário</param>
        /// <param name="access">nível de acesso</param>
        public static void NewUser(string user, string password, short access) {
            var query = $"INSERT INTO usuario (usuario, senha, acesso, nome) VALUES ('{user}', '{password}', '{access}', 'Meu Nome')";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            cmd.ExecuteNonQuery();

            Configuration2.Connection.CloseConnection();      
        }

        /// <summary>
        /// Deleta um usuario do banco de dados.
        /// </summary>
        /// <param name="user"></param>d
        /// <param name="id"></param>
        public static void DeleteUser(string user, int id) {
            var query = $"DELETE from usuario WHERE usuario='{user}' AND id='{id}'";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            cmd.ExecuteNonQuery();

            Configuration2.Connection.CloseConnection();
        }

        public void UpdateUser(string user) {
          

        }

        /// <summary>
        /// Carrega informações e configurações de usuário.
        /// </summary>
        /// <param name="user">nome de usuário</param>
        public static void LoadUserProfile(string user) {
            var query = $"SELECT usuario, acesso, nome FROM usuario WHERE usuario='{user}'";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var reader = cmd.ExecuteReader();
            var read = reader.Read();

            if (!read) {
                reader.Close();
                Configuration2.Connection.CloseConnection();
                return;
            }

            Users.CurrentUser.User = reader["usuario"].ToString();
            Users.CurrentUser.Acesso = Convert.ToInt16(reader["acesso"]);
            Users.CurrentUser.Name = reader["nome"].ToString();

            reader.Close();
            Configuration2.Connection.CloseConnection();

        }

           /// <summary>
        /// Obtem a lista de usuários.
        /// </summary>
        /// <returns></returns>
        public static void ListUser() {
            var query = $"SELECT id, usuario, nome FROM account";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var reader = cmd.ExecuteReader();
            Users.ListUser.Clear();

            while (reader.Read()) {
                var person = new Person();
                person.ID = Convert.ToInt32(reader["id"]);
                person.User = reader["usuario"].ToString();
                person.Name = reader["nome"].ToString();

                Users.ListUser.Add(person);
            }

            reader.Close();

            Configuration2.Connection.CloseConnection();
        }
    }
}