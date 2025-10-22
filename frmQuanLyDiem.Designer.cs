using System;
using System.Windows.Forms;
namespace Ứng_dụng_QLSV
{
    partial class frmQuanLyDiem : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private GroupBox grpNhapDiem;
        private TextBox txtDiemThi;
        private TextBox txtDiemLop;
        private NumericUpDown numPTramThi;
        private NumericUpDown numPTramLop;
        private ComboBox cboMonHoc;
        private TextBox txtMaSV;
        private Label lblDiemThi;
        private Label lblDiemLop;
        private Label lblPTramThi;
        private Label lblPTramLop;
        private Label lblMonHoc;
        private Label lblMaSV;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dgvDiem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýChungToolStripMenuItem;
        private ToolStripMenuItem quảnLýKhoaToolStripMenuItem;
        private ToolStripMenuItem quảnLýLớpToolStripMenuItem;
        private ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýCốVấnToolStripMenuItem;
        private ToolStripMenuItem quảnLýĐiểmToolStripMenuItem1;

        // ================= SỬA LỖI TẠI ĐÂY =================
        // Đổi tên biến của cột từ 'Name' thành 'colXepLoai' để tránh xung đột
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn colXepLoai; // Đã đổi tên
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        // ======================================================

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpNhapDiem = new System.Windows.Forms.GroupBox();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.txtDiemLop = new System.Windows.Forms.TextBox();
            this.numPTramThi = new System.Windows.Forms.NumericUpDown();
            this.numPTramLop = new System.Windows.Forms.NumericUpDown();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblDiemThi = new System.Windows.Forms.Label();
            this.lblDiemLop = new System.Windows.Forms.Label();
            this.lblPTramThi = new System.Windows.Forms.Label();
            this.lblPTramLop = new System.Windows.Forms.Label();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýCốVấnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐiểmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();

            // ================= SỬA LỖI TẠI ĐÂY =================
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXepLoai = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Đã đổi tên
            // ======================================================

            this.grpNhapDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPTramThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPTramLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(736, 49);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "QUẢN LÍ ĐIỂM SV";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpNhapDiem
            // 
            this.grpNhapDiem.Controls.Add(this.txtDiemThi);
            this.grpNhapDiem.Controls.Add(this.txtDiemLop);
            this.grpNhapDiem.Controls.Add(this.numPTramThi);
            this.grpNhapDiem.Controls.Add(this.numPTramLop);
            this.grpNhapDiem.Controls.Add(this.cboMonHoc);
            this.grpNhapDiem.Controls.Add(this.txtMaSV);
            this.grpNhapDiem.Controls.Add(this.lblDiemThi);
            this.grpNhapDiem.Controls.Add(this.lblDiemLop);
            this.grpNhapDiem.Controls.Add(this.lblPTramThi);
            this.grpNhapDiem.Controls.Add(this.lblPTramLop);
            this.grpNhapDiem.Controls.Add(this.lblMonHoc);
            this.grpNhapDiem.Controls.Add(this.lblMaSV);
            this.grpNhapDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpNhapDiem.Location = new System.Drawing.Point(9, 81);
            this.grpNhapDiem.Margin = new System.Windows.Forms.Padding(2);
            this.grpNhapDiem.Name = "grpNhapDiem";
            this.grpNhapDiem.Padding = new System.Windows.Forms.Padding(2);
            this.grpNhapDiem.Size = new System.Drawing.Size(262, 276);
            this.grpNhapDiem.TabIndex = 5;
            this.grpNhapDiem.TabStop = false;
            this.grpNhapDiem.Text = "Nhập Điểm";
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(98, 236);
            this.txtDiemThi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(151, 23);
            this.txtDiemThi.TabIndex = 11;
            // 
            // txtDiemLop
            // 
            this.txtDiemLop.Location = new System.Drawing.Point(98, 195);
            this.txtDiemLop.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiemLop.Name = "txtDiemLop";
            this.txtDiemLop.Size = new System.Drawing.Size(151, 23);
            this.txtDiemLop.TabIndex = 10;
            // 
            // numPTramThi
            // 
            this.numPTramThi.Location = new System.Drawing.Point(98, 154);
            this.numPTramThi.Margin = new System.Windows.Forms.Padding(2);
            this.numPTramThi.Name = "numPTramThi";
            this.numPTramThi.Size = new System.Drawing.Size(150, 23);
            this.numPTramThi.TabIndex = 9;
            // 
            // numPTramLop
            // 
            this.numPTramLop.Location = new System.Drawing.Point(98, 114);
            this.numPTramLop.Margin = new System.Windows.Forms.Padding(2);
            this.numPTramLop.Name = "numPTramLop";
            this.numPTramLop.Size = new System.Drawing.Size(150, 23);
            this.numPTramLop.TabIndex = 8;
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(98, 73);
            this.cboMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(151, 24);
            this.cboMonHoc.TabIndex = 7;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(98, 32);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(151, 23);
            this.txtMaSV.TabIndex = 6;
            // 
            // lblDiemThi
            // 
            this.lblDiemThi.AutoSize = true;
            this.lblDiemThi.Location = new System.Drawing.Point(11, 238);
            this.lblDiemThi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiemThi.Name = "lblDiemThi";
            this.lblDiemThi.Size = new System.Drawing.Size(68, 17);
            this.lblDiemThi.TabIndex = 5;
            this.lblDiemThi.Text = "Điểm Thi:";
            // 
            // lblDiemLop
            // 
            this.lblDiemLop.AutoSize = true;
            this.lblDiemLop.Location = new System.Drawing.Point(11, 197);
            this.lblDiemLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiemLop.Name = "lblDiemLop";
            this.lblDiemLop.Size = new System.Drawing.Size(72, 17);
            this.lblDiemLop.TabIndex = 4;
            this.lblDiemLop.Text = "Điểm Lớp:";
            // 
            // lblPTramThi
            // 
            this.lblPTramThi.AutoSize = true;
            this.lblPTramThi.Location = new System.Drawing.Point(11, 156);
            this.lblPTramThi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPTramThi.Name = "lblPTramThi";
            this.lblPTramThi.Size = new System.Drawing.Size(82, 17);
            this.lblPTramThi.TabIndex = 3;
            this.lblPTramThi.Text = "P.Trăm Thi:";
            // 
            // lblPTramLop
            // 
            this.lblPTramLop.AutoSize = true;
            this.lblPTramLop.Location = new System.Drawing.Point(11, 115);
            this.lblPTramLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPTramLop.Name = "lblPTramLop";
            this.lblPTramLop.Size = new System.Drawing.Size(86, 17);
            this.lblPTramLop.TabIndex = 2;
            this.lblPTramLop.Text = "P.Trăm Lớp:";
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(11, 76);
            this.lblMonHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(68, 17);
            this.lblMonHoc.TabIndex = 1;
            this.lblMonHoc.Text = "Môn Học:";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(11, 35);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(95, 17);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã Sinh Viên:";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.Location = new System.Drawing.Point(19, 366);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(68, 28);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.Location = new System.Drawing.Point(109, 366);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 28);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.Location = new System.Drawing.Point(199, 366);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 28);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dgvDiem
            // 
            this.dgvDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // ================= SỬA LỖI TẠI ĐÂY =================
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.colXepLoai}); // Đã đổi tên
            // ======================================================

            this.dgvDiem.Location = new System.Drawing.Point(285, 81);
            this.dgvDiem.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.Size = new System.Drawing.Size(442, 380);
            this.dgvDiem.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Phần trăm lớp";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phần trăm thi";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Điểm trên lớp";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Điểm thi";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Điểm trung bình";
            this.Column6.Name = "Column6";

            // ================= SỬA LỖI TẠI ĐÂY =================
            // 
            // colXepLoai
            // 
            this.colXepLoai.HeaderText = "Xếp loại";
            this.colXepLoai.Name = "colXepLoai"; // Thuộc tính Name của cột có thể giữ nguyên, chỉ cần tên biến khác
            // ======================================================

            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýChungToolStripMenuItem,
            this.quảnLýĐiểmToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýChungToolStripMenuItem
            // 
            this.quảnLýChungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKhoaToolStripMenuItem,
            this.quảnLýLớpToolStripMenuItem,
            this.quảnLýSinhViênToolStripMenuItem,
            this.quảnLýCốVấnToolStripMenuItem});
            this.quảnLýChungToolStripMenuItem.Name = "quảnLýChungToolStripMenuItem";
            this.quảnLýChungToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.quảnLýChungToolStripMenuItem.Text = "Quản lý chung";
            // 
            // quảnLýKhoaToolStripMenuItem
            // 
            this.quảnLýKhoaToolStripMenuItem.Name = "quảnLýKhoaToolStripMenuItem";
            this.quảnLýKhoaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.quảnLýKhoaToolStripMenuItem.Text = "Quản lý Khoa";
            this.quảnLýKhoaToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKhoaToolStripMenuItem_Click);
            // 
            // quảnLýLớpToolStripMenuItem
            // 
            this.quảnLýLớpToolStripMenuItem.Name = "quảnLýLớpToolStripMenuItem";
            this.quảnLýLớpToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.quảnLýLớpToolStripMenuItem.Text = "Quản lý Lớp";
            this.quảnLýLớpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLớpToolStripMenuItem_Click);
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Quản lý Sinh viên";
            this.quảnLýSinhViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSinhViênToolStripMenuItem_Click);
            // 
            // quảnLýCốVấnToolStripMenuItem
            // 
            this.quảnLýCốVấnToolStripMenuItem.Name = "quảnLýCốVấnToolStripMenuItem";
            this.quảnLýCốVấnToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.quảnLýCốVấnToolStripMenuItem.Text = "Quản lý Cố vấn";
            this.quảnLýCốVấnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýCốVấnToolStripMenuItem_Click);
            // 
            // quảnLýĐiểmToolStripMenuItem1
            // 
            this.quảnLýĐiểmToolStripMenuItem1.Name = "quảnLýĐiểmToolStripMenuItem1";
            this.quảnLýĐiểmToolStripMenuItem1.Size = new System.Drawing.Size(90, 20);
            this.quảnLýĐiểmToolStripMenuItem1.Text = "Quản lý điểm";
            this.quảnLýĐiểmToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýĐiểmToolStripMenuItem_Click);
            // 
            // frmQuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 474);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grpNhapDiem);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyDiem";
            this.Text = "Bảng Điểm Sinh Viên";
            this.grpNhapDiem.ResumeLayout(false);
            this.grpNhapDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPTramThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPTramLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
