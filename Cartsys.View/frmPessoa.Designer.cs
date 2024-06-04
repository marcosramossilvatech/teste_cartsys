namespace Cartsys.View
{
    partial class frmPessoa
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
            dgvDados = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Apagar = new DataGridViewImageColumn();
            Nome = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            CEP = new DataGridViewTextBoxColumn();
            Logradouro = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Cidade = new DataGridViewTextBoxColumn();
            Bairro = new DataGridViewTextBoxColumn();
            UF = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            pnlCentral = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            txtPesquisa = new TextBox();
            cbbTipoPesquisa = new ComboBox();
            bntPesquisar = new Button();
            btnAdd = new Button();
            panel1 = new Panel();
            bntFechar = new PictureBox();
            label1 = new Label();
            Senha = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            pnlCentral.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bntFechar).BeginInit();
            SuspendLayout();
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvDados.BackgroundColor = SystemColors.Window;
            dgvDados.BorderStyle = BorderStyle.Fixed3D;
            dgvDados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDados.Columns.AddRange(new DataGridViewColumn[] { Editar, Apagar, Nome, CPF, CEP, Logradouro, Telefone, Cidade, Bairro, UF, Email });
            dgvDados.Location = new Point(0, 0);
            dgvDados.MultiSelect = false;
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDados.RowHeadersVisible = false;
            dgvDados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvDados.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvDados.Size = new Size(1070, 506);
            dgvDados.TabIndex = 4;
            // 
            // Editar
            // 
            Editar.Frozen = true;
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources.edite;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Width = 43;
            // 
            // Apagar
            // 
            Apagar.Frozen = true;
            Apagar.HeaderText = "Apagar";
            Apagar.Image = Properties.Resources.delete;
            Apagar.Name = "Apagar";
            Apagar.ReadOnly = true;
            Apagar.Width = 51;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.DataPropertyName = "Nome";
            Nome.FillWeight = 150F;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Resizable = DataGridViewTriState.True;
            // 
            // CPF
            // 
            CPF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CPF.DataPropertyName = "CPF";
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            CPF.ReadOnly = true;
            // 
            // CEP
            // 
            CEP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CEP.DataPropertyName = "CEP";
            CEP.HeaderText = "CEP";
            CEP.Name = "CEP";
            CEP.ReadOnly = true;
            // 
            // Logradouro
            // 
            Logradouro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Logradouro.DataPropertyName = "Logradouro";
            Logradouro.HeaderText = "Logradouro";
            Logradouro.Name = "Logradouro";
            Logradouro.ReadOnly = true;
            // 
            // Telefone
            // 
            Telefone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Telefone.DataPropertyName = "Telefone";
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            // 
            // Cidade
            // 
            Cidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cidade.DataPropertyName = "Cidade";
            Cidade.HeaderText = "Cidade";
            Cidade.Name = "Cidade";
            Cidade.ReadOnly = true;
            // 
            // Bairro
            // 
            Bairro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Bairro.DataPropertyName = "Bairro";
            Bairro.HeaderText = "Bairro";
            Bairro.Name = "Bairro";
            Bairro.ReadOnly = true;
            // 
            // UF
            // 
            UF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UF.DataPropertyName = "UF";
            UF.HeaderText = "UF";
            UF.Name = "UF";
            UF.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // pnlCentral
            // 
            pnlCentral.Controls.Add(button1);
            pnlCentral.Controls.Add(panel3);
            pnlCentral.Controls.Add(label2);
            pnlCentral.Controls.Add(panel2);
            pnlCentral.Controls.Add(panel1);
            pnlCentral.Dock = DockStyle.Fill;
            pnlCentral.ForeColor = Color.FromArgb(0, 64, 0);
            pnlCentral.Location = new Point(0, 0);
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Size = new Size(1116, 688);
            pnlCentral.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources._9024683_20;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(935, 97);
            button1.Name = "button1";
            button1.Size = new Size(159, 35);
            button1.TabIndex = 5;
            button1.Text = "ExportaExcel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(dgvDados);
            panel3.Location = new Point(24, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(1070, 506);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(16, 26, 40);
            label2.Location = new Point(24, 100);
            label2.Name = "label2";
            label2.Size = new Size(247, 32);
            label2.TabIndex = 2;
            label2.Text = "Listagem de pessoas";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(txtPesquisa);
            panel2.Controls.Add(cbbTipoPesquisa);
            panel2.Controls.Add(bntPesquisar);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(1116, 48);
            panel2.TabIndex = 1;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPesquisa.Font = new Font("Segoe UI", 12F);
            txtPesquisa.Location = new Point(743, 10);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(186, 29);
            txtPesquisa.TabIndex = 7;
            // 
            // cbbTipoPesquisa
            // 
            cbbTipoPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbTipoPesquisa.Font = new Font("Segoe UI", 12F);
            cbbTipoPesquisa.FormattingEnabled = true;
            cbbTipoPesquisa.Items.AddRange(new object[] { "Todos", "Nome", "CPF", "Cidade" });
            cbbTipoPesquisa.Location = new Point(616, 10);
            cbbTipoPesquisa.Name = "cbbTipoPesquisa";
            cbbTipoPesquisa.Size = new Size(121, 29);
            cbbTipoPesquisa.TabIndex = 6;
            cbbTipoPesquisa.SelectedIndexChanged += cbbTipoPesquisa_SelectedIndexChanged;
            // 
            // bntPesquisar
            // 
            bntPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntPesquisar.BackColor = Color.FromArgb(192, 192, 0);
            bntPesquisar.Enabled = false;
            bntPesquisar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            bntPesquisar.FlatStyle = FlatStyle.Flat;
            bntPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntPesquisar.ForeColor = Color.White;
            bntPesquisar.Image = Properties.Resources._3669475_24;
            bntPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            bntPesquisar.Location = new Point(935, 6);
            bntPesquisar.Name = "bntPesquisar";
            bntPesquisar.Size = new Size(159, 35);
            bntPesquisar.TabIndex = 5;
            bntPesquisar.Text = "Pesquisar";
            bntPesquisar.UseVisualStyleBackColor = false;
            bntPesquisar.Click += bntPesquisar_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 64, 0);
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = Properties.Resources._3669475_24;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(33, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(159, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(bntFechar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 43);
            panel1.TabIndex = 0;
            // 
            // bntFechar
            // 
            bntFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntFechar.BackColor = Color.DarkRed;
            bntFechar.Image = Properties.Resources._4213411_cancel_circle_close_delete_remove_icon;
            bntFechar.Location = new Point(1067, 9);
            bntFechar.Name = "bntFechar";
            bntFechar.Size = new Size(27, 26);
            bntFechar.SizeMode = PictureBoxSizeMode.Zoom;
            bntFechar.TabIndex = 4;
            bntFechar.TabStop = false;
            bntFechar.Click += bntFechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(16, 26, 40);
            label1.Location = new Point(24, 8);
            label1.Name = "label1";
            label1.Size = new Size(318, 32);
            label1.TabIndex = 0;
            label1.Text = "Gerenciamento de Pessoas";
            // 
            // Senha
            // 
            Senha.DataPropertyName = "Senha";
            Senha.Frozen = true;
            Senha.HeaderText = "Senha";
            Senha.Name = "Senha";
            Senha.Visible = false;
            Senha.Width = 64;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.DataPropertyName = "Id";
            Id.Frozen = true;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 5;
            // 
            // frmPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 688);
            Controls.Add(pnlCentral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPessoa";
            Text = "frmPessoa";
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            pnlCentral.ResumeLayout(false);
            pnlCentral.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bntFechar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCentral;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button bntPesquisar;
        private Button btnAdd;
        private TextBox txtPesquisa;
        private ComboBox cbbTipoPesquisa;
        private PictureBox bntFechar;
        private Label label2;
        private Panel panel3;
        private DataGridView dgvDados;
        private DataGridViewTextBoxColumn Senha;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Apagar;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn Logradouro;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn Bairro;
        private DataGridViewTextBoxColumn UF;
        private DataGridViewTextBoxColumn Email;
        private Button button1;
    }
}