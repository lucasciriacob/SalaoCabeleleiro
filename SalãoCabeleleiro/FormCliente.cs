using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SalãoCabeleleiro
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();

        }
        private void PreencherCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(mskTelefone.Text)
                || string.IsNullOrWhiteSpace(mskHora.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            mskTelefone.Clear();
            mskHora.Clear();
            dtpData.Value = DateTime.Now;
        }
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;username=root;password=;database=bd_salao";
            PreencherCampos();
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                string queryAgendar = "INSERT INTO agendamento (nome_cliente, telefone_cliente, data, hora) VALUES (@nome_cliente, @telefone_cliente, @data, @hora)";
                if (dtpData.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Data inválida. Por favor, escolha uma data futura.");
                    return;
                }
                using (MySqlCommand cmdAgendar = new MySqlCommand(queryAgendar, conexao))
                {
                    cmdAgendar.Parameters.AddWithValue("@nome_cliente", txtNome.Text);
                    cmdAgendar.Parameters.AddWithValue("@telefone_cliente", mskTelefone.Text);
                    cmdAgendar.Parameters.AddWithValue("@data", dtpData.Value.ToString("yyyy-MM-dd"));
                    cmdAgendar.Parameters.AddWithValue("@hora", mskHora.Text);
                    try
                    {
                        cmdAgendar.ExecuteNonQuery();

                        MessageBox.Show("Agendamento realizado com sucesso!");
                        LimparCampos();
                    }
                    catch (MySqlException ex)
                    {
                        if (ex.Number == 1062) // Código de erro para violação de UNIQUE
                        {
                            MessageBox.Show("Escolha outro horário, por favor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao agendar: " + ex.Message);
                        }
                    }


                }
            }


        }

        private void pbxVoltar_Click(object sender, EventArgs e)
        {
            if (SessaoUsuario.TipoUsuario == "admin")
            {
                FormMenu formAdmin = new FormMenu();
                formAdmin.Show();
            }
            else
            {
                FormAuth formCliente = new FormAuth();
                formCliente.Show();
            }

            this.Hide();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mskTelefone.Focus();
            }
        }

        private void mskTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpData.Focus();
            }
        }

        private void dtpData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mskHora.Focus();
            }
        }

        private void mskHora_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAgendar.PerformClick();
            }
        }
    }
}


