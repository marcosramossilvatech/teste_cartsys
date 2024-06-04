using Cartsys.Applications.Services;
using Cartsys.Domain.Entities;
using Cartsys.Domain.Validators;
using Cartsys.Infrastructure;
using Cartsys.Infrastructure.Repositories;
using System.Windows.Forms;

namespace Cartsys.View
{
    public partial class frmPessoa : Form
    {
        private readonly PessoaService _pessoaService;
        private List<Pessoa> pessoaList;
        public frmPessoa()
        {
            pessoaList = new List<Pessoa>();
            InitializeComponent();
            dgvDados.CellClick += DgvDados_CellClick;
            cbbTipoPesquisa.SelectedIndexChanged += CbbTipoPesquisa_SelectedIndexChanged;
            var connectionString = Database.GetConnectionString();
            var personRepository = new PessoaRepository(connectionString);
            var pessoaValidator = new PessoaValidator();
            _pessoaService = new PessoaService(personRepository, pessoaValidator);
            BuscaPessoas();
        }

        private void CbbTipoPesquisa_SelectedIndexChanged(object? sender, EventArgs e)
        {
            bntPesquisar.Enabled = !string.IsNullOrEmpty(cbbTipoPesquisa.Text);
        }

        private void DgvDados_CellClick(object? sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    int valorCelula = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[13].Value);
                    var pessoa = pessoaList.FirstOrDefault(x => x.Id == valorCelula);
                    EditarPessoa(pessoa);
                }
                else if (e.ColumnIndex == 1)
                {
                    int valorCelula = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[13].Value);
                    DeletarPessoa(valorCelula);
                }

            }
        }

        private void EditarPessoa(Pessoa? pessoa)
        {
            frmCrudPessoa frmpessoa = new frmCrudPessoa(pessoa);
            frmpessoa.ShowDialog();
            BuscaPessoas();
        }

        private async void DeletarPessoa(int id)
        {
            var retorno = await _pessoaService.DeletarPessoasAsync(id);
            if (retorno)
                MessageBox.Show("Excluido com sucesso!");
            else
                MessageBox.Show("Erro ao excluir pessoa!");

            BuscaPessoas();
        }

        private async void BuscaPessoas()
        {
            pessoaList = (List<Pessoa>)await _pessoaService.ObterTodasPessoasAsync();
            PreencherGrid(pessoaList);
        }
        private void cbbTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCrudPessoa pessoa = new frmCrudPessoa();
            pessoa.ShowDialog();
            BuscaPessoas();
        }

        private void bntPesquisar_Click(object sender, EventArgs e)
        {
            var filtro = cbbTipoPesquisa.Text;
            FiltrarAsync(filtro);
        }

        private async Task FiltrarAsync(string filtro)
        {
            ETipoFiltro filtroEnum = new ETipoFiltro();
            if (Enum.TryParse(filtro, out ETipoFiltro tipoFiltro))
            {
                switch (tipoFiltro)
                {
                    case ETipoFiltro.Nome:
                        filtroEnum = ETipoFiltro.Nome;
                        break;
                    case ETipoFiltro.CPF:
                        filtroEnum = ETipoFiltro.CPF;
                        break;
                    case ETipoFiltro.Cidade:
                        filtroEnum = ETipoFiltro.CPF;
                        break;
                }
            }
            pessoaList = (List<Pessoa>)await _pessoaService.RetornaPessoasPorFIltro(filtroEnum, txtPesquisa.Text);
            PreencherGrid(pessoaList);

        }

        private void PreencherGrid(List<Pessoa> pessoas)
        {

            dgvDados.DataSource = pessoas;
            dgvDados.Refresh();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
             FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Selecione a pasta onde deseja salvar o arquivo Excel.";
            folderBrowserDialog.ShowNewFolderButton = true;

            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    _pessoaService.GerarExcel(pessoaList, folderBrowserDialog.SelectedPath);
                    MessageBox.Show("Exportado com sucesso!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro na exportação!");
                }

            }
                
        }
    }
}
