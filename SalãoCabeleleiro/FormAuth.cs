using MySql.Data.MySqlClient;

namespace SalãoCabeleleiro
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }
        public void LimparCampos()
        {
            txtUser.Clear();
            txtSenha.Clear();
            chkSenha.Checked = false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;username=root;password=;database=bd_salao";

            string usuario = txtUser.Text.Trim();
            string senha = txtSenha.Text.Trim();

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();

                string queryLogin = "SELECT id, tipo FROM usuario WHERE TRIM(nome) = @nome AND TRIM(senha) = @senha";

                using (MySqlCommand cmdLogin = new MySqlCommand(queryLogin, conexao))
                {
                    cmdLogin.Parameters.AddWithValue("@nome", usuario);
                    cmdLogin.Parameters.AddWithValue("@senha", senha);

                    using (MySqlDataReader reader = cmdLogin.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tipo = reader.GetString("tipo");
                            LimparCampos();
                            if (tipo == "admin")
                            {
                                FormMenu formAdmin = new FormMenu();
                                formAdmin.Show();
                            }
                            else
                            { 
                                FormCliente cliente = new FormCliente();
                                cliente.Show();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos.");
                        }
                    }
                }
            }
        }

        private void chkSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = chkSenha.Checked ? '\0' : '*';
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }

        }
    }
}
