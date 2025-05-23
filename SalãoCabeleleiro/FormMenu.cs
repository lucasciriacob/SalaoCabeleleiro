﻿using System;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private BindingSource bs = new BindingSource();
        private DataTable dt = new DataTable();
        private void FormMenu_Load(object sender, EventArgs e)
        {
            string connectionString = "dataSource=localhost;username=root;password=;database=bd_salao";
            string query = "SELECT * FROM agendamento WHERE data >= CURDATE() ORDER BY data ASC, hora ASC";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        dt.Clear();
                        adapter.Fill(dt);          
                        bs.DataSource = dt;         
                        dataGridView1.DataSource = bs; 

                        dataGridView1.Columns["id_agendamento"].HeaderText = "Código";
                        dataGridView1.Columns["nome_cliente"].HeaderText = "Cliente";
                        dataGridView1.Columns["telefone_cliente"].HeaderText = "Telefone";
                        dataGridView1.Columns["data"].HeaderText = "Data";
                        dataGridView1.Columns["hora"].HeaderText = "Horário";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            FormAuth auth = new FormAuth();
            auth.Show();
            this.Hide();
        }

        private void mnsMarcar_Click(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente();
            cliente.Show();
            this.Hide();
        }

        private void mnsDel_Click(object sender, EventArgs e)
        {
            FormDeletar deletar = new FormDeletar();
            deletar.Show();
            this.Hide();
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPesquisar.Text.Trim().Replace("'", "''"); 

            if (string.IsNullOrEmpty(filtro))
            {
                bs.RemoveFilter();  
            }
            else
            {
                bs.Filter = $"nome_cliente LIKE '%{filtro}%' OR telefone_cliente LIKE '%{filtro}%'";
            }
        }
    }
}
