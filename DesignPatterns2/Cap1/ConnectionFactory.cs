using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns2.Cap1
{
    class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection connection = new SqlConnection();
            connection.ConnectionString = "User Id=root;Password=;Server=localhost;Database=myDB";
            connection.Open();
            return connection;
        }
    }
}
