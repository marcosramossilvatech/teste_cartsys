using Cartsys.Applications.Services;
using Cartsys.Domain.Entities;
using Cartsys.Domain.Validators;
using Cartsys.Infrastructure;
using Cartsys.Infrastructure.Repositories;

namespace Cartsys.View
{
    public partial class frmCrudPessoa : Form
    {
        private readonly PessoaService _pessoaService;
        private readonly CepService _cepService;
        private int idLocal = 0;

        public frmCrudPessoa(Pessoa? pessoa = null)
        {
            InitializeComponent();
            var connectionString = Database.GetConnectionString();
            var personRepository = new PessoaRepository(connectionString);
            var pessoaValidator = new PessoaValidator();
            _pessoaService = new PessoaService(personRepository, pessoaValidator);

            HttpClient _httpClient = new HttpClient();
            _cepService = new CepService(_httpClient);
            idLocal = 0;
            if (pessoa != null)
            {
                idLocal = pessoa.Id;
                PreencheCampos(pessoa);
            }
        }

        private void PreencheCampos(Pessoa pessoa)
        {
            txtNome.Text = pessoa.Nome;
            txtCPF.Text = pessoa.CPF;
            txtCEP.Text = pessoa.CEP;
            txtTelefone.Text = pessoa.Telefone;
            txtLogradouro.Text = pessoa.Logradouro;
            txtBairro.Text = pessoa.Bairro;
            txtCidade.Text = pessoa.Cidade;
            txtUF.Text = pessoa.UF;
            txtEMail.Text = pessoa.Email;
            txtSenha.Text = pessoa.Senha;
            txtSenhaConfirm.Text = pessoa.Senha;
            ckbUsuario.Checked = !string.IsNullOrEmpty(pessoa.Email);
        }

        private void bntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            pnlUsuario.Enabled = ckbUsuario.Checked;
        }

        private void btnVisualizarSenha_Click(object sender, EventArgs e)
        {
            ExibirSenha(txtSenha, btnVisualizarSenha);
        }

        private void btnVisualizarConfirmacao_Click(object sender, EventArgs e)
        {
            ExibirSenha(txtSenhaConfirm, btnVisualizarConfirmacao);
        }
        private void ExibirSenha(TextBox txt, PictureBox btn)
        {
            if (txt.UseSystemPasswordChar)
            {
                btn.Image = Properties.Resources.eyeaberto;
                txt.UseSystemPasswordChar = false;
            }
            else
            {
                btn.Image = Properties.Resources.eyefehcado;
                txt.UseSystemPasswordChar = true;
            }
        }
        private async Task SalvarPessoaAsync()
        {
            Pessoa novaPessoa = new Pessoa(
                txtNome.Text,
                txtCPF.Text,
                txtCEP.Text,
                txtLogradouro.Text,
                txtTelefone.Text,
                txtBairro.Text,
                txtCidade.Text,
                txtUF.Text,
                txtEMail.Text,
                txtSenha.Text,
                txtSenhaConfirm.Text
            );

            try
            {
                if (idLocal == 0)
                    await _pessoaService.CadastrarPessoa(novaPessoa);
                else
                {
                    novaPessoa.Id = idLocal;
                    novaPessoa.DataAlteracao = DateTime.Now;
                    await _pessoaService.AlterarPessoa(novaPessoa);
                }
                MessageBox.Show("Gravado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void LimparTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control controle in controles)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Clear();
                }
                else if (controle is MaskedTextBox)
                {
                    ((MaskedTextBox)controle).Clear();
                }
                else if (controle.Controls.Count > 0)
                {
                    LimparTextBoxes(controle.Controls);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            SalvarPessoaAsync();
            LimparTextBoxes(this.Controls);
        }

        private async void btnCEP_Click(object sender, EventArgs e)
        {
            var cep = await _cepService.ConsultarCepAsync(txtCEP.Text);

            if (cep != null && cep.Cep != null)
            {
                txtLogradouro.Text = cep.Logradouro.ToString();
                txtBairro.Text = cep.Bairro.ToString();
                txtCidade.Text = cep.Localidade.ToString();
                txtUF.Text = cep.Uf;
            }
            else
            {
                MessageBox.Show("Busca por CEP não retornou nenhum valor!");
            }
        }
    }
}
