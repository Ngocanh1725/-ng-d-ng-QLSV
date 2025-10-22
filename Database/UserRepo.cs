using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ứng_dụng_QLSV.Databases;

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

                // Sửa đổi truy vấn để lấy 'Role' từ bảng 'Users'
                // (Giả định bảng của bạn là 'Users' và có các cột 'Username', 'PasswordHash', 'Role', 'TrangThai')
                string sql = @"Select Role from Users where";
                // Cập nhật tên cột cho phù hợp với bảng 'Users' của bạn
                // THÊM LẠI ĐIỀU KIỆN KIỂM TRA TRẠNG THÁI (TrangThai = 1)
                sql += @" Username = @username and PasswordHash = @password and TrangThai = 1";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Cân nhắc đổi tên @password thành @passwordHash nếu cần
                    object result = cmd.ExecuteScalar();
                    return result?.ToString(); // Trả về Role (dưới dạng string) hoặc null nếu không tìm thấy
                }
            }
        }
    }
}


