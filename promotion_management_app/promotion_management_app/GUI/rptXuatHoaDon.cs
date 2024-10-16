using CrystalDecisions.CrystalReports.Engine;
using promotion_management_app.BASE;
using promotion_management_app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace promotion_management_app.GUI
{
    public partial class rptXuatHoaDon : Form
    {
        public rptXuatHoaDon(HoaDon hoaDon, List<SanPhamMua> sanPhamMuas,ICollection<SanPham> sanPhamMuaQT)
        {
            InitializeComponent();
            LoadReport(hoaDon, sanPhamMuas, sanPhamMuaQT);
        }

        private void LoadReport(HoaDon hoaDon, List<SanPhamMua> sanPhamMuas, ICollection<SanPham> sanPhamMuaQT)
        {
            try
            {
                if (hoaDon == null)
                {
                    MessageBox.Show("Hóa đơn không hợp lệ!");
                    return;
                }

                if (sanPhamMuas == null || sanPhamMuas.Count == 0)
                {
                    MessageBox.Show("Danh sách sản phẩm không hợp lệ!");
                    return;
                }

                // Khởi tạo DataSet hóa đơn
                Dulieurpt dataSet = new Dulieurpt();

                // Thêm thông tin hóa đơn vào DataSet
                var hoaDonRow = dataSet.DataTable1.NewDataTable1Row();
                hoaDonRow.MaHD = hoaDon.MaHD;
                hoaDonRow.NgayLap = hoaDon.NgayLap.ToString("dd/MM/yyyy HH:mm:ss");
                //hoaDonRow.TongCong = hoaDon.TongCong.ToString();
                //hoaDonRow.TongTien = hoaDon.TongTien.ToString();
                //hoaDonRow.TienKhuyenMai = hoaDon.TienKhuyenMai.ToString()??"0đ";
                hoaDonRow.TongCong = hoaDon.TongCong.ToString("C0", new CultureInfo("vi-VN")); // Định dạng VND
                hoaDonRow.TongTien = hoaDon.TongTien.ToString("C0", new CultureInfo("vi-VN")); // Định dạng VND
                hoaDonRow.TienKhuyenMai = hoaDon.TienKhuyenMai.ToString("C0", new CultureInfo("vi-VN")) ?? "0đ"; // Định dạng VND


                dataSet.DataTable1.AddDataTable1Row(hoaDonRow); // Thêm hóa đơn vào DataSet

                // Khởi tạo DataHelper và tạo DataTable cho sản phẩm
                DataHelper dataHelper = new DataHelper();
                DataTable dtSanPham = dataHelper.TaoDataTableHoaDon(sanPhamMuas, hoaDon);

                DataTable dtSanPhamQT = dataHelper.TaoDataTableHoaDonQT( hoaDon, sanPhamMuaQT);

                // Thêm dữ liệu sản phẩm vào DataTable trong DataSet
                foreach (DataRow row in dtSanPham.Rows)
                {
                    var productRow = dataSet.DataTable2.NewDataTable2Row();
                    productRow.TenSP = row["TenSP"].ToString();
                    productRow.SoLuong = Convert.ToInt32(row["SoLuong"]).ToString(); // Sử dụng Convert để an toàn hơn
                    productRow.GiaBan = Convert.ToDouble(row["GiaBan"]).ToString("C0", new CultureInfo("vi-VN")); // Chuyển đổi an toàn
                    productRow.ThanhTien = Convert.ToDouble(row["ThanhTien"]).ToString("C0", new CultureInfo("vi-VN")); // Chuyển đổi an toàn
                    dataSet.DataTable2.AddDataTable2Row(productRow);
                }
                
                if(dtSanPhamQT.Rows.Count > 0)
                {
                    foreach (DataRow row in dtSanPhamQT.Rows)
                    {
                        var productQT = dataSet.DataTable2.NewDataTable2Row();
                        productQT.TenSP = row["TenSP"].ToString();
                        productQT.SoLuong = "1";                
                        productQT.GiaBan = Convert.ToDouble(row["GiaBan"]).ToString("C0", new CultureInfo("vi-VN")); // Chuyển đổi an toàn
                        productQT.ThanhTien = "0";
                        dataSet.DataTable2.AddDataTable2Row(productQT);
                    }
                }    
                
                // Tạo báo cáo
                rptThietKeXuatHoaDon rpt = new rptThietKeXuatHoaDon(); // Đảm bảo đây là tên của báo cáo bạn đã tạo

                // Thiết lập nguồn dữ liệu cho báo cáo
                rpt.SetDataSource(dataSet);

                // Hiển thị báo cáo trong CrystalReportViewer
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải báo cáo: " + ex.Message);
            }
        }


        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            // Bạn có thể để trống hoặc thực hiện bất kỳ thao tác nào cần thiết khi điều khiển tải.
        }
    }
}