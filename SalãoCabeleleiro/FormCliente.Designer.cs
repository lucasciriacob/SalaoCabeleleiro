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
            pictureBox2 = new PictureBox();
            cbxHorario = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(276, 149);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(100, 23);
            dtpData.TabIndex = 2;
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(33, 149);
            mskTelefone.Mask = "(00) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(204, 23);
            mskTelefone.TabIndex = 3;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(34, 334);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(342, 38);
            btnAgendar.TabIndex = 4;
            btnAgendar.Text = "AGENDAR";
            btnAgendar.UseVisualStyleBackColor = true;
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.botao_voltar;
            pictureBox2.Location = new Point(2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // cbxHorario
            // 
            cbxHorario.FormattingEnabled = true;
            cbxHorario.Location = new Point(33, 205);
            cbxHorario.Name = "cbxHorario";
            cbxHorario.Size = new Size(343, 23);
            cbxHorario.TabIndex = 7;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 405);
            Controls.Add(cbxHorario);
            Controls.Add(pictureBox2);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private DateTimePicker dtpData;
        private MaskedTextBox mskTelefone;
        private Button btnAgendar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox cbxHorario;
    }
}