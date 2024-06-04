using Cartsys.Applications.Services;
using Cartsys.Infrastructure.Repositories;
using Cartsys.Infrastructure;
using Cartsys.Domain.Entities;
using Cartsys.Domain.Validators;

namespace Cartsys.View
{
    public partial class frmLogin : Form
    {
        private readonly PessoaService _pessoaService;
        private readonly DatabaseInitializerService _DatabaseInitializerService;
        private bool Sucesso = false;

        public Pessoa _usuario;
        public frmLogin()
        {
            var connectionString = Database.GetConnectionString();
            var personRepository = new PessoaRepository(connectionString);
            var databaseInitializerRepository = new DatabaseInitializerRepository(connectionString);
            _usuario = new Pessoa();
            var pessoaValidator = new PessoaValidator();
            _pessoaService = new PessoaService(personRepository, pessoaValidator);
            _DatabaseInitializerService = new DatabaseInitializerService(databaseInitializerRepository);

            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVisualizarSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar)
            {
                btnVisualizarSenha.Image = Properties.Resources.eyeaberto;
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                btnVisualizarSenha.Image = Properties.Resources.eyefehcado;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text) ||
               string.IsNullOrEmpty(txtEmai.Text))
            {
                MessageBox.Show("Favor informar os dados para acesso!");
                return;
            }
            LogarAsync();
        }

        private async Task LogarAsync()
        {
            var pessoa = await _pessoaService.ObterPessoaPorEmail(txtEmai.Text);

            if ((pessoa == null) ||
                (pessoa.Senha != txtSenha.Text))
            {
                MessageBox.Show("Dados incorretos!");
                return;
            }
            this.Hide();
            frmPrincipal frm = new frmPrincipal(pessoa);
            frm.Show();
        }

        private async void frmLogin_Load(object sender, EventArgs e)
        {
            Sucesso = _DatabaseInitializerService.InitializeDatabase();
            if (Sucesso)
            {
                Pessoa pessoaAdmin = new Pessoa("Admin teste", "000.000.000-00", "00.000.000",
                                                 " ",""," "," "," ", "admin@admin.com", "123456", "123456");
                await _pessoaService.AdicionarPessoaAdmin(pessoaAdmin);
            }
            else
            {
                MessageBox.Show("Erro ao criar banco e registro inicial!");
            }
        }
    }
}
