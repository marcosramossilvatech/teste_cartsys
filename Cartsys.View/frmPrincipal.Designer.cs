namespace Cartsys.View
{
    partial class frmPrincipal
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
            components = new System.ComponentModel.Container();
            pnlPrincipal = new Panel();
            pnlRodape = new Panel();
            pnlCentral = new Panel();
            pnlTopo = new Panel();
            lblUsuario = new Label();
            bntFechar = new PictureBox();
            ptbMenu = new PictureBox();
            pnlEsquerdo = new Panel();
            btnCadastroPessoa = new Button();
            panel3 = new Panel();
            pnlLogo = new Panel();
            imgLogo = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlPrincipal.SuspendLayout();
            pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bntFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).BeginInit();
            pnlEsquerdo.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Controls.Add(pnlRodape);
            pnlPrincipal.Controls.Add(pnlCentral);
            pnlPrincipal.Controls.Add(pnlTopo);
            pnlPrincipal.Controls.Add(pnlEsquerdo);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(1186, 748);
            pnlPrincipal.TabIndex = 0;
            // 
            // pnlRodape
            // 
            pnlRodape.BackColor = Color.FromArgb(16, 26, 40);
            pnlRodape.Dock = DockStyle.Bottom;
            pnlRodape.Location = new Point(244, 725);
            pnlRodape.Name = "pnlRodape";
            pnlRodape.Size = new Size(942, 23);
            pnlRodape.TabIndex = 3;
            // 
            // pnlCentral
            // 
            pnlCentral.Dock = DockStyle.Fill;
            pnlCentral.Location = new Point(244, 63);
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Size = new Size(942, 685);
            pnlCentral.TabIndex = 2;
            // 
            // pnlTopo
            // 
            pnlTopo.BackColor = Color.FromArgb(16, 26, 40);
            pnlTopo.Controls.Add(lblUsuario);
            pnlTopo.Controls.Add(bntFechar);
            pnlTopo.Controls.Add(ptbMenu);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(244, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(942, 63);
            pnlTopo.TabIndex = 1;
            pnlTopo.MouseDown += pnlTopo_MouseDown;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(314, 20);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(580, 23);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Marcos Ramos da Silva";
            lblUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // bntFechar
            // 
            bntFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntFechar.Image = Properties.Resources._10758929_user_check_icon;
            bntFechar.Location = new Point(900, 14);
            bntFechar.Name = "bntFechar";
            bntFechar.Size = new Size(27, 29);
            bntFechar.SizeMode = PictureBoxSizeMode.Zoom;
            bntFechar.TabIndex = 3;
            bntFechar.TabStop = false;
            bntFechar.Click += bntFechar_Click;
            // 
            // ptbMenu
            // 
            ptbMenu.Image = Properties.Resources._9034957_menu_icon;
            ptbMenu.Location = new Point(20, 10);
            ptbMenu.Name = "ptbMenu";
            ptbMenu.Size = new Size(40, 42);
            ptbMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            ptbMenu.TabIndex = 0;
            ptbMenu.TabStop = false;
            ptbMenu.Click += ptbMenu_Click;
            // 
            // pnlEsquerdo
            // 
            pnlEsquerdo.BackColor = Color.FromArgb(16, 26, 40);
            pnlEsquerdo.Controls.Add(btnCadastroPessoa);
            pnlEsquerdo.Controls.Add(panel3);
            pnlEsquerdo.Controls.Add(pnlLogo);
            pnlEsquerdo.Dock = DockStyle.Left;
            pnlEsquerdo.Location = new Point(0, 0);
            pnlEsquerdo.Name = "pnlEsquerdo";
            pnlEsquerdo.Size = new Size(244, 748);
            pnlEsquerdo.TabIndex = 0;
            // 
            // btnCadastroPessoa
            // 
            btnCadastroPessoa.FlatAppearance.BorderColor = Color.FromArgb(16, 26, 40);
            btnCadastroPessoa.FlatStyle = FlatStyle.Flat;
            btnCadastroPessoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastroPessoa.ForeColor = Color.White;
            btnCadastroPessoa.Image = Properties.Resources._9035989_person_add_sharp_icon;
            btnCadastroPessoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastroPessoa.Location = new Point(18, 91);
            btnCadastroPessoa.Name = "btnCadastroPessoa";
            btnCadastroPessoa.Size = new Size(232, 52);
            btnCadastroPessoa.TabIndex = 3;
            btnCadastroPessoa.Text = "Pessoas";
            btnCadastroPessoa.UseVisualStyleBackColor = true;
            btnCadastroPessoa.Click += btnCadastroPessoa_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(13, 657);
            panel3.TabIndex = 1;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(imgLogo);
            pnlLogo.Controls.Add(panel2);
            pnlLogo.Controls.Add(panel1);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(244, 91);
            pnlLogo.TabIndex = 0;
            // 
            // imgLogo
            // 
            imgLogo.Dock = DockStyle.Fill;
            imgLogo.Image = Properties.Resources.logo;
            imgLogo.Location = new Point(13, 7);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(231, 84);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 2;
            imgLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(13, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 7);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(13, 91);
            panel1.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 748);
            Controls.Add(pnlPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrincipal";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            pnlPrincipal.ResumeLayout(false);
            pnlTopo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bntFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).EndInit();
            pnlEsquerdo.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Panel pnlTopo;
        private Panel pnlEsquerdo;
        private PictureBox ptbMenu;
        private Panel pnlLogo;
        private PictureBox imgLogo;
        private Panel panel2;
        private Panel panel1;
        private Button btnCadastroPessoa;
        private Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private Panel pnlCentral;
        private Panel pnlRodape;
        private PictureBox bntFechar;
        private Label lblUsuario;
    }
}
