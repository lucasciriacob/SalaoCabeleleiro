namespace SalãoCabeleleiro
{
    partial class FormCliente
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
            txtNome = new TextBox();
            dtpData = new DateTimePicker();
            mskTelefone = new MaskedTextBox();
            btnAgendar = new Button();
            pictureBox1 = new PictureBox();
            pbxVoltar = new PictureBox();
            mskHora = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxVoltar).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(33, 104);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome...";
            txtNome.Size = new Size(204, 23);
            txtNome.TabIndex = 0;
            txtNome.TextAlign = HorizontalAlignment.Center;
            txtNome.KeyDown += txtNome_KeyDown;
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(34, 218);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(204, 23);
            dtpData.TabIndex = 2;
            dtpData.KeyDown += dtpData_KeyDown;
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(33, 164);
            mskTelefone.Mask = "(00) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(204, 23);
            mskTelefone.TabIndex = 3;
            mskTelefone.TextAlign = HorizontalAlignment.Center;
            mskTelefone.KeyDown += mskTelefone_KeyDown;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(34, 334);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(342, 38);
            btnAgendar.TabIndex = 4;
            btnAgendar.Text = "AGENDAR";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_20_de_mai__de_2025__09_33_01;
            pictureBox1.Location = new Point(157, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pbxVoltar
            // 
            pbxVoltar.Image = Properties.Resources.botao_voltar;
            pbxVoltar.Location = new Point(2, 1);
            pbxVoltar.Name = "pbxVoltar";
            pbxVoltar.Size = new Size(42, 39);
            pbxVoltar.SizeMode = PictureBoxSizeMode.Zoom;
            pbxVoltar.TabIndex = 6;
            pbxVoltar.TabStop = false;
            pbxVoltar.Click += pbxVoltar_Click;
            // 
            // mskHora
            // 
            mskHora.Location = new Point(34, 281);
            mskHora.Mask = "90:00";
            mskHora.Name = "mskHora";
            mskHora.Size = new Size(204, 23);
            mskHora.TabIndex = 8;
            mskHora.TextAlign = HorizontalAlignment.Center;
            mskHora.ValidatingType = typeof(DateTime);
            mskHora.KeyDown += mskHora_KeyDown;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 405);
            Controls.Add(mskHora);
            Controls.Add(pbxVoltar);
            Controls.Add(pictureBox1);
            Controls.Add(btnAgendar);
            Controls.Add(mskTelefone);
            Controls.Add(dtpData);
            Controls.Add(txtNome);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela do Cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxVoltar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private DateTimePicker dtpData;
        private MaskedTextBox mskTelefone;
        private Button btnAgendar;
        private PictureBox pictureBox1;
        private PictureBox pbxVoltar;
        private MaskedTextBox mskHora;
    }
}