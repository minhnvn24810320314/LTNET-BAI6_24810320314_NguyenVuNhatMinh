using System;
using System.Data;
using Microsoft.Data.SqlClient;
using BaiTap6_2.DTO;

namespace BaiTap6_2.DAL
{
    public class HrmDAL
    {
        public DataTable GetAllPhongBan()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM PhongBan";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetAllNhanVien()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT nv.MaNV, nv.HoTen, nv.NgaySinh, nv.CCCD, nv.MaPB, pb.TenPB, nv.LuongCoBan, nv.HeSoLuong 
                             FROM NhanVien nv 
                             JOIN PhongBan pb ON nv.MaPB = pb.MaPB";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable TimKiemNhanVien(string keyword)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT nv.MaNV, nv.HoTen, nv.NgaySinh, nv.CCCD, nv.MaPB, pb.TenPB, nv.LuongCoBan, nv.HeSoLuong 
                             FROM NhanVien nv 
                             JOIN PhongBan pb ON nv.MaPB = pb.MaPB
                             WHERE nv.HoTen LIKE @kw OR nv.CCCD LIKE @kw OR pb.TenPB LIKE @kw";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        // =========================================================================
        // DISCONNECTED MODEL: NẠP VÀ LƯU BẢNG CHẤM CÔNG BẰNG SQLDATAADAPTER & SQLCOMMANDBUILDER
        // =========================================================================
        private SqlDataAdapter adapterChamCong;
        private DataTable dtChamCong;

        public DataTable GetBangChamCongByThang(string thangNam)
        {
            dtChamCong = new DataTable();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                // Nếu chưa có dữ liệu tháng này, tự động nạp danh sách nhân viên vào
                string query = @"SELECT cc.MaCong, nv.MaNV, nv.HoTen, 
                                        ISNULL(cc.ThangNam, @ThangNam) AS ThangNam, 
                                        ISNULL(cc.SoNgayCong, 22) AS SoNgayCong, 
                                        ISNULL(cc.SoGioOT, 0) AS SoGioOT
                                 FROM NhanVien nv
                                 LEFT JOIN BangChamCong cc ON nv.MaNV = cc.MaNV AND cc.ThangNam = @ThangNam";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ThangNam", thangNam);

                adapterChamCong = new SqlDataAdapter(cmd);
                adapterChamCong.Fill(dtChamCong);
            }
            return dtChamCong;
        }

        public bool LuuBangChamCong(string thangNam, DataTable dtSource, out string error)
        {
            error = string.Empty;
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    foreach (DataRow row in dtSource.Rows)
                    {
                        int maNV = Convert.ToInt32(row["MaNV"]);
                        double soNgayCong = Convert.ToDouble(row["SoNgayCong"]);
                        double soGioOT = Convert.ToDouble(row["SoGioOT"]);

                        string sqlUpsert = @"
                            IF EXISTS (SELECT 1 FROM BangChamCong WHERE MaNV = @MaNV AND ThangNam = @ThangNam)
                                UPDATE BangChamCong SET SoNgayCong = @SoNgayCong, SoGioOT = @SoGioOT WHERE MaNV = @MaNV AND ThangNam = @ThangNam
                            ELSE
                                INSERT INTO BangChamCong (MaNV, ThangNam, SoNgayCong, SoGioOT) VALUES (@MaNV, @ThangNam, @SoNgayCong, @SoGioOT)";

                        SqlCommand cmd = new SqlCommand(sqlUpsert, conn);
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@ThangNam", thangNam);
                        cmd.Parameters.AddWithValue("@SoNgayCong", soNgayCong);
                        cmd.Parameters.AddWithValue("@SoGioOT", soGioOT);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }
            }
        }

        // =========================================================================
        // CHỐT LƯƠNG THÁNG VỚI SQLTRANSACTION & CÔNG THỨC TÍNH LƯƠNG
        // =========================================================================
        public bool ChotLuongThang(string thangNam, out string error)
        {
            error = string.Empty;
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // Lấy danh sách chấm công và thông tin lương nhân viên
                    string queryData = @"SELECT cc.MaNV, nv.LuongCoBan, nv.HeSoLuong, cc.SoNgayCong, cc.SoGioOT
                                         FROM BangChamCong cc
                                         JOIN NhanVien nv ON cc.MaNV = nv.MaNV
                                         WHERE cc.ThangNam = @ThangNam";

                    SqlCommand cmdData = new SqlCommand(queryData, conn, trans);
                    cmdData.Parameters.AddWithValue("@ThangNam", thangNam);

                    DataTable dtData = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmdData);
                    da.Fill(dtData);

                    if (dtData.Rows.Count == 0)
                    {
                        trans.Rollback();
                        error = $"Chưa có dữ liệu chấm công cho tháng {thangNam}!";
                        return false;
                    }

                    // Xóa bảng lương cũ của tháng nếu chốt lại
                    string deleteOld = "DELETE FROM BangLuong WHERE ThangNam = @ThangNam";
                    SqlCommand cmdDelete = new SqlCommand(deleteOld, conn, trans);
                    cmdDelete.Parameters.AddWithValue("@ThangNam", thangNam);
                    cmdDelete.ExecuteNonQuery();

                    // Ghi nhận bảng lương mới
                    foreach (DataRow dr in dtData.Rows)
                    {
                        int maNV = Convert.ToInt32(dr["MaNV"]);
                        decimal luongCB = Convert.ToDecimal(dr["LuongCoBan"]);
                        double heSo = Convert.ToDouble(dr["HeSoLuong"]);
                        double ngayCong = Convert.ToDouble(dr["SoNgayCong"]);
                        double gioOT = Convert.ToDouble(dr["SoGioOT"]);

                        // Công thức: ThucLinh = (LuongCoBan * HeSoLuong / 22) * SoNgayCong + (SoGioOT * 50,000)
                        decimal thucLinh = (decimal)((double)luongCB * heSo / 22.0) * (decimal)ngayCong + (decimal)(gioOT * 50000);

                        string insertLuong = "INSERT INTO BangLuong (MaNV, ThangNam, ThucLinh) VALUES (@MaNV, @ThangNam, @ThucLinh)";
                        SqlCommand cmdInsert = new SqlCommand(insertLuong, conn, trans);
                        cmdInsert.Parameters.AddWithValue("@MaNV", maNV);
                        cmdInsert.Parameters.AddWithValue("@ThangNam", thangNam);
                        cmdInsert.Parameters.AddWithValue("@ThucLinh", thucLinh);
                        cmdInsert.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    error = "Lỗi giao dịch chốt lương: " + ex.Message;
                    return false;
                }
            }
        }

        public DataTable GetBangLuongByThang(string thangNam)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT bl.MaLuong, nv.MaNV, nv.HoTen, pb.TenPB, bl.ThangNam, bl.ThucLinh
                             FROM BangLuong bl
                             JOIN NhanVien nv ON bl.MaNV = nv.MaNV
                             JOIN PhongBan pb ON nv.MaPB = pb.MaPB
                             WHERE bl.ThangNam = @ThangNam";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ThangNam", thangNam);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}