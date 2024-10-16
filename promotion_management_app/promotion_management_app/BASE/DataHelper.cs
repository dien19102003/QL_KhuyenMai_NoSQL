using System.Collections.Generic;
using System.Data;
using promotion_management_app.DTO;

public class DataHelper
{
    // Chuyển từ List<SanPhamMua> sang DataTable
    public DataTable TaoDataTableHoaDon(ICollection<SanPhamMua> sanPhamMuas, HoaDon hoaDon)
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
            dt.Rows.Add(
                sp.MaSP,
                sp.TenSP,
                sp.GiaBan,
                sp.SoLuong,
                sp.ThanhTien,
                hoaDon.TongCong,
                hoaDon.TienKhuyenMai,
                hoaDon.TongTien,
                hoaDon.NgayLap.ToString("dd/MM/yyyy") // Chuyển đổi Ngày sang chuỗi
            );
        }

        return dt;
    }
    public DataTable TaoDataTableHoaDonQT( HoaDon hoaDon, ICollection<SanPham> sanPhamMuaQT)
    {
        DataTable dt = new DataTable();

        // Tạo các cột cho DataTable
        dt.Columns.Add("MaSP", typeof(string));
        dt.Columns.Add("TenSP", typeof(string));
        dt.Columns.Add("GiaBan", typeof(double));
        dt.Columns.Add("SoLuong", typeof(int));
        dt.Columns.Add("ThanhTien", typeof(double));
        if (sanPhamMuaQT != null)
        {

            foreach (var sp in sanPhamMuaQT)
            {
                dt.Rows.Add(
                    sp.MaSP,
                    sp.TenSP,
                    sp.GiaBan,
                    "1",
                    "0"
                );
            }
        }

        return dt;
    }
}