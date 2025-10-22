using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ứng_dụng_QLSV
{
    public partial class frmMain : Form
    {
        private string currentUserRole; // Biến để lưu trữ Role

        // Constructor mặc định
        public frmMain()
        {
            InitializeComponent();
            this.currentUserRole = "Unknown"; // Gán một giá trị mặc định
        }

        // Constructor mới để nhận Role từ frmLogin
        public frmMain(string userRole)
        {
            InitializeComponent();
            this.currentUserRole = userRole;

            // Tùy chọn: Hiển thị role trên thanh tiêu đề của frmMain
            this.Text = $"Chương trình Quản lý Sinh viên (User Role: {this.currentUserRole})";

            // --- VÍ DỤ PHÂN QUYỀN ---
            // Bạn có thể ẩn/hiện các menu item dựa trên role ở đây
            // Ví dụ: Chỉ "Teacher" mới thấy Quản lý điểm
            // if (this.currentUserRole != "Teacher")
            // {
            //     quảnLýĐiểmToolStripMenuItem1.Visible = false;
            // }

            // Ví dụ: "Student" không thấy các mục quản lý
            // if (this.currentUserRole == "Student")
            // {
            //     quảnLýChungToolStripMenuItem.Visible = false;
            // }
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoa f = new frmQuanLyKhoa();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyLop f = new frmQuanLyLop();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySinhVien f = new frmQuanLySinhVien();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýCốVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyCoVan f = new frmQuanLyCoVan();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDiem f = new frmQuanLyDiem();
            f.MdiParent = this;
            f.Show();
        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            // Cân nhắc hiển thị lại frmLogin sau khi đăng xuất
            // Application.OpenForms["frmLogin"]?.Show();
        }
    }
}
