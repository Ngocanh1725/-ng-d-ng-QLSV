using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_QLSV.Database
{
    internal class DBHelper
    {
        private static readonly string connectionString = @"Data Source=ADMIN-PC;Initial Catalog=QuanLySV;Integrated Security=True"; // Chuỗi kết nối đến cơ sở dữ liệu SQL Server
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
