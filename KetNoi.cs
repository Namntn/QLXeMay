using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLXeMay
{
    internal class KetNoi
    {
         public static SqlConnection connectDB()
        {
            // Chuỗi kết nối tới cơ sở dữ liệu SQL Server
            string chuoi = @"Data Source=NAMNGUYEN\SQLEXPRESS;Initial Catalog=QLXeMay;Integrated Security=True;TrustServerCertificate=True;";

            // Tạo đối tượng SqlConnection
            SqlConnection con = new SqlConnection(chuoi);
            return con;
        }
    }
}
