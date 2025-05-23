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
                || string.IsNullOrWhiteSpace(cbxHora.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            mskTelefone.Clear();
            dtpData.Value = DateTime.Now;
            cbxHora.SelectedIndex = -1;
            cbxHora.Text = "";
        }
        private void CarregarHorariosDisponiveis(DateTime dataSelecionada)
        {
            cbxHora.Items.Clear();
            string connectionString = "datasource=localhost;username=root;password=;database=bd_salao";
            List<string> todosHorarios = new List<string>
            {
                "08:00", "08:30", "09:00", "09:30", "10:00", "10:30",
                "11:00", "11:30", "12:00", "12:30", "13:00", "13:30",
                "14:00", "14:30", "15:00", "15:30", "16:00", "16:30",
                "17:00", "17:30", "18:00"
            };

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                string query = "SELECT hora FROM agendamento WHERE data = @data";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@data", dataSelecionada.ToString("yyyy-MM-dd"));

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TimeSpan hora = reader.GetTimeSpan("hora");
                            string horaAgendada = hora.ToString(@"hh\:mm");
                            todosHorarios.Remove(horaAgendada);
                        }
                    }
                }
            }

            cbxHora.Items.AddRange(todosHorarios.ToArray());
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
                    cmdAgendar.Parameters.AddWithValue("@hora", cbxHora.Text);
                    try
                    {
                        cmdAgendar.ExecuteNonQuery();
                        MessageBox.Show("Agendamento realizado com sucesso!");
                        LimparCampos();
                        CarregarHorariosDisponiveis(dtpData.Value);
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
                cbxHora.Focus();
            }
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            CarregarHorariosDisponiveis(dtpData.Value);
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            CarregarHorariosDisponiveis(dtpData.Value);
        }
    }
}


