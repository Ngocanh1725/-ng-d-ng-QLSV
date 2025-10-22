using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_QLSV.Databases
{
    internal class DBHelper
    {
        private static readonly string connectionString = Properties.Settings.Default.connectionString; // Chuỗi kết nối đến cơ sở dữ liệu SQL Server
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
