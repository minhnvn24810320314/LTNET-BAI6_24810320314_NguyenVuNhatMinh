namespace BaiTap6_1.GUI
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabDanhMuc = new System.Windows.Forms.TabPage();
            this.grpSanPham = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.grpKhachHang = new System.Windows.Forms.GroupBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.grpNhanVien = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tabBanHang = new System.Windows.Forms.TabPage();
            this.grpThongTinHoaDon = new System.Windows.Forms.GroupBox();
            this.lblDiemTichLuyTamTinh = new System.Windows.Forms.Label();
            this.lblDiemText = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongTienText = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.grpGioHang = new System.Windows.Forms.GroupBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.grpChonSanPham = new System.Windows.Forms.GroupBox();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.nudSoLuongBan = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.lblChonSP = new System.Windows.Forms.Label();
            this.tabBaoCao = new System.Windows.Forms.TabPage();
            this.grpTop5 = new System.Windows.Forms.GroupBox();
            this.btnTop5BanChay = new System.Windows.Forms.Button();
            this.dgvTop5SanPham = new System.Windows.Forms.DataGridView();
            this.grpDoanhThu = new System.Windows.Forms.GroupBox();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblDoanhThuText = new System.Windows.Forms.Label();
            this.btnThongKeDoanhThu = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabDanhMuc.SuspendLayout();
            this.grpSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.grpKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.grpNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tabBanHang.SuspendLayout();
            this.grpThongTinHoaDon.SuspendLayout();
            this.grpGioHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.grpChonSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBan)).BeginInit();
            this.tabBaoCao.SuspendLayout();
            this.grpTop5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5SanPham)).BeginInit();
            this.grpDoanhThu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabDanhMuc);
            this.tabControlMain.Controls.Add(this.tabBanHang);
            this.tabControlMain.Controls.Add(this.tabBaoCao);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1008, 661);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabDanhMuc
            // 
            this.tabDanhMuc.Controls.Add(this.grpSanPham);
            this.tabDanhMuc.Controls.Add(this.grpKhachHang);
            this.tabDanhMuc.Controls.Add(this.grpNhanVien);
            this.tabDanhMuc.Location = new System.Drawing.Point(4, 28);
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanhMuc.Size = new System.Drawing.Size(1000, 629);
            this.tabDanhMuc.TabIndex = 0;
            this.tabDanhMuc.Text = "1. Quản lý Danh mục & Tìm kiếm";
            this.tabDanhMuc.UseVisualStyleBackColor = true;
            // 
            // grpSanPham
            // 
            this.grpSanPham.Controls.Add(this.btnLamMoi);
            this.grpSanPham.Controls.Add(this.btnTimKiem);
            this.grpSanPham.Controls.Add(this.txtTimKiem);
            this.grpSanPham.Controls.Add(this.lblTimKiem);
            this.grpSanPham.Controls.Add(this.dgvSanPham);
            this.grpSanPham.Location = new System.Drawing.Point(8, 6);
            this.grpSanPham.Name = "grpSanPham";
            this.grpSanPham.Size = new System.Drawing.Size(984, 300);
            this.grpSanPham.TabIndex = 0;
            this.grpSanPham.TabStop = false;
            this.grpSanPham.Text = "Danh mục Sản phẩm (Tìm kiếm an toàn với SqlParameter %)";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(630, 27);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 30);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTimKiem.Location = new System.Drawing.Point(520, 27);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(180, 30);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(330, 25);
            this.txtTimKiem.TabIndex = 2;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(15, 33);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(159, 19);
            this.lblTimKiem.TabIndex = 1;
            this.lblTimKiem.Text = "Tìm theo Mã/Tên SP (%):";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(15, 68);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(954, 218);
            this.dgvSanPham.TabIndex = 0;
            // 
            // grpKhachHang
            // 
            this.grpKhachHang.Controls.Add(this.dgvKhachHang);
            this.grpKhachHang.Location = new System.Drawing.Point(8, 312);
            this.grpKhachHang.Name = "grpKhachHang";
            this.grpKhachHang.Size = new System.Drawing.Size(485, 305);
            this.grpKhachHang.TabIndex = 1;
            this.grpKhachHang.TabStop = false;
            this.grpKhachHang.Text = "Danh sách Khách hàng";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(3, 21);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(479, 281);
            this.dgvKhachHang.TabIndex = 0;
            // 
            // grpNhanVien
            // 
            this.grpNhanVien.Controls.Add(this.dgvNhanVien);
            this.grpNhanVien.Location = new System.Drawing.Point(507, 312);
            this.grpNhanVien.Name = "grpNhanVien";
            this.grpNhanVien.Size = new System.Drawing.Size(485, 305);
            this.grpNhanVien.TabIndex = 2;
            this.grpNhanVien.TabStop = false;
            this.grpNhanVien.Text = "Danh sách Nhân viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 21);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(479, 281);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // tabBanHang
            // 
            this.tabBanHang.Controls.Add(this.grpThongTinHoaDon);
            this.tabBanHang.Controls.Add(this.grpGioHang);
            this.tabBanHang.Controls.Add(this.grpChonSanPham);
            this.tabBanHang.Location = new System.Drawing.Point(4, 28);
            this.tabBanHang.Name = "tabBanHang";
            this.tabBanHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabBanHang.Size = new System.Drawing.Size(1000, 629);
            this.tabBanHang.TabIndex = 1;
            this.tabBanHang.Text = "2. Màn hình Bán hàng (SqlTransaction)";
            this.tabBanHang.UseVisualStyleBackColor = true;
            // 
            // grpThongTinHoaDon
            // 
            this.grpThongTinHoaDon.Controls.Add(this.lblDiemTichLuyTamTinh);
            this.grpThongTinHoaDon.Controls.Add(this.lblDiemText);
            this.grpThongTinHoaDon.Controls.Add(this.lblTongTien);
            this.grpThongTinHoaDon.Controls.Add(this.lblTongTienText);
            this.grpThongTinHoaDon.Controls.Add(this.btnThanhToan);
            this.grpThongTinHoaDon.Controls.Add(this.cboKhachHang);
            this.grpThongTinHoaDon.Controls.Add(this.lblKhachHang);
            this.grpThongTinHoaDon.Controls.Add(this.cboNhanVien);
            this.grpThongTinHoaDon.Controls.Add(this.lblNhanVien);
            this.grpThongTinHoaDon.Location = new System.Drawing.Point(620, 100);
            this.grpThongTinHoaDon.Name = "grpThongTinHoaDon";
            this.grpThongTinHoaDon.Size = new System.Drawing.Size(370, 520);
            this.grpThongTinHoaDon.TabIndex = 2;
            this.grpThongTinHoaDon.TabStop = false;
            this.grpThongTinHoaDon.Text = "Thông tin Hóa đơn & Thanh toán";
            // 
            // lblDiemTichLuyTamTinh
            // 
            this.lblDiemTichLuyTamTinh.AutoSize = true;
            this.lblDiemTichLuyTamTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiemTichLuyTamTinh.ForeColor = System.Drawing.Color.Blue;
            this.lblDiemTichLuyTamTinh.Location = new System.Drawing.Point(150, 220);
            this.lblDiemTichLuyTamTinh.Name = "lblDiemTichLuyTamTinh";
            this.lblDiemTichLuyTamTinh.Size = new System.Drawing.Size(65, 21);
            this.lblDiemTichLuyTamTinh.TabIndex = 8;
            this.lblDiemTichLuyTamTinh.Text = "0 điểm";
            // 
            // lblDiemText
            // 
            this.lblDiemText.AutoSize = true;
            this.lblDiemText.Location = new System.Drawing.Point(20, 222);
            this.lblDiemText.Name = "lblDiemText";
            this.lblDiemText.Size = new System.Drawing.Size(126, 19);
            this.lblDiemText.TabIndex = 7;
            this.lblDiemText.Text = "Điểm tích lũy cộng:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(145, 165);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(81, 30);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // lblTongTienText
            // 
            this.lblTongTienText.AutoSize = true;
            this.lblTongTienText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTongTienText.Location = new System.Drawing.Point(20, 172);
            this.lblTongTienText.Name = "lblTongTienText";
            this.lblTongTienText.Size = new System.Drawing.Size(112, 21);
            this.lblTongTienText.TabIndex = 5;
            this.lblTongTienText.Text = "Tổng tiền mặt:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(20, 290);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(330, 60);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "THANH TOÁN (SqlTransaction)";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(150, 100);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(200, 27);
            this.cboKhachHang.TabIndex = 3;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(20, 103);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(117, 19);
            this.lblKhachHang.TabIndex = 2;
            this.lblKhachHang.Text = "Chọn Khách hàng:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(150, 45);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(200, 27);
            this.cboNhanVien.TabIndex = 1;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(20, 48);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(107, 19);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "Nhân viên bán:";
            // 
            // grpGioHang
            // 
            this.grpGioHang.Controls.Add(this.dgvGioHang);
            this.grpGioHang.Location = new System.Drawing.Point(8, 100);
            this.grpGioHang.Name = "grpGioHang";
            this.grpGioHang.Size = new System.Drawing.Size(600, 520);
            this.grpGioHang.TabIndex = 1;
            this.grpGioHang.TabStop = false;
            this.grpGioHang.Text = "Giỏ hàng hiện tại";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.Location = new System.Drawing.Point(3, 21);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.Size = new System.Drawing.Size(594, 496);
            this.dgvGioHang.TabIndex = 0;
            // 
            // grpChonSanPham
            // 
            this.grpChonSanPham.Controls.Add(this.btnThemVaoGio);
            this.grpChonSanPham.Controls.Add(this.nudSoLuongBan);
            this.grpChonSanPham.Controls.Add(this.lblSoLuong);
            this.grpChonSanPham.Controls.Add(this.txtDonGiaBan);
            this.grpChonSanPham.Controls.Add(this.lblDonGia);
            this.grpChonSanPham.Controls.Add(this.cboSanPham);
            this.grpChonSanPham.Controls.Add(this.lblChonSP);
            this.grpChonSanPham.Location = new System.Drawing.Point(8, 6);
            this.grpChonSanPham.Name = "grpChonSanPham";
            this.grpChonSanPham.Size = new System.Drawing.Size(982, 85);
            this.grpChonSanPham.TabIndex = 0;
            this.grpChonSanPham.TabStop = false;
            this.grpChonSanPham.Text = "Chọn sản phẩm mua";
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThemVaoGio.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoGio.Location = new System.Drawing.Point(830, 31);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(130, 35);
            this.btnThemVaoGio.TabIndex = 6;
            this.btnThemVaoGio.Text = "+ Thêm vào giỏ";
            this.btnThemVaoGio.UseVisualStyleBackColor = false;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            // 
            // nudSoLuongBan
            // 
            this.nudSoLuongBan.Location = new System.Drawing.Point(720, 36);
            this.nudSoLuongBan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuongBan.Name = "nudSoLuongBan";
            this.nudSoLuongBan.Size = new System.Drawing.Size(80, 25);
            this.nudSoLuongBan.TabIndex = 5;
            this.nudSoLuongBan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(645, 38);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(66, 19);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.ReadOnly = true;
            this.txtDonGiaBan.Location = new System.Drawing.Point(495, 35);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(130, 25);
            this.txtDonGiaBan.TabIndex = 3;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(430, 38);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(60, 19);
            this.lblDonGia.TabIndex = 2;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // cboSanPham
            // 
            this.cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(125, 34);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(285, 27);
            this.cboSanPham.TabIndex = 1;
            this.cboSanPham.SelectedIndexChanged += new System.EventHandler(this.cboSanPham_SelectedIndexChanged);
            // 
            // lblChonSP
            // 
            this.lblChonSP.AutoSize = true;
            this.lblChonSP.Location = new System.Drawing.Point(15, 38);
            this.lblChonSP.Name = "lblChonSP";
            this.lblChonSP.Size = new System.Drawing.Size(107, 19);
            this.lblChonSP.TabIndex = 0;
            this.lblChonSP.Text = "Chọn sản phẩm:";
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Controls.Add(this.grpTop5);
            this.tabBaoCao.Controls.Add(this.grpDoanhThu);
            this.tabBaoCao.Location = new System.Drawing.Point(4, 28);
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaoCao.Size = new System.Drawing.Size(1000, 629);
            this.tabBaoCao.TabIndex = 2;
            this.tabBaoCao.Text = "3. Báo cáo - Thống kê";
            this.tabBaoCao.UseVisualStyleBackColor = true;
            // 
            // grpTop5
            // 
            this.grpTop5.Controls.Add(this.btnTop5BanChay);
            this.grpTop5.Controls.Add(this.dgvTop5SanPham);
            this.grpTop5.Location = new System.Drawing.Point(8, 185);
            this.grpTop5.Name = "grpTop5";
            this.grpTop5.Size = new System.Drawing.Size(984, 435);
            this.grpTop5.TabIndex = 1;
            this.grpTop5.TabStop = false;
            this.grpTop5.Text = "Top 5 Sản phẩm bán chạy nhất (Dùng SqlDataReader)";
            // 
            // btnTop5BanChay
            // 
            this.btnTop5BanChay.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTop5BanChay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTop5BanChay.ForeColor = System.Drawing.Color.White;
            this.btnTop5BanChay.Location = new System.Drawing.Point(15, 30);
            this.btnTop5BanChay.Name = "btnTop5BanChay";
            this.btnTop5BanChay.Size = new System.Drawing.Size(250, 40);
            this.btnTop5BanChay.TabIndex = 1;
            this.btnTop5BanChay.Text = "Xem Top 5 SP Bán Chạy";
            this.btnTop5BanChay.UseVisualStyleBackColor = false;
            this.btnTop5BanChay.Click += new System.EventHandler(this.btnTop5BanChay_Click);
            // 
            // dgvTop5SanPham
            // 
            this.dgvTop5SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTop5SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop5SanPham.Location = new System.Drawing.Point(15, 80);
            this.dgvTop5SanPham.Name = "dgvTop5SanPham";
            this.dgvTop5SanPham.Size = new System.Drawing.Size(954, 338);
            this.dgvTop5SanPham.TabIndex = 0;
            // 
            // grpDoanhThu
            // 
            this.grpDoanhThu.Controls.Add(this.lblTongDoanhThu);
            this.grpDoanhThu.Controls.Add(this.lblDoanhThuText);
            this.grpDoanhThu.Controls.Add(this.btnThongKeDoanhThu);
            this.grpDoanhThu.Controls.Add(this.dtpDenNgay);
            this.grpDoanhThu.Controls.Add(this.lblDenNgay);
            this.grpDoanhThu.Controls.Add(this.dtpTuNgay);
            this.grpDoanhThu.Controls.Add(this.lblTuNgay);
            this.grpDoanhThu.Location = new System.Drawing.Point(8, 6);
            this.grpDoanhThu.Name = "grpDoanhThu";
            this.grpDoanhThu.Size = new System.Drawing.Size(984, 165);
            this.grpDoanhThu.TabIndex = 0;
            this.grpDoanhThu.TabStop = false;
            this.grpDoanhThu.Text = "Thống kê Doanh thu (Dùng ExecuteScalar)";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Crimson;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(180, 105);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(81, 30);
            this.lblTongDoanhThu.TabIndex = 6;
            this.lblTongDoanhThu.Text = "0 VNĐ";
            // 
            // lblDoanhThuText
            // 
            this.lblDoanhThuText.AutoSize = true;
            this.lblDoanhThuText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDoanhThuText.Location = new System.Drawing.Point(20, 110);
            this.lblDoanhThuText.Name = "lblDoanhThuText";
            this.lblDoanhThuText.Size = new System.Drawing.Size(154, 21);
            this.lblDoanhThuText.TabIndex = 5;
            this.lblDoanhThuText.Text = "Tổng Doanh Thu thu:";
            // 
            // btnThongKeDoanhThu
            // 
            this.btnThongKeDoanhThu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThongKeDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnThongKeDoanhThu.Location = new System.Drawing.Point(540, 32);
            this.btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            this.btnThongKeDoanhThu.Size = new System.Drawing.Size(180, 35);
            this.btnThongKeDoanhThu.TabIndex = 4;
            this.btnThongKeDoanhThu.Text = "Thống Kê Doanh Thu";
            this.btnThongKeDoanhThu.UseVisualStyleBackColor = false;
            this.btnThongKeDoanhThu.Click += new System.EventHandler(this.btnThongKeDoanhThu_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(360, 36);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(140, 25);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(280, 40);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(71, 19);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(90, 36);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(140, 25);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(20, 40);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(61, 19);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Bán hàng & Siêu thị Mini (Bài 6.1)";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabDanhMuc.ResumeLayout(false);
            this.grpSanPham.ResumeLayout(false);
            this.grpSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.grpKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.grpNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tabBanHang.ResumeLayout(false);
            this.grpThongTinHoaDon.ResumeLayout(false);
            this.grpThongTinHoaDon.PerformLayout();
            this.grpGioHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.grpChonSanPham.ResumeLayout(false);
            this.grpChonSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongBan)).EndInit();
            this.tabBaoCao.ResumeLayout(false);
            this.grpTop5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5SanPham)).EndInit();
            this.grpDoanhThu.ResumeLayout(false);
            this.grpDoanhThu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabDanhMuc;
        private System.Windows.Forms.TabPage tabBanHang;
        private System.Windows.Forms.TabPage tabBaoCao;
        private System.Windows.Forms.GroupBox grpSanPham;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpKhachHang;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.GroupBox grpNhanVien;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox grpChonSanPham;
        private System.Windows.Forms.Label lblChonSP;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown nudSoLuongBan;
        private System.Windows.Forms.Button btnThemVaoGio;
        private System.Windows.Forms.GroupBox grpGioHang;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.GroupBox grpThongTinHoaDon;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblTongTienText;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblDiemText;
        private System.Windows.Forms.Label lblDiemTichLuyTamTinh;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.GroupBox grpDoanhThu;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnThongKeDoanhThu;
        private System.Windows.Forms.Label lblDoanhThuText;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.GroupBox grpTop5;
        private System.Windows.Forms.Button btnTop5BanChay;
        private System.Windows.Forms.DataGridView dgvTop5SanPham;
    }
}