using Cartsys.Domain.Entities;
using Cartsys.Domain.Interfaces;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Cartsys.Infrastructure.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly string _connectionString;

        public PessoaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<Pessoa> AdicionarPessoaAdmin(Pessoa pessoa)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    var existingEmail = await connection.QueryFirstOrDefaultAsync<int>(
                        @"SELECT COUNT(*) FROM Pessoas WHERE Email = @Email",
                        new { Email = pessoa.Email }
                    );

                    if (existingEmail == 0)
                    {
                        await connection.ExecuteAsync(
                            @"INSERT INTO Pessoas (Nome, CPF, CEP, Logradouro, Telefone, Bairro, Cidade, UF, Email, Senha, DataCadastro, DataAlteracao, Status) 
                            VALUES (@Nome, @CPF, @CEP, @Logradouro, @Telefone, @Bairro, @Cidade, @UF, @Email, @Senha, @DataCadastro, @DataAlteracao, @Status)",
                            pessoa
                        );
                    }
                    else
                    {
                        return pessoa;
                    }
                }

                return pessoa;
            }
            catch (Exception)
            {
                return new Pessoa();
            }
        }

        public async Task<Pessoa> AdicionarPessoaAsync(Pessoa pessoa)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.ExecuteAsync(
                        @"INSERT INTO Pessoas (Nome, CPF, CEP,Logradouro, Telefone, Bairro, Cidade, UF, Email, Senha, DataCadastro, DataAlteracao, Status) 
                           VALUES (@Nome, @CPF, @CEP, @Logradouro, @Telefone, @Bairro, @Cidade, @UF, @Email, @Senha, @DataCadastro, @DataAlteracao, @Status)",
                        pessoa
                    );
                }

                return pessoa;
            }
            catch (Exception)
            {
                return new Pessoa();
            }
        }

        public async Task<Pessoa> ALterarPessoaAsync(Pessoa pessoa)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.ExecuteAsync(
                        @"UPDATE Pessoas 
                    SET Nome = @Nome, 
                        CPF = @CPF, 
                        CEP = @CEP, 
                        Logradouro = @Logradouro, 
                        Telefone = @Telefone, 
                        Bairro = @Bairro, 
                        Cidade = @Cidade, 
                        UF = @UF, 
                        Email = @Email, 
                        Senha = @Senha, 
                        DataAlteracao = @DataAlteracao, 
                        Status = @Status
                    WHERE Id = @Id",
                        pessoa
                    );
                }

                return pessoa;
            }
            catch (Exception)
            {
                return new Pessoa();
            }
        }

        public async Task<bool> DeletarPessoa(int id)
        {
            try
            {
                using IDbConnection db = new SqlConnection(_connectionString);
                var retorno = await db.ExecuteAsync("DELETE FROM Pessoas WHERE Id = @Id", new { Id = id });

                return retorno > 0;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public async Task<Pessoa> RetornaPessoaPeloEmail(string email)
        {
            try
            {
                using IDbConnection db = new SqlConnection(_connectionString);


                var retorno = await db.QueryAsync<Pessoa>("SELECT * FROM Pessoas where email LIKE @Valor", new { Valor = email });

                return retorno.FirstOrDefault();
            }
            catch (Exception)
            {
                return new Pessoa();
            }
        }

        public async Task<Pessoa> RetornaPessoaPeloId(int id)
        {
            try
            {
                using IDbConnection db = new SqlConnection(_connectionString);


                var retorno = await db.QueryAsync<Pessoa>("SELECT Id , Nome, CPF, CEP, Logradouro, Telefone, Bairro, Cidade, UF, Email, DataCadastro, DataAlteracao, Status FROM Pessoas WHERE id = @Valor", new { Valor = id });

                return retorno.FirstOrDefault();
            }
            catch (Exception)
            {
                return new Pessoa();
            }
        }

        public async Task<IEnumerable<Pessoa>> RetornaPessoas()
        {
            try
            {
                using IDbConnection db = new SqlConnection(_connectionString);
                var retorno = await db.QueryAsync<Pessoa>("SELECT Id , Nome, CPF, CEP, Telefone, Logradouro, Bairro, Cidade, UF, Email, DataCadastro, DataAlteracao, Status FROM Pessoas");
                return retorno;
            }
            catch (Exception)
            {
                return new List<Pessoa>();
            }

        }

        public async Task<IEnumerable<Pessoa>> RetornaPessoasPorFIltro(ETipoFiltro tipo, string valor)
        {
            try
            {
                using IDbConnection db = new SqlConnection(_connectionString); 
                string consulta = "";


                switch (tipo)
                {
                    case ETipoFiltro.Todos:
                        consulta = "SELECT * FROM Pessoas";
                        break;

                    case ETipoFiltro.Nome:
                        consulta = "SELECT * FROM Pessoas WHERE Nome LIKE @Valor";
                        break;
                    case ETipoFiltro.CPF:
                        consulta = "SELECT * FROM Pessoas WHERE CPF = @Valor";
                        break;
                    case ETipoFiltro.Cidade:
                        consulta = "SELECT * FROM Pessoas WHERE Cidade = @Valor";
                        break;
                    default:
                        consulta = "SELECT * FROM Pessoas";
                        break;
                }

                var retorno = await db.QueryAsync<Pessoa>(consulta, new { Valor = valor });

                return retorno;
            }
            catch (Exception)
            {
                return new List<Pessoa>();
            }
        }
    }
}
