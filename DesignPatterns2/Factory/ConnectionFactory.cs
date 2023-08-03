using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns2.Cap1
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User ID=root; Password=; Serve=localhost; Database=meuBanco";
            conexao.Open();

            return conexao;
        }
    }
}
