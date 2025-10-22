using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Ứng_dụng_QLSV;
using Ứng_dụng_QLSV.Database;

namespace QuanLySinhVien
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Sử dụng UserRepo để kiểm tra đăng nhập và lấy Role
                UserRepo userRepo = new UserRepo();
                string role = userRepo.validateLogin(username, password);

                // 2. Kiểm tra kết quả
                if (!string.IsNullOrEmpty(role))
                {
                    // Đăng nhập thành công
                    // 3. Hiển thị thông báo thành công với Role
                    MessageBox.Show($"Đăng nhập thành công - Role: {role}",
                                    "Đăng nhập thành công",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    this.Hide();
                    // 4. Truyền Role cho frmMain
                    frmMain mainForm = new frmMain(role);
                    mainForm.Show();
                }
                else
                {
                    // Đăng nhập thất bại
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Thêm xử lý lỗi nếu cột 'Role' không tồn tại trong CSDL
                if (ex.Message.ToLower().Contains("invalid column name 'role'"))
                {
                    MessageBox.Show("Lỗi: Không tìm thấy cột 'Role' trong bảng 'Users'. Vui lòng kiểm tra CSDL.", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Xử lý lỗi nếu tên bảng 'Users' không đúng
                else if (ex.Message.ToLower().Contains("invalid object name 'users'"))
                {
                    MessageBox.Show("Lỗi: Không tìm thấy bảng 'Users'. Vui lòng kiểm tra CSDL.", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

