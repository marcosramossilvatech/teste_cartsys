using Cartsys.Domain.Entities;
using System.Collections.Generic;

namespace Cartsys.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        Task<Pessoa> AdicionarPessoaAsync(Pessoa pessoa);
        Task<Pessoa> AdicionarPessoaAdmin(Pessoa pessoa);
        Task<Pessoa> ALterarPessoaAsync(Pessoa pessoa);
        Task<Pessoa> RetornaPessoaPeloId(int id);
        Task<IEnumerable<Pessoa>> RetornaPessoas();
        Task<Pessoa> RetornaPessoaPeloEmail(string email);
        Task<bool> DeletarPessoa(int id);
        Task<IEnumerable<Pessoa>> RetornaPessoasPorFIltro(ETipoFiltro tipo, string valor);
    }
}
