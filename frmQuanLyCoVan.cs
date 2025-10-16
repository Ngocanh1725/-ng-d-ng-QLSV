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
    public partial class frmQuanLyCoVan : Form
    {
        public frmQuanLyCoVan()
        {
            InitializeComponent();
        }
        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoa f = new frmQuanLyKhoa();
            if (this.MdiParent != null) f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyLop f = new frmQuanLyLop();
            if (this.MdiParent != null) f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySinhVien f = new frmQuanLySinhVien();
            if (this.MdiParent != null) f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void quảnLýCốVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Do nothing, this is the current form
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDiem f = new frmQuanLyDiem();
            if (this.MdiParent != null) f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null) this.MdiParent.Close();
        }

        private void quảnLýChungToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grpThongTin_Enter(object sender, EventArgs e)
        {

        }
    }
}
