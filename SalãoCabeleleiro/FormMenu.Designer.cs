namespace SalãoCabeleleiro
{
    partial class FormMenu
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
            dataGridView1 = new DataGridView();
            mnsMenu = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            mnsDel = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            mnsMarcar = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            mnsSair = new ToolStripMenuItem();
            pbxLogo = new PictureBox();
            txtPesquisar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            mnsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(364, 190);
            dataGridView1.TabIndex = 0;
            // 
            // mnsMenu
            // 
            mnsMenu.Dock = DockStyle.Right;
            mnsMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, mnsDel, toolStripMenuItem6, mnsMarcar, toolStripMenuItem7, mnsSair });
            mnsMenu.Location = new Point(373, 0);
            mnsMenu.Name = "mnsMenu";
            mnsMenu.Size = new Size(154, 230);
            mnsMenu.TabIndex = 3;
            mnsMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(141, 19);
            toolStripMenuItem1.Text = "                                           ";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Enabled = false;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(141, 19);
            toolStripMenuItem2.Text = "                                         ";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Enabled = false;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(141, 19);
            toolStripMenuItem3.Text = "                           ";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Enabled = false;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(141, 19);
            toolStripMenuItem4.Text = "                             ";
            // 
            // mnsDel
            // 
            mnsDel.Name = "mnsDel";
            mnsDel.Size = new Size(141, 19);
            mnsDel.Text = "Desmarcar Horário";
            mnsDel.Click += mnsDel_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Enabled = false;
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(141, 19);
            toolStripMenuItem6.Text = "           ";
            // 
            // mnsMarcar
            // 
            mnsMarcar.Name = "mnsMarcar";
            mnsMarcar.Size = new Size(141, 19);
            mnsMarcar.Text = "Marcar Horário";
            mnsMarcar.Click += mnsMarcar_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Enabled = false;
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(141, 19);
            toolStripMenuItem7.Text = "                      ";
            // 
            // mnsSair
            // 
            mnsSair.Name = "mnsSair";
            mnsSair.Size = new Size(141, 19);
            mnsSair.Text = "Sair";
            mnsSair.Click += mnsSair_Click;
            // 
            // pbxLogo
            // 
            pbxLogo.Image = Properties.Resources.ChatGPT_Image_20_de_mai__de_2025__09_33_01;
            pbxLogo.Location = new Point(371, 12);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(152, 66);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 2;
            pbxLogo.TabStop = false;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(27, 14);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(316, 23);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 230);
            Controls.Add(txtPesquisar);
            Controls.Add(pbxLogo);
            Controls.Add(dataGridView1);
            Controls.Add(mnsMenu);
            MainMenuStrip = mnsMenu;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela do Cabeleleiro(a)";
            Load += FormMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            mnsMenu.ResumeLayout(false);
            mnsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private MenuStrip mnsMenu;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem mnsDel;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem mnsMarcar;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem mnsSair;
        private PictureBox pbxLogo;
        private TextBox txtPesquisar;
    }
}