using System;
using System.Collections.Generic;
using System.Data;
using BaiTap6_1.DAL;
using BaiTap6_1.DTO;

namespace BaiTap6_1.BUS
{
    public class SalesBUS
    {
        private SalesDAL salesDAL = new SalesDAL();

        public DataTable GetAllSanPham() => salesDAL.GetAllSanPham();
        public DataTable TimKiemSanPham(string keyword) => salesDAL.TimKiemSanPham(keyword);
        public DataTable GetAllKhachHang() => salesDAL.GetAllKhachHang();
        public DataTable GetAllNhanVien() => salesDAL.GetAllNhanVien();

        public bool ThanhToanHoaDon(HoaDonDTO hoaDon, List<ChiTietHoaDonDTO> dsChiTiet, out string errorMessage)
        {
            return salesDAL.ThanhToanHoaDon(hoaDon, dsChiTiet, out errorMessage);
        }

        public decimal TinhTongDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            return salesDAL.TinhTongDoanhThu(tuNgay, denNgay);
        }

        public DataTable GetTop5SanPhamBanChay()
        {
            return salesDAL.GetTop5SanPhamBanChay();
        }
    }
}