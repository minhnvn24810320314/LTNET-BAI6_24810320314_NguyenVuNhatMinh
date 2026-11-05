using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using BaiTap6_1.DTO;

namespace BaiTap6_1.DAL
{
    public class SalesDAL
    {
        // =========================================================================
        // 1. QUẢN LÝ DANH MỤC & TÌM KIẾM BẰNG SQLPARAMETER CHỐNG SQL INJECTION
        // =========================================================================

        // Lấy danh sách toàn bộ sản phẩm
        public DataTable GetAllSanPham()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM SanPham";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Tìm kiếm sản phẩm bằng SqlParameter có ký tự đại diện %
        public DataTable TimKiemSanPham(string keyword)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM SanPham WHERE MaSP LIKE @keyword OR TenSP LIKE @keyword";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                // Sử dụng SqlParameter bảo mật 100% chống SQL Injection
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        // Lấy danh sách Khách hàng
        public DataTable GetAllKhachHang()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM KhachHang";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Lấy danh sách Nhân viên
        public DataTable GetAllNhanVien()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM NhanVien";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // =========================================================================
        // 2. NGHIỆP VỤ LẬP HÓA ĐƠN BẰNG SQLTRANSACTION (BẮT BUỘC THEO ĐỀ BÀI)
        // =========================================================================
        public bool ThanhToanHoaDon(HoaDonDTO hoaDon, List<ChiTietHoaDonDTO> dsChiTiet, out string errorMessage)
        {
            errorMessage = string.Empty;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                // Khởi tạo SqlTransaction đảm bảo tính toàn vẹn dữ liệu ACID
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // Thao tác 1: Chèn 1 bản ghi vào bảng HoaDon và lấy MaHD vừa tạo (SCOPE_IDENTITY)
                    string queryHD = @"INSERT INTO HoaDon (MaNV, MaKH, TongTien) 
                                       VALUES (@MaNV, @MaKH, @TongTien);
                                       SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdHD = new SqlCommand(queryHD, conn, trans);
                    cmdHD.Parameters.AddWithValue("@MaNV", hoaDon.MaNV);
                    cmdHD.Parameters.AddWithValue("@MaKH", (object)hoaDon.MaKH ?? DBNull.Value);
                    cmdHD.Parameters.AddWithValue("@TongTien", hoaDon.TongTien);

                    int maHDVuaTao = Convert.ToInt32(cmdHD.ExecuteScalar());

                    // Thao tác 2 & 3: Duyệt chi tiết hóa đơn, kiểm tra tồn kho và trừ số lượng tồn
                    foreach (var item in dsChiTiet)
                    {
                        // Kiểm tra số lượng tồn hiện tại của Sản phẩm
                        string queryCheckTon = "SELECT SoLuongTon FROM SanPham WHERE MaSP = @MaSP";
                        SqlCommand cmdCheck = new SqlCommand(queryCheckTon, conn, trans);
                        cmdCheck.Parameters.AddWithValue("@MaSP", item.MaSP);

                        int tonHienTai = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        // Nếu Số lượng tồn < Số lượng bán -> Gọi Rollback và báo lỗi!
                        if (tonHienTai < item.SoLuong)
                        {
                            trans.Rollback();
                            errorMessage = $"Sản phẩm [{item.MaSP}] không đủ hàng tồn kho! (Tồn: {tonHienTai}, Bán: {item.SoLuong}). Transaction bị Rollback thành công!";
                            return false;
                        }

                        // Chèn bản ghi vào ChiTietHoaDon
                        string queryCTHD = "INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)";
                        SqlCommand cmdCT = new SqlCommand(queryCTHD, conn, trans);
                        cmdCT.Parameters.AddWithValue("@MaHD", maHDVuaTao);
                        cmdCT.Parameters.AddWithValue("@MaSP", item.MaSP);
                        cmdCT.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmdCT.Parameters.AddWithValue("@DonGia", item.DonGia);
                        cmdCT.ExecuteNonQuery();

                        // Trừ SoLuongTon trong bảng SanPham
                        string queryTruTon = "UPDATE SanPham SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaSP = @MaSP";
                        SqlCommand cmdTru = new SqlCommand(queryTruTon, conn, trans);
                        cmdTru.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmdTru.Parameters.AddWithValue("@MaSP", item.MaSP);
                        cmdTru.ExecuteNonQuery();
                    }

                    // Thao tác 4: Cộng điểm tích lũy cho Khách hàng (DiemTichLuy += TongTien / 100000)
                    if (hoaDon.MaKH.HasValue && hoaDon.MaKH.Value > 1) // Bỏ qua khách lẻ (MaKH = 1)
                    {
                        int diemCong = (int)(hoaDon.TongTien / 100000);
                        if (diemCong > 0)
                        {
                            string queryDiem = "UPDATE KhachHang SET DiemTichLuy = DiemTichLuy + @DiemCong WHERE MaKH = @MaKH";
                            SqlCommand cmdDiem = new SqlCommand(queryDiem, conn, trans);
                            cmdDiem.Parameters.AddWithValue("@DiemCong", diemCong);
                            cmdDiem.Parameters.AddWithValue("@MaKH", hoaDon.MaKH.Value);
                            cmdDiem.ExecuteNonQuery();
                        }
                    }

                    // Thao tác 5: Gọi trans.Commit() khi hoàn tất giao dịch an toàn
                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    // Rollback nếu phát sinh bất kỳ lỗi ngoại lệ nào
                    trans.Rollback();
                    errorMessage = "Lỗi giao dịch: " + ex.Message;
                    return false;
                }
            }
        }

        // =========================================================================
        // 3. BÁO CÁO - THỐNG KÊ (DÙNG EXECUTESCALAR VÀ SQLDATAREADER)
        // =========================================================================

        // 3.1 Dùng ExecuteScalar tính tổng doanh thu
        public decimal TinhTongDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            string query = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon WHERE NgayLap BETWEEN @TuNgay AND @DenNgay";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                conn.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        // 3.2 Dùng SqlDataReader hiển thị danh sách Top 5 sản phẩm bán chạy nhất
        public DataTable GetTop5SanPhamBanChay()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSP", typeof(string));
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("TongSoLuongDaBan", typeof(int));

            string query = @"SELECT TOP 5 sp.MaSP, sp.TenSP, SUM(ct.SoLuong) AS TongDaBan
                             FROM ChiTietHoaDon ct
                             JOIN SanPham sp ON ct.MaSP = sp.MaSP
                             GROUP BY sp.MaSP, sp.TenSP
                             ORDER BY TongDaBan DESC";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                // Đọc dữ liệu trực tiếp bằng SqlDataReader theo đúng yêu cầu đề bài
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataRow dr = dt.NewRow();
                        dr["MaSP"] = reader["MaSP"].ToString();
                        dr["TenSP"] = reader["TenSP"].ToString();
                        dr["TongSoLuongDaBan"] = Convert.ToInt32(reader["TongDaBan"]);
                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }
    }
}