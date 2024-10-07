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
    public partial class Form_AddPromotion : Form
    {
        public Form_AddPromotion(List<SanPham> sanPhamList)
        {
            InitializeComponent();
            LoadDataToGrid(sanPhamList);
            LoadCBB();
        }
        public void LoadDataToGrid(List<SanPham> sanPhamList)
        {
            if(dgviewm_listSanPham.Rows.Count>0)
            {
                // Xóa dữ liệu hiện tại trong DataGridView trước khi thêm mới
                dgviewm_listSanPham.Rows.Clear();

                // Duyệt qua danh sách sản phẩm để thêm vào DataGridView
                foreach (var sanPham in sanPhamList)
                {
                    // Kiểm tra nếu sản phẩm đã tồn tại trong DataGridView
                    bool exists = dgviewm_listSanPham.Rows.Cast<DataGridViewRow>()
                        .Any(row => row.Cells["MaSP"].Value.ToString() == sanPham.MaSP);

                    // Nếu sản phẩm chưa tồn tại, thêm vào DataGridView
                    if (!exists)
                    {
                        dgviewm_listSanPham.Rows.Add(sanPham.MaSP, sanPham.TenSP, sanPham.GiaBan);
                    }
                    else
                    {

                    }
                    // Đặt HeaderText cho cột trong DataGridView nếu cần
                    dgviewm_listSanPham.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
                    dgviewm_listSanPham.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
                    dgviewm_listSanPham.Columns["GiaBan"].HeaderText = "Giá Bán";
                }

                
            }    
           
        }

        public void AddSanPhamToList(List<SanPham> sanPhamList)
        {
            foreach (var sanPham in sanPhamList)
            {
                dgviewm_listSanPham.Rows.Add(sanPham.MaSP, sanPham.TenSP, sanPham.GiaBan);
            }
        }

        private void btnAddProduct_Tab1_Click(object sender, EventArgs e)
        {
            Form_AddProductPromotion form_AddProductPromotion = new Form_AddProductPromotion();
            form_AddProductPromotion.ShowDialog();
        }

        private void btnAddProduct_Tab2_Click(object sender, EventArgs e)
        {
            Form_AddProductPromotion form_AddProductPromotion = new Form_AddProductPromotion();
            form_AddProductPromotion.ShowDialog();
        }

        private void btnThemQT_Click(object sender, EventArgs e)
        {
            Form_AddProductPromotion form_AddProductPromotion = new Form_AddProductPromotion();
            form_AddProductPromotion.ShowDialog();
        }

        private void btnThemVoucher_Click(object sender, EventArgs e)
        {
            Form_AddVourcher form_AddVourcher = new Form_AddVourcher();
            form_AddVourcher.ShowDialog();
        }

        private void btnAddProduct_Tab4_Click(object sender, EventArgs e)
        {
            Form_AddVourcher form_AddVourcher = new Form_AddVourcher();
            form_AddVourcher.ShowDialog();
        }

        private void LoadCBB()
        {
            DAO_LoaiKhuyenMai daoLoaiKhuyenMai = new DAO_LoaiKhuyenMai();
            List<KeyValuePair<string, string>> loaiKhuyenMaiList = daoLoaiKhuyenMai.GetLoaiKhuyenMai();

            cbbkhuyenmai.DataSource = loaiKhuyenMaiList;
            cbbkhuyenmai.DisplayMember = "Value";
            cbbkhuyenmai.ValueMember = "Key";
        }
    }
}
