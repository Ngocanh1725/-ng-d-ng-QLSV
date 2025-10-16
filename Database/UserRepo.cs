using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Ứng_dụng_QLSV.Database
{
    internal class UserRepo
    {
        //Lấy ra cái role của users đăng nhập vào hệ thống
        public string validateLogin(string username = "", string password = "")
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();//Mở kết nối
                string sql = @"Select Role from Users where";
                sql += @"Username = @username and PasswordHash = @password and TrangThai = 1";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }
    }
}
