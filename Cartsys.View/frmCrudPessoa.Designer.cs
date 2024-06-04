namespace Cartsys.View
{
    partial class frmCrudPessoa
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
            panel3 = new Panel();
            btnCancelar = new Button();
            btnSalvar = new Button();
            bntFechar = new PictureBox();
            panel1 = new Panel();
            ckbUsuario = new CheckBox();
            pnlUsuario = new Panel();
            btnVisualizarConfirmacao = new PictureBox();
            btnVisualizarSenha = new PictureBox();
            txtSenhaConfirm = new TextBox();
            label12 = new Label();
            txtSenha = new TextBox();
            label11 = new Label();
            txtEMail = new TextBox();
            label10 = new Label();
            txtUF = new TextBox();
            label9 = new Label();
            txtBairro = new TextBox();
            label8 = new Label();
            txtCidade = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btnCEP = new PictureBox();
            txtCEP = new MaskedTextBox();
            label5 = new Label();
            txtTelefone = new MaskedTextBox();
            label4 = new Label();
            txtCPF = new MaskedTextBox();
            txtLogradouro = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bntFechar).BeginInit();
            panel1.SuspendLayout();
            pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVisualizarConfirmacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVisualizarSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCEP).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnSalvar);
            panel3.Controls.Add(bntFechar);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(824, 422);
            panel3.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(16, 26, 40);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(662, 373);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(137, 37);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(0, 64, 0);
            btnSalvar.FlatAppearance.BorderColor = Color.FromArgb(16, 26, 40);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(503, 373);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(137, 37);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // bntFechar
            // 
            bntFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntFechar.BackColor = Color.DarkRed;
            bntFechar.Image = Properties.Resources._4213411_cancel_circle_close_delete_remove_icon;
            bntFechar.Location = new Point(783, 12);
            bntFechar.Name = "bntFechar";
            bntFechar.Size = new Size(27, 26);
            bntFechar.SizeMode = PictureBoxSizeMode.Zoom;
            bntFechar.TabIndex = 5;
            bntFechar.TabStop = false;
            bntFechar.Click += bntFechar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ckbUsuario);
            panel1.Controls.Add(pnlUsuario);
            panel1.Controls.Add(txtUF);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtBairro);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtCidade);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnCEP);
            panel1.Controls.Add(txtCEP);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtTelefone);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCPF);
            panel1.Controls.Add(txtLogradouro);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 293);
            panel1.TabIndex = 4;
            // 
            // ckbUsuario
            // 
            ckbUsuario.AutoSize = true;
            ckbUsuario.Location = new Point(30, 153);
            ckbUsuario.Name = "ckbUsuario";
            ckbUsuario.Size = new Size(101, 19);
            ckbUsuario.TabIndex = 18;
            ckbUsuario.Text = "Dados usuário";
            ckbUsuario.UseVisualStyleBackColor = true;
            ckbUsuario.CheckedChanged += ckbUsuario_CheckedChanged;
            // 
            // pnlUsuario
            // 
            pnlUsuario.Controls.Add(btnVisualizarConfirmacao);
            pnlUsuario.Controls.Add(btnVisualizarSenha);
            pnlUsuario.Controls.Add(txtSenhaConfirm);
            pnlUsuario.Controls.Add(label12);
            pnlUsuario.Controls.Add(txtSenha);
            pnlUsuario.Controls.Add(label11);
            pnlUsuario.Controls.Add(txtEMail);
            pnlUsuario.Controls.Add(label10);
            pnlUsuario.Enabled = false;
            pnlUsuario.Location = new Point(30, 178);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(768, 109);
            pnlUsuario.TabIndex = 17;
            // 
            // btnVisualizarConfirmacao
            // 
            btnVisualizarConfirmacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVisualizarConfirmacao.Image = Properties.Resources.eyefehcado;
            btnVisualizarConfirmacao.Location = new Point(720, 70);
            btnVisualizarConfirmacao.Name = "btnVisualizarConfirmacao";
            btnVisualizarConfirmacao.Size = new Size(45, 29);
            btnVisualizarConfirmacao.SizeMode = PictureBoxSizeMode.CenterImage;
            btnVisualizarConfirmacao.TabIndex = 11;
            btnVisualizarConfirmacao.TabStop = false;
            btnVisualizarConfirmacao.Click += btnVisualizarConfirmacao_Click;
            // 
            // btnVisualizarSenha
            // 
            btnVisualizarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVisualizarSenha.Image = Properties.Resources.eyefehcado;
            btnVisualizarSenha.Location = new Point(282, 70);
            btnVisualizarSenha.Name = "btnVisualizarSenha";
            btnVisualizarSenha.Size = new Size(44, 29);
            btnVisualizarSenha.SizeMode = PictureBoxSizeMode.CenterImage;
            btnVisualizarSenha.TabIndex = 10;
            btnVisualizarSenha.TabStop = false;
            btnVisualizarSenha.Click += btnVisualizarSenha_Click;
            // 
            // txtSenhaConfirm
            // 
            txtSenhaConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenhaConfirm.Location = new Point(491, 70);
            txtSenhaConfirm.MaxLength = 12;
            txtSenhaConfirm.Name = "txtSenhaConfirm";
            txtSenhaConfirm.Size = new Size(222, 29);
            txtSenhaConfirm.TabIndex = 11;
            txtSenhaConfirm.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(324, 76);
            label12.Name = "label12";
            label12.Size = new Size(170, 21);
            label12.TabIndex = 6;
            label12.Text = "Confirmação de Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(71, 70);
            txtSenha.MaxLength = 12;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(207, 29);
            txtSenha.TabIndex = 10;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(14, 73);
            label11.Name = "label11";
            label11.Size = new Size(56, 21);
            label11.TabIndex = 4;
            label11.Text = "Senha:";
            // 
            // txtEMail
            // 
            txtEMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEMail.Location = new Point(71, 23);
            txtEMail.Name = "txtEMail";
            txtEMail.Size = new Size(694, 29);
            txtEMail.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(14, 31);
            label10.Name = "label10";
            label10.Size = new Size(51, 21);
            label10.TabIndex = 2;
            label10.Text = "Email:";
            // 
            // txtUF
            // 
            txtUF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUF.Location = new Point(734, 99);
            txtUF.MaxLength = 2;
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(64, 29);
            txtUF.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(696, 102);
            label9.Name = "label9";
            label9.Size = new Size(32, 21);
            label9.TabIndex = 15;
            label9.Text = "UF:";
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBairro.Location = new Point(91, 102);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(265, 29);
            txtBairro.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(30, 107);
            label8.Name = "label8";
            label8.Size = new Size(55, 21);
            label8.TabIndex = 13;
            label8.Text = "Bairro:";
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCidade.Location = new Point(438, 99);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(238, 29);
            txtCidade.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(371, 107);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 11;
            label7.Text = "Cidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(225, 62);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 10;
            label6.Text = "Logradouro:";
            // 
            // btnCEP
            // 
            btnCEP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCEP.Image = Properties.Resources._5402443_16;
            btnCEP.Location = new Point(190, 59);
            btnCEP.Name = "btnCEP";
            btnCEP.Size = new Size(29, 29);
            btnCEP.SizeMode = PictureBoxSizeMode.CenterImage;
            btnCEP.TabIndex = 9;
            btnCEP.TabStop = false;
            btnCEP.Click += btnCEP_Click;
            // 
            // txtCEP
            // 
            txtCEP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCEP.Location = new Point(91, 59);
            txtCEP.Mask = "00,000,000";
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(93, 29);
            txtCEP.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 67);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 7;
            label5.Text = "CEP:";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.Location = new Point(668, 15);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(130, 29);
            txtTelefone.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(592, 23);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 5;
            label4.Text = "Telefone:";
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCPF.Location = new Point(455, 15);
            txtCPF.Mask = "000,000,000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(131, 29);
            txtCPF.TabIndex = 2;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogradouro.Location = new Point(326, 54);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(472, 29);
            txtLogradouro.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(409, 23);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(91, 16);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(312, 29);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(16, 26, 40);
            label2.Location = new Point(30, 12);
            label2.Name = "label2";
            label2.Size = new Size(199, 32);
            label2.TabIndex = 3;
            label2.Text = "Cadastro Pessoa";
            // 
            // frmCrudPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 422);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCrudPessoa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmCrudPessoa";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bntFechar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnVisualizarConfirmacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVisualizarSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCEP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private MaskedTextBox txtCPF;
        private TextBox txtLogradouro;
        private Label label3;
        private MaskedTextBox txtTelefone;
        private Label label4;
        private MaskedTextBox txtCEP;
        private Label label5;
        private Label label6;
        private PictureBox btnCEP;
        private PictureBox bntFechar;
        private Panel pnlUsuario;
        private TextBox txtUF;
        private Label label9;
        private TextBox txtBairro;
        private Label label8;
        private TextBox txtCidade;
        private Label label7;
        private CheckBox ckbUsuario;
        private TextBox txtSenha;
        private Label label11;
        private TextBox txtEMail;
        private Label label10;
        private TextBox txtSenhaConfirm;
        private Label label12;
        private Button btnSalvar;
        private Button btnCancelar;
        private PictureBox btnVisualizarConfirmacao;
        private PictureBox btnVisualizarSenha;
    }
}