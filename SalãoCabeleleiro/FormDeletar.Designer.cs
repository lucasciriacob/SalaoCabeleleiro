namespace SalãoCabeleleiro
{
    partial class FormDeletar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalncelar = new Button();
            txtCod = new TextBox();
            pictureBox1 = new PictureBox();
            cbxMotivo = new ComboBox();
            txtOutro = new TextBox();
            pbxVoltar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxVoltar).BeginInit();
            SuspendLayout();
            // 
            // btnCalncelar
            // 
            btnCalncelar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalncelar.Location = new Point(107, 168);
            btnCalncelar.Name = "btnCalncelar";
            btnCalncelar.Size = new Size(102, 31);
            btnCalncelar.TabIndex = 0;
            btnCalncelar.Text = "Cancelar";
            btnCalncelar.UseVisualStyleBackColor = true;
            btnCalncelar.Click += btnCalncelar_Click;
            // 
            // txtCod
            // 
            txtCod.Location = new Point(70, 77);
            txtCod.Name = "txtCod";
            txtCod.PlaceholderText = "Código do agendamento...";
            txtCod.Size = new Size(175, 23);
            txtCod.TabIndex = 1;
            txtCod.KeyDown += txtCod_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_20_de_mai__de_2025__09_33_01;
            pictureBox1.Location = new Point(126, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // cbxMotivo
            // 
            cbxMotivo.FormattingEnabled = true;
            cbxMotivo.Items.AddRange(new object[] { "Cliente solicitou o cancelamento", "", "Cliente não compareceu", "", "Reagendado para outra data", "", "Problemas de saúde do cliente", "", "Profissional indisponível", "", "Problemas técnicos no salão", "", "Evento externo imprevisto (chuva, trânsito etc.)", "", "Horário agendado incorretamente", "", "Agendamento duplicado", "", "Cancelado por erro de sistema", "", "Cliente desistiu do serviço", "", "Outro (especificar)" });
            cbxMotivo.Location = new Point(70, 120);
            cbxMotivo.Name = "cbxMotivo";
            cbxMotivo.Size = new Size(175, 23);
            cbxMotivo.TabIndex = 3;
            cbxMotivo.SelectedIndexChanged += cbxMotivo_SelectedIndexChanged;
            cbxMotivo.KeyDown += cbxMotivo_KeyDown;
            // 
            // txtOutro
            // 
            txtOutro.Location = new Point(87, 120);
            txtOutro.Name = "txtOutro";
            txtOutro.PlaceholderText = "Escreva o motivo...";
            txtOutro.Size = new Size(139, 23);
            txtOutro.TabIndex = 4;
            txtOutro.Visible = false;
            txtOutro.KeyDown += txtOutro_KeyDown;
            // 
            // pbxVoltar
            // 
            pbxVoltar.Image = Properties.Resources.botao_voltar;
            pbxVoltar.Location = new Point(1, 1);
            pbxVoltar.Name = "pbxVoltar";
            pbxVoltar.Size = new Size(42, 39);
            pbxVoltar.SizeMode = PictureBoxSizeMode.Zoom;
            pbxVoltar.TabIndex = 7;
            pbxVoltar.TabStop = false;
            pbxVoltar.Click += pbxVoltar_Click;
            // 
            // FormDeletar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 211);
            Controls.Add(pbxVoltar);
            Controls.Add(txtOutro);
            Controls.Add(cbxMotivo);
            Controls.Add(pictureBox1);
            Controls.Add(txtCod);
            Controls.Add(btnCalncelar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDeletar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cancelar Horário";
            Load += FormDeletar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxVoltar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalncelar;
        private TextBox txtCod;
        private PictureBox pictureBox1;
        private ComboBox cbxMotivo;
        private TextBox txtOutro;
        private PictureBox pbxVoltar;
    }
}