namespace SalãoCabeleleiro
{
    partial class FormAuth
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUser = new TextBox();
            txtSenha = new TextBox();
            btnLogin = new Button();
            chkSenha = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(61, 142);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Usuario...";
            txtUser.Size = new Size(289, 33);
            txtUser.TabIndex = 0;
            txtUser.TextAlign = HorizontalAlignment.Center;
            txtUser.KeyDown += txtUser_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(61, 198);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha...";
            txtSenha.Size = new Size(289, 33);
            txtSenha.TabIndex = 1;
            txtSenha.TextAlign = HorizontalAlignment.Center;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(61, 263);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(289, 37);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkSenha
            // 
            chkSenha.AutoSize = true;
            chkSenha.Location = new Point(332, 208);
            chkSenha.Name = "chkSenha";
            chkSenha.Size = new Size(15, 14);
            chkSenha.TabIndex = 4;
            chkSenha.UseVisualStyleBackColor = true;
            chkSenha.CheckedChanged += chkSenha_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_20_de_mai__de_2025__09_33_01;
            pictureBox1.Location = new Point(90, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormAuth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 363);
            Controls.Add(pictureBox1);
            Controls.Add(chkSenha);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtUser);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAuth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autenticação";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtSenha;
        private Button btnLogin;
        private CheckBox chkSenha;
        private PictureBox pictureBox1;
    }
}
