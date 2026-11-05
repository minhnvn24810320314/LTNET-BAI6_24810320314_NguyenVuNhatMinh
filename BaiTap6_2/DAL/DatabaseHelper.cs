using Microsoft.Data.SqlClient;

namespace BaiTap6_2.DAL
{
    public class DatabaseHelper
    {
        public static string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=HRMDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}