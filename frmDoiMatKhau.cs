using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ứng_dụng_QLSV
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtXacNhanMatKhau.Text;
            if (string.Equals(newPassword, confirmPassword) == true)
            {
                string connectionString = @"Data Source=DESKTOP-5H6J6H1\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Users SET Password = @Password WHERE Username = @Username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Password", newPassword);
                        command.Parameters.AddWithValue("@Username", username);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu thất bại. Vui lòng thử lại.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp. Vui lòng thử lại.");
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
