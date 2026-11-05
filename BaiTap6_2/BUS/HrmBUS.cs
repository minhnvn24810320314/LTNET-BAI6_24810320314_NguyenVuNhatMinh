using System.Data;
using BaiTap6_2.DAL;

namespace BaiTap6_2.BUS
{
    public class HrmBUS
    {
        private HrmDAL hrmDAL = new HrmDAL();

        public DataTable GetAllPhongBan() => hrmDAL.GetAllPhongBan();
        public DataTable GetAllNhanVien() => hrmDAL.GetAllNhanVien();
        public DataTable TimKiemNhanVien(string keyword) => hrmDAL.TimKiemNhanVien(keyword);
        public DataTable GetBangChamCongByThang(string thangNam) => hrmDAL.GetBangChamCongByThang(thangNam);
        public bool LuuBangChamCong(string thangNam, DataTable dtSource, out string error) => hrmDAL.LuuBangChamCong(thangNam, dtSource, out error);
        public bool ChotLuongThang(string thangNam, out string error) => hrmDAL.ChotLuongThang(thangNam, out error);
        public DataTable GetBangLuongByThang(string thangNam) => hrmDAL.GetBangLuongByThang(thangNam);
    }
}