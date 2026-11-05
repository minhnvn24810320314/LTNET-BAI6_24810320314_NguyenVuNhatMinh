namespace BaiTap6_2.GUI
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNhanSu = new System.Windows.Forms.TabPage();
            this.grpNhanVien = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.tabChamCong = new System.Windows.Forms.TabPage();
            this.btnLuuChamCong = new System.Windows.Forms.Button();
            this.btnTaiChamCong = new System.Windows.Forms.Button();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.tabTinhLuong = new System.Windows.Forms.TabPage();
            this.btnChotLuong = new System.Windows.Forms.Button();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabNhanSu.SuspendLayout();
            this.grpNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tabChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.tabTinhLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNhanSu);
            this.tabControl1.Controls.Add(this.tabChamCong);
            this.tabControl1.Controls.Add(this.tabTinhLuong);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // tabNhanSu
            // 
            this.tabNhanSu.Controls.Add(this.grpNhanVien);
            this.tabNhanSu.Location = new System.Drawing.Point(4, 26);
            this.tabNhanSu.Name = "tabNhanSu";
            this.tabNhanSu.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanSu.Size = new System.Drawing.Size(976, 581);
            this.tabNhanSu.TabIndex = 0;
            this.tabNhanSu.Text = "1. Quản lý Hồ sơ Nhân sự";
            this.tabNhanSu.UseVisualStyleBackColor = true;
            // 
            // grpNhanVien
            // 
            this.grpNhanVien.Controls.Add(this.dgvNhanVien);
            this.grpNhanVien.Controls.Add(this.btnTimKiem);
            this.grpNhanVien.Controls.Add(this.txtTimKiem);
            this.grpNhanVien.Controls.Add(this.lblTimKiem);
            this.grpNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNhanVien.Location = new System.Drawing.Point(3, 3);
            this.grpNhanVien.Name = "grpNhanVien";
            this.grpNhanVien.Size = new System.Drawing.Size(970, 575);
            this.grpNhanVien.TabIndex = 0;
            this.grpNhanVien.TabStop = false;
            this.grpNhanVien.Text = "Danh sách Nhân viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(15, 70);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(940, 485);
            this.dgvNhanVien.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(520, 27);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(200, 30);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 25);
            this.txtTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(15, 33);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(175, 19);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm theo Tên/CCCD/Phòng:";
            // 
            // tabChamCong
            // 
            this.tabChamCong.Controls.Add(this.btnLuuChamCong);
            this.tabChamCong.Controls.Add(this.btnTaiChamCong);
            this.tabChamCong.Controls.Add(this.dgvChamCong);
            this.tabChamCong.Controls.Add(this.txtNam);
            this.tabChamCong.Controls.Add(this.lblNam);
            this.tabChamCong.Controls.Add(this.cboThang);
            this.tabChamCong.Controls.Add(this.lblThang);
            this.tabChamCong.Location = new System.Drawing.Point(4, 28);
            this.tabChamCong.Name = "tabChamCong";
            this.tabChamCong.Padding = new System.Windows.Forms.Padding(3);
            this.tabChamCong.Size = new System.Drawing.Size(976, 579);
            this.tabChamCong.TabIndex = 1;
            this.tabChamCong.Text = "2. Chấm công ngắt kết nối (Disconnected)";
            this.tabChamCong.UseVisualStyleBackColor = true;
            // 
            // btnLuuChamCong
            // 
            this.btnLuuChamCong.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLuuChamCong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuuChamCong.ForeColor = System.Drawing.Color.White;
            this.btnLuuChamCong.Location = new System.Drawing.Point(620, 20);
            this.btnLuuChamCong.Name = "btnLuuChamCong";
            this.btnLuuChamCong.Size = new System.Drawing.Size(170, 35);
            this.btnLuuChamCong.TabIndex = 6;
            this.btnLuuChamCong.Text = "Lưu Chấm Công (Update)";
            this.btnLuuChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuuChamCong.UseVisualStyleBackColor = false;
            this.btnLuuChamCong.Click += new System.EventHandler(this.btnLuuChamCong_Click);
            // 
            // btnTaiChamCong
            // 
            this.btnTaiChamCong.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTaiChamCong.ForeColor = System.Drawing.Color.White;
            this.btnTaiChamCong.Location = new System.Drawing.Point(440, 20);
            this.btnTaiChamCong.Name = "btnTaiChamCong";
            this.btnTaiChamCong.Size = new System.Drawing.Size(170, 35);
            this.btnTaiChamCong.TabIndex = 5;
            this.btnTaiChamCong.Text = "Tải Bảng Chấm Công";
            this.btnTaiChamCong.UseVisualStyleBackColor = false;
            this.btnTaiChamCong.Click += new System.EventHandler(this.btnTaiChamCong_Click);
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Location = new System.Drawing.Point(15, 75);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.Size = new System.Drawing.Size(940, 480);
            this.dgvChamCong.TabIndex = 4;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(310, 25);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 25);
            this.txtNam.TabIndex = 3;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(255, 28);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(41, 19);
            this.lblNam.TabIndex = 2;
            this.lblNam.Text = "Năm:";
            // 
            // cboThang
            // 
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "Tháng 01", "Tháng 02", "Tháng 03", "Tháng 04", "Tháng 05", "Tháng 06",
            "Tháng 07", "Tháng 08", "Tháng 09", "Tháng 10", "Tháng 11", "Tháng 12"});
            this.cboThang.Location = new System.Drawing.Point(80, 25);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(150, 25);
            this.cboThang.TabIndex = 1;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(20, 28);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(50, 19);
            this.lblThang.TabIndex = 0;
            this.lblThang.Text = "Tháng:";
            // 
            // tabTinhLuong
            // 
            this.tabTinhLuong.Controls.Add(this.btnChotLuong);
            this.tabTinhLuong.Controls.Add(this.dgvBangLuong);
            this.tabTinhLuong.Location = new System.Drawing.Point(4, 28);
            this.tabTinhLuong.Name = "tabTinhLuong";
            this.tabTinhLuong.Padding = new System.Windows.Forms.Padding(3);
            this.tabTinhLuong.Size = new System.Drawing.Size(976, 579);
            this.tabTinhLuong.TabIndex = 2;
            this.tabTinhLuong.Text = "3. Tính Lương & Chốt Lương (SqlTransaction)";
            this.tabTinhLuong.UseVisualStyleBackColor = true;
            // 
            // btnChotLuong
            // 
            this.btnChotLuong.BackColor = System.Drawing.Color.Crimson;
            this.btnChotLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChotLuong.ForeColor = System.Drawing.Color.White;
            this.btnChotLuong.Location = new System.Drawing.Point(20, 20);
            this.btnChotLuong.Name = "btnChotLuong";
            this.btnChotLuong.Size = new System.Drawing.Size(300, 50);
            this.btnChotLuong.TabIndex = 1;
            this.btnChotLuong.Text = "CHỐT LƯƠNG THÁNG (SqlTransaction)";
            this.btnChotLuong.UseVisualStyleBackColor = false;
            this.btnChotLuong.Click += new System.EventHandler(this.btnChotLuong_Click);
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangLuong.Location = new System.Drawing.Point(20, 90);
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.Size = new System.Drawing.Size(935, 465);
            this.dgvBangLuong.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Nhân sự & Tính lương (Bài 6.2)";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabNhanSu.ResumeLayout(false);
            this.grpNhanVien.ResumeLayout(false);
            this.grpNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tabChamCong.ResumeLayout(false);
            this.tabChamCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.tabTinhLuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNhanSu;
        private System.Windows.Forms.TabPage tabChamCong;
        private System.Windows.Forms.TabPage tabTinhLuong;
        private System.Windows.Forms.GroupBox grpNhanVien;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Button btnTaiChamCong;
        private System.Windows.Forms.Button btnLuuChamCong;
        private System.Windows.Forms.Button btnChotLuong;
        private System.Windows.Forms.DataGridView dgvBangLuong;
    }
}