using System.Data;
using MySql.Data.MySqlClient;

/*
https://dev.mysql.com/doc/refman/5.7/en/error-messages-server.html
*/

namespace Windows_PDV.Database {
    public class DBConnection {
        private string _server, _user, _password, _database;
        private int _port;
        private MySqlConnection _connection;
        private ConnectionState _state;
           
        /// <summary>
        /// IP banco.
        /// </summary>
        public string Server {
            get {
                return _server;
            }
            set {
                _server = value;
            }
        }

        /// <summary>
        /// Porta de conexão banco.
        /// </summary>
        public int Port {
            get {
                return _port;
            }
            set {
                _port = value;
            }
        }
    
        /// <summary>
        /// 
        /// </summary>
        public string Database {
            get {
                return _database;
            }
            set {
                _database = value;
            }
        }

        /// <summary>
        /// Nome de usuário banco.
        /// </summary>
        public string User {
            get {
                return _user;
            }
            set {
                _user = value;
            }
        }

        /// <summary>
        /// Senha de usuário banco.
        /// </summary>
        public string Password {
            get {
                return _password;
            }
            set {
                _password = value;
            }
        }

        /// <summary>
        /// Conexão com o banco.
        /// </summary>
        public MySqlConnection Connection {
            get {
                return _connection;
            }
            set {
                if (value != null)
                _connection = value;
            }
        }

        /// <summary>
        /// Stado atual da conexão com o banco.
        /// </summary>
        public ConnectionState State {
            get { return _state; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public DBConnection() {
            _connection = new MySqlConnection();
            _connection.StateChange += OnStateChanged;
        }

        /// <summary>
        /// Realiza a abertura da conexão.
        /// </summary>
        public void OpenConnection() {
            try {
                _connection.ConnectionString = $"Server={_server};Port={_port};Database={_database};User ID={_user};Password={_password};";
                _connection.Open();
            }
            catch (MySqlException ex) {
                var message = ex.Message;
                var number = ex.Number;

                switch (number) {
                    case 0:
                    //"Não foi possível a conexão com o banco de dados. Entre em contato com o administrador.
                    break;

                    case 1045:
                    //Nome ou senha invalidos.
                    break;

                    default:
                    //showmessage
                    break;
                }
            }
        }

        /// <summary>
        /// Fecha a conexão.
        /// </summary>
        public void CloseConnection() {
            if (_connection != null)
            _connection.Close();
        }

        /// <summary>
        /// Quando alterado o estado de conexão.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnStateChanged(object sender, StateChangeEventArgs e) {
            _state = e.CurrentState;
        }
    }
}
