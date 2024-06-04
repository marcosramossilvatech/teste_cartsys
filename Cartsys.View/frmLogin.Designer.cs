namespace Cartsys.View
{
    partial class frmLogin
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
            panel1 = new Panel();
            panel3 = new Panel();
            btnCancelar = new Button();
            btnEntrar = new Button();
            txtEmai = new TextBox();
            label1 = new Label();
            btnVisualizarSenha = new PictureBox();
            txtSenha = new TextBox();
            label11 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVisualizarSenha).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 372);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnEntrar);
            panel3.Controls.Add(txtEmai);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnVisualizarSenha);
            panel3.Controls.Add(txtSenha);
            panel3.Controls.Add(label11);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 257);
            panel3.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(16, 26, 40);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(14, 173);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(292, 31);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(16, 26, 40);
            btnEntrar.FlatAppearance.BorderColor = Color.FromArgb(16, 26, 40);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntrar.Location = new Point(14, 125);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(292, 31);
            btnEntrar.TabIndex = 16;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtEmai
            // 
            txtEmai.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmai.Location = new Point(62, 37);
            txtEmai.MaxLength = 50;
            txtEmai.Name = "txtEmai";
            txtEmai.Size = new Size(244, 25);
            txtEmai.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 40);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 14;
            label1.Text = "Email:";
            // 
            // btnVisualizarSenha
            // 
            btnVisualizarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVisualizarSenha.Image = Properties.Resources.eyefehcado;
            btnVisualizarSenha.Location = new Point(262, 72);
            btnVisualizarSenha.Name = "btnVisualizarSenha";
            btnVisualizarSenha.Size = new Size(44, 29);
            btnVisualizarSenha.SizeMode = PictureBoxSizeMode.CenterImage;
            btnVisualizarSenha.TabIndex = 13;
            btnVisualizarSenha.TabStop = false;
            btnVisualizarSenha.Click += btnVisualizarSenha_Click;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(62, 76);
            txtSenha.MaxLength = 12;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(194, 25);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(14, 84);
            label11.Name = "label11";
            label11.Size = new Size(46, 17);
            label11.TabIndex = 11;
            label11.Text = "Senha:";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 115);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(321, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 372);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnVisualizarSenha).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtEmai;
        private Label label1;
        private PictureBox btnVisualizarSenha;
        private TextBox txtSenha;
        private Label label11;
        private Button btnEntrar;
        private Button btnCancelar;
    }
}