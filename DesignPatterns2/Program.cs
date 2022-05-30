using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection connection = new SqlConnection();
            connection.ConnectionString = "User Id=root;Password=;Server=localhost;Database=myDB";
            connection.Open();
            IDbCommand command = connection.CreateCommand();
            command.CommandText = "select * from table";
        }
    }
}
