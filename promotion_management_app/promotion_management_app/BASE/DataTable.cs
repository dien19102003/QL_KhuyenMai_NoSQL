using System.Data;
using System.Collections.Generic;
using promotion_management_app.DTO;

namespace promotion_management_app.BASE
{
    public class DataHelper
    {
        // Phương thức để tạo DataTable từ danh sách sản phẩm và hóa đơn
        public DataTable TaoDataTableHoaDon(List<SanPhamMua> sanPhamMuas, HoaDon hoaDon)
        {
            DataTable dt = new DataTable();

            // Tạo các cột cho DataTable
            dt.Columns.Add("MaSP", typeof(string));
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("GiaBan", typeof(double));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("ThanhTien", typeof(double));
            dt.Columns.Add("TongCong", typeof(double));
            dt.Columns.Add("TienKhuyenMai", typeof(double));
            dt.Columns.Add("TongTien", typeof(double));
            dt.Columns.Add("NgayLap", typeof(string));

            // Thêm dữ liệu vào DataTable
            foreach (var sp in sanPhamMuas)
            {
                dt.Rows.Add(sp.MaSP, sp.TenSP, sp.GiaBan, sp.SoLuong, sp.ThanhTien,
                    hoaDon.TongCong, hoaDon.TienKhuyenMai, hoaDon.TongTien, hoaDon.NgayLap.ToString("dd/MM/yyyy"));
            }

            return dt;
        }
    }
}
