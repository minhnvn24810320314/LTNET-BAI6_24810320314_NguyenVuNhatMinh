using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BaiTap6_1.BUS;
using BaiTap6_1.DTO;

namespace BaiTap6_1.GUI
{
    public partial class FormMain : Form
    {
        private SalesBUS salesBUS = new SalesBUS();
        private List<ChiTietHoaDonDTO> gioHang = new List<ChiTietHoaDonDTO>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadDataTabQuanLy();
            LoadDataTabBanHang();
        }

        // =========================================================================
        // TAB 1: QUẢN LÝ DANH MỤC & TÌM KIẾM BẰNG SQLPARAMETER CHỐNG SQL INJECTION
        // =========================================================================
        private void LoadDataTabQuanLy()
        {
            try
            {
                dgvSanPham.DataSource = salesBUS.GetAllSanPham();
                dgvKhachHang.DataSource = salesBUS.GetAllKhachHang();
                dgvNhanVien.DataSource = salesBUS.GetAllNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tìm kiếm sản phẩm theo tên hoặc mã vạch bằng SqlParameter có %
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dgvSanPham.DataSource = salesBUS.TimKiemSanPham(keyword);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadDataTabQuanLy();
        }

        // =========================================================================
        // TAB 2: MÀN HÌNH BÁN HÀNG / LẬP HÓA ĐƠN (SQLTRANSACTION & ROLLBACK)
        // =========================================================================
        private void LoadDataTabBanHang()
        {
            try
            {
                // Nạp danh sách Nhân viên vào ComboBox
                cboNhanVien.DataSource = salesBUS.GetAllNhanVien();
                cboNhanVien.DisplayMember = "TenNV";
                cboNhanVien.ValueMember = "MaNV";

                // Nạp danh sách Khách hàng vào ComboBox
                cboKhachHang.DataSource = salesBUS.GetAllKhachHang();
                cboKhachHang.DisplayMember = "TenKH";
                cboKhachHang.ValueMember = "MaKH";

                // Nạp danh sách Sản phẩm chọn bán
                cboSanPham.DataSource = salesBUS.GetAllSanPham();
                cboSanPham.DisplayMember = "TenSP";
                cboSanPham.ValueMember = "MaSP";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục bán hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chọn sản phẩm -> hiển thị đơn giá tự động
        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem is DataRowView drv)
            {
                txtDonGiaBan.Text = drv["GiaBan"].ToString();
            }
        }

        // Thêm sản phẩm vào giỏ hàng (DataGridView Giỏ hàng)
        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue == null) return;

            string maSP = cboSanPham.SelectedValue.ToString();
            string tenSP = cboSanPham.Text;
            int soLuong = (int)nudSoLuongBan.Value;
            decimal donGia = Convert.ToDecimal(txtDonGiaBan.Text);

            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng bán phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem sản phẩm đã có trong giỏ hàng chưa
            var existingItem = gioHang.Find(x => x.MaSP == maSP);
            if (existingItem != null)
            {
                existingItem.SoLuong += soLuong;
            }
            else
            {
                gioHang.Add(new ChiTietHoaDonDTO
                {
                    MaSP = maSP,
                    SoLuong = soLuong,
                    DonGia = donGia
                });
            }

            CapNhatHienThiGioHang();
        }

        private void CapNhatHienThiGioHang()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = gioHang;

            // Tính tổng tiền mặt
            decimal tongTien = 0;
            foreach (var item in gioHang)
            {
                tongTien += item.ThanhTien;
            }

            lblTongTien.Text = $"{tongTien:N0} VNĐ";
            // Tích điểm tự động: TongTien / 100,000
            int diemTichLuy = (int)(tongTien / 100000);
            lblDiemTichLuyTamTinh.Text = $"{diemTichLuy} điểm";
        }

        // THỰC THI THANH TOÁN BẰNG SQLTRANSACTION
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống! Vui lòng chọn sản phẩm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tongTien = 0;
            foreach (var item in gioHang) tongTien += item.ThanhTien;

            HoaDonDTO hoaDon = new HoaDonDTO
            {
                MaNV = Convert.ToInt32(cboNhanVien.SelectedValue),
                MaKH = cboKhachHang.SelectedValue != null ? (int?)Convert.ToInt32(cboKhachHang.SelectedValue) : null,
                TongTien = tongTien,
                NgayLap = DateTime.Now
            };

            // Gọi SqlTransaction tầng BUS / DAL
            bool success = salesBUS.ThanhToanHoaDon(hoaDon, gioHang, out string errorMessage);

            if (success)
            {
                MessageBox.Show("Thanh toán thành công! Hóa đơn đã được lưu, tồn kho đã trừ và cộng điểm cho khách hàng.",
                                "Thành công (trans.Commit)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset giỏ hàng & tải lại dữ liệu mới nhất
                gioHang.Clear();
                CapNhatHienThiGioHang();
                LoadDataTabQuanLy();
                LoadDataTabBanHang();
            }
            else
            {
                // Thông báo lỗi Rollback
                MessageBox.Show(errorMessage, "Giao dịch thất bại (trans.Rollback)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================================================================
        // TAB 3: BÁO CÁO - THỐNG KÊ (EXECUTESCALAR VÀ SQLDATAREADER)
        // =========================================================================
        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1); // Cuối ngày

            // Dùng ExecuteScalar tính tổng doanh thu
            decimal tongDoanhThu = salesBUS.TinhTongDoanhThu(tuNgay, denNgay);
            lblTongDoanhThu.Text = $"{tongDoanhThu:N0} VNĐ";
        }

        private void btnTop5BanChay_Click(object sender, EventArgs e)
        {
            // Dùng SqlDataReader hiển thị danh sách Top 5 bán chạy
            DataTable dtTop5 = salesBUS.GetTop5SanPhamBanChay();
            dgvTop5SanPham.DataSource = dtTop5;
        }
    }
}