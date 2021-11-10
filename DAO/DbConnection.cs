using System.Data.SqlClient;

namespace ProjetoN2.DAO
{
    public class DbConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=tcp:DESKTOP-S82QJ10; DATABASE=volareN2; user id=sa; password=123456";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}