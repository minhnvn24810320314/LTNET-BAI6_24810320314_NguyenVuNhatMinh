using System;

namespace BaiTap6_1.DTO
{
    public class HoaDonDTO
    {
        public int MaHD { get; set; }
        public DateTime NgayLap { get; set; }
        public int MaNV { get; set; }
        public int? MaKH { get; set; } // Nullable nếu là Khách lẻ
        public decimal TongTien { get; set; }
    }
}