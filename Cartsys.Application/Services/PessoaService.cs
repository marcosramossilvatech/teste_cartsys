using Cartsys.Domain.Entities;
using Cartsys.Domain.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using OfficeOpenXml;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cartsys.Applications.Services
{
    public class PessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IValidator<Pessoa> _pessoaValidator;
        public PessoaService(IPessoaRepository pessoaRepository,
                             IValidator<Pessoa> pessoaValidator)
        {
            _pessoaRepository = pessoaRepository;
            _pessoaValidator = pessoaValidator;
        }

        public async Task<Pessoa> CadastrarPessoa(Pessoa pessoa)
        {
            ValidationResult result = _pessoaValidator.Validate(pessoa);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
            var retorno = await _pessoaRepository.AdicionarPessoaAsync(pessoa);
            return retorno;
        }
        public async Task<Pessoa> AdicionarPessoaAdmin(Pessoa pessoa)
        {
            var retorno = await _pessoaRepository.AdicionarPessoaAdmin(pessoa);
            return retorno;

        }
        public async Task<Pessoa> AlterarPessoa(Pessoa pessoa)
        {
            ValidationResult result = _pessoaValidator.Validate(pessoa);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
            var retorno = await _pessoaRepository.ALterarPessoaAsync(pessoa);
            return retorno;
        }
        public async Task<Pessoa> ObterPessoaPorIdAsync(int id)
        {
            var retorno = await _pessoaRepository.RetornaPessoaPeloId(id);
            return retorno;
        }
        public async Task<Pessoa> ObterPessoaPorEmail(string email)
        {
            var retorno = await _pessoaRepository.RetornaPessoaPeloEmail(email);
            return retorno;
        }

        public async Task<IEnumerable<Pessoa>> RetornaPessoasPorFIltro(ETipoFiltro tipo, string valor)
        {
            var retorno = await _pessoaRepository.RetornaPessoasPorFIltro(tipo, valor);
            return retorno;
        }
        public async Task<IEnumerable<Pessoa>> ObterTodasPessoasAsync()
        {
            var retorno = await _pessoaRepository.RetornaPessoas();
            return retorno;
        }

        public async Task<bool> DeletarPessoasAsync(int id)
        {
            var retorno = await _pessoaRepository.DeletarPessoa(id);
            return retorno;
        }

        public void GerarExcel(List<Pessoa>lista, string local)
        {
            using (var stream = new MemoryStream())
            {
                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets.Add("Pessoas");


                    var rowAux = 0;

                    var cabecalho = new List<object[]>
                    {
                        new object[] { "Nome", "CPF" ,"CEP", "Logradouro","Telefone","Cidade",
                                       "Bairro","UF","Email" }
                    };

                    rowAux++;
                    for (var colHeader = 1; colHeader <= cabecalho[0].Length; colHeader++)
                    {
                        worksheet.Cells[rowAux, colHeader].Value = cabecalho[0][colHeader - 1];
                    }
                    rowAux += 1;
                    foreach (var item in lista)
                    {
                        worksheet.Cells[rowAux, 1].Value = item.Nome;
                        worksheet.Cells[rowAux, 2].Value = item.CPF;
                        worksheet.Cells[rowAux, 3].Value = item.CEP;
                        worksheet.Cells[rowAux, 4].Value = item.Logradouro;
                        worksheet.Cells[rowAux, 5].Value = item.Telefone;
                        worksheet.Cells[rowAux, 6].Value = item.Cidade;
                        worksheet.Cells[rowAux, 7].Value = item.Bairro;
                        worksheet.Cells[rowAux, 8].Value = item.UF;
                        worksheet.Cells[rowAux, 9].Value = item.Email;
                        rowAux++;
                    }

                    worksheet.Cells.AutoFitColumns();

                    package.Save();

                    using (var fileStream = new FileStream($@"{local}\arquivo.xlsx", FileMode.Create))
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fileStream);
                    }
                }
            }
        }
    }
}
