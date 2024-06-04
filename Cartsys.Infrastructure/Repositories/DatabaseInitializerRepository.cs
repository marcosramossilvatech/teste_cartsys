using Cartsys.Domain.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace Cartsys.Infrastructure.Repositories
{
    public class DatabaseInitializerRepository : IDatabaseInitializerRepository
    {
        private const string CreateDatabaseScript = @"
                             USE dbcartsys;

                           -- Create table Pessoas if it doesn't exist
                            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Pessoas')
                            BEGIN
                                CREATE TABLE Pessoas (
                                    Id INT NOT NULL IDENTITY(1,1),
                                    Nome VARCHAR(100) NOT NULL,
                                    CPF VARCHAR(20) NOT NULL,
                                    CEP VARCHAR(20),
                                    Logradouro VARCHAR(50),
                                    Telefone VARCHAR(20),
                                    Bairro VARCHAR(100),
                                    Cidade VARCHAR(100),
                                    UF CHAR(2),
                                    Email VARCHAR(100) NOT NULL,
                                    Senha VARCHAR(100) NOT NULL,
                                    DataCadastro DATETIME NOT NULL DEFAULT GETDATE(),
                                    DataAlteracao DATETIME NOT NULL DEFAULT GETDATE(),
                                    Status BIT NOT NULL DEFAULT 1,
                                    PRIMARY KEY (Id)
                                );
                            END
                            ";

        private readonly string _connectionString;

        public DatabaseInitializerRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private bool CriandoBancoSeNaoExiste()
        {
            try
            {
                string local = _connectionString;

                var splitlocal = local.Split(';');
                string nomeBanco = "";
                string caminhoBancoDeDados = "";
                if (splitlocal.Length > 2)
                {
                    local = $"{splitlocal[0]};{splitlocal[2]};{splitlocal[3]};";
                    nomeBanco = splitlocal[1].Replace("Initial Catalog=", "");
                }
               

                using (var connection = new SqlConnection(local))
                {

                    connection.Open();

                    string query = @"
                                IF EXISTS (
                                    SELECT 1
                                    FROM sys.databases
                                    WHERE name = @DatabaseName
                                )
                                    SELECT 1 AS DatabaseExists;
                                ELSE
                                    SELECT 0 AS DatabaseExists;
                            ";

                    int result = connection.QueryFirstOrDefault<int>(query, new { DatabaseName = nomeBanco });

                    if (result == 0)
                    {
                        string createDatabaseQuery1 = $"CREATE DATABASE {nomeBanco}";
                        connection.Execute(createDatabaseQuery1);
                    }

                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool InitializeDatabase()
        {

            bool bancoCriado = CriandoBancoSeNaoExiste();

            if (bancoCriado)
            {
                bool tabela = CriandoTabela();
                return tabela;
            }

            return bancoCriado;
        }

        private bool CriandoTabela()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(CreateDatabaseScript, connection);
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    // Log the exception (optional)
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
