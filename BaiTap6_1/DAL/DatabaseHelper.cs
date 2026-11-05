using Microsoft.Data.SqlClient;

namespace BaiTap6_1.DAL
{
    public class DatabaseHelper
    {
        // Chuỗi kết nối đến SQL Server (sử dụng TrustServerCertificate=True để tránh lỗi chứng chỉ)
        public static string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=SalesDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}