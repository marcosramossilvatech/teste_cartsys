using System.Configuration;

namespace Cartsys.Infrastructure
{
    public class Database
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        }
    }
}
