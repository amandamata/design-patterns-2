using DesignPatterns2.Cap1;
using System.Data;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection connection = new ConnectionFactory().GetConnection();
            IDbCommand command = connection.CreateCommand();
            command.CommandText = "select * from table";
        }
    }
}
