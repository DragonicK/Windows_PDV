using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using Windows_PDV.Database;
using Windows_PDV.Controller;

namespace Windows_PDV {
    public partial class frmLogin : MetroForm, IMetroForm {

        /// <summary>
        /// Estado de inicialização.
        /// </summary>
        private int state;
        /// <summary>
        /// Inicialização do sistema.
        /// </summary>
        private const int SYS_START = 0;
        /// <summary>
        /// 
        /// Finalização do sistema.
        /// </summary>
        private const int SYS_END = 1;

        #region Formulário
        public frmLogin() {
            InitializeComponent();
        }

        /// <summary>
        /// Inicialização.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e) {
            timer1.Start();

            state = SYS_START;

            Configuration2.InitializeDatabase();

            state = SYS_END;
        }

        /// <summary>
        /// Quando pressionado enter, executa o login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) Login_Execute();
        }
        #endregion

        #region Botão

        /// <summary>
        /// Botão de login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            Login_Execute();
        }

        /// <summary>
        /// Saída.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(Object sender, EventArgs e) {
            Environment.Exit(1);
        }

        #endregion

        /// <summary>
        /// Altera o status bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) {
            if (state == SYS_START) { metroLabel1.Text = "Sistema inicializando."; }

            if (state == SYS_END) {
                metroLabel1.Text = "Sistema inicializado.";
                timer1.Stop();
            }

        }

        /// <summary>
        /// Executa o login no sistema.
        /// </summary>
        private void Login_Execute() {
            var user = textBox1.Text.Trim().ToLower();
            var pass = textBox2.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(user)) return;
            if (string.IsNullOrWhiteSpace(pass)) return;

            if (user.Length < 4 || pass.Length < 4) {
                MetroMessageBox.Show(this, "Nome e senha de usuário devem conter mais que 3 dígitos.", "", 120);             
                return;
            }

            if (!DBUsuario.ExistUser(user)) {
                MetroMessageBox.Show(this, "Usuário não cadastrado.", "", 120);
                return;
            }

            if (!DBUsuario.ExistUser(user, Hash.Compute(pass))) {
                MetroMessageBox.Show(this, "Usuário ou senha incorreto.", "", 120);
                return;
            }

            Users.Login(user, pass);

            this.Close();
        }
    }
}
