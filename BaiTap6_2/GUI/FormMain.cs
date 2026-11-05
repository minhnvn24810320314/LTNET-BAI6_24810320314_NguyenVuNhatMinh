using System;
using System.Data;
using System.Windows.Forms;
using BaiTap6_2.BUS;

namespace BaiTap6_2.GUI
{
    public partial class FormMain : Form
    {
        private HrmBUS hrmBUS = new HrmBUS();
        private DataTable dtChamCongHienTai;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = hrmBUS.GetAllNhanVien();
            cboThang.SelectedIndex = DateTime.Now.Month - 1;
            txtNam.Text = DateTime.Now.Year.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = hrmBUS.TimKiemNhanVien(txtTimKiem.Text.Trim());
        }

        private string GetThangNamChon()
        {
            string thang = (cboThang.SelectedIndex + 1).ToString("D2");
            string nam = txtNam.Text.Trim();
            return $"{thang}/{nam}";
        }

        // TẢI CHẤM CÔNG (DISCONNECTED MODEL)
        private void btnTaiChamCong_Click(object sender, EventArgs e)
        {
            string thangNam = GetThangNamChon();
            dtChamCongHienTai = hrmBUS.GetBangChamCongByThang(thangNam);
            dgvChamCong.DataSource = dtChamCongHienTai;
        }

        // LƯU CHẤM CÔNG VỀ SQL SERVER
        private void btnLuuChamCong_Click(object sender, EventArgs e)
        {
            if (dtChamCongHienTai == null) return;
            string thangNam = GetThangNamChon();

            if (hrmBUS.LuuBangChamCong(thangNam, dtChamCongHienTai, out string err))
            {
                MessageBox.Show($"Lưu bảng chấm công tháng {thangNam} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi lưu chấm công: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CHỐT LƯƠNG BẰNG SQLTRANSACTION
        private void btnChotLuong_Click(object sender, EventArgs e)
        {
            string thangNam = GetThangNamChon();
            if (hrmBUS.ChotLuongThang(thangNam, out string err))
            {
                MessageBox.Show($"Chốt lương tháng {thangNam} thành công (trans.Commit)! Dữ liệu đã lưu vào BangLuong.",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBangLuong.DataSource = hrmBUS.GetBangLuongByThang(thangNam);
            }
            else
            {
                MessageBox.Show(err, "Giao dịch thất bại (trans.Rollback)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}