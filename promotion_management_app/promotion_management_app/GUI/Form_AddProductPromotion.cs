using promotion_management_app.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static promotion_management_app.DTO.DTO_SanPham;

namespace promotion_management_app.GUI
{
    public partial class Form_AddProductPromotion : Form
    {
        public Form_AddProductPromotion()
        {
            InitializeComponent();
            dsLoadSanPham();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dsLoadSanPham()
        {
            DAO_SanPham daoSanPham = new DAO_SanPham();
            List<SanPham> sanPhamList = daoSanPham.GetListSanPham();

           
            dgviews_SanPham.DataSource = sanPhamList;

            // Thiết lập tiêu đề cột
            dgviews_SanPham.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
            dgviews_SanPham.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dgviews_SanPham.Columns["GiaBan"].HeaderText = "Giá Bán";

            dgviews_SanPham.Columns["TenSP"].Width = 170;
            dgviews_SanPham.Columns["HinhAnh"].Visible = false;
            dgviews_SanPham.Columns["LoaiSP"].Visible = false;
            dgviews_SanPham.Columns["SoLuong"].Visible = false;
            dgviews_SanPham.Columns["_id"].Visible = false;
        }

        private void dgviews_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string tenSP = txtSearch.Text.Trim();

            DAO_SanPham daoSanPham = new DAO_SanPham();
            List<SanPham> ketQuaTimKiem = daoSanPham.TimKiemSanPhamTheoTen(tenSP);

            dgviews_SanPham.DataSource = ketQuaTimKiem; 
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<SanPham> sanPhamThemList = new List<SanPham>();

            // Duyệt qua các dòng của dgviews_SanPham để kiểm tra các dòng đã tick checkbox
            foreach (DataGridViewRow row in dgviews_SanPham.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["checkSP"].Value); // Kiểm tra checkbox
                if (isChecked)
                {
                    // Lấy thông tin sản phẩm từ dòng hiện tại
                    SanPham sanPham = new SanPham
                    {
                        MaSP = row.Cells["MaSP"].Value.ToString(),
                        TenSP = row.Cells["TenSP"].Value.ToString(),
                        GiaBan = Convert.ToDecimal(row.Cells["GiaBan"].Value)
                    };
                    // Thêm sản phẩm vào danh sách
                    sanPhamThemList.Add(sanPham);

                }
            }

            // Kiểm tra nếu có sản phẩm nào được chọn
            if (sanPhamThemList.Count > 0)
            {
                Form_AddPromotion form2 = Application.OpenForms.OfType<Form_AddPromotion>().FirstOrDefault();
                if (form2 != null)
                {
                    // Gọi phương thức thêm sản phẩm vào Form 2
                    form2.AddSanPhamToList(sanPhamThemList);
                    
                    //MessageBox.Show("Đã thêm sản phẩm vào danh sách trên form thứ hai!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Form thứ hai chưa được mở!", "Thông báo");
                }
                //form2.LoadDataToGrid(sanPhamThemList);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm!", "Thông báo");
            }
        }
    }
}
