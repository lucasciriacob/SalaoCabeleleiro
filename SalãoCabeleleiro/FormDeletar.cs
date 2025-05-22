using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SalãoCabeleleiro
{
    public partial class FormDeletar : Form
    {
        public FormDeletar()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            txtCod.Clear();
            txtOutro.Clear();
            cbxMotivo.SelectedIndex = -1;
            txtOutro.Visible = false;
        }
        private void FormDeletar_Load(object sender, EventArgs e)
        {
        }
        private void btnCalncelar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCod.Text) || string.IsNullOrWhiteSpace(cbxMotivo.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }
            string connectionString = "dataSource = localhost; username = root; password =; database = bd_salao";
            string codigo = txtCod.Text.Trim();
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                string query = "DELETE FROM agendamento WHERE (id_agendamento)= @id_agendamento;";
                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@id_agendamento", codigo);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agendamento deletado com sucesso!");   
                }
            }
            LimparCampos();
        }
        private void cbxMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMotivo.Text == "Outro (especificar)")
            {
                txtOutro.Visible = true;
                cbxMotivo.Visible = false;
            }
            else
            {
                txtOutro.Visible = false;
                cbxMotivo.Visible = true;
            }
        }

        private void pbxVoltar_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Hide();
        }

        private void txtCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbxMotivo.Focus();
            }
        }

        private void cbxMotivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalncelar.PerformClick();
            }

        }

        private void txtOutro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCalncelar.PerformClick();
            }
        }
    }
}
