using promotion_management_app.DAO;
using promotion_management_app.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static promotion_management_app.DTO.DTO_KhachHang;
using static promotion_management_app.DTO.DTO_SanPham;

namespace promotion_management_app.GUI
{
    public partial class Form_AddPromotion : Form
    {
        List<SanPham> sanPhamList;
        public Form_AddPromotion(List<SanPham> sanPhamList)
        {
            InitializeComponent();
            this.sanPhamList = sanPhamList;
            LoadDataToGrid(this.sanPhamList);
            txtMaKM_Tab1.Enabled = false;
            LoadCBB();
        }
        public void LoadDataToGrid(List<SanPham> sanPhamList)
        {
            if(dgviewm_listSanPham.Rows.Count >0)
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
                }

                
            }         
        }

        public void AddSanPhamToList(List<SanPham> sanPhamList)
        {
            foreach (var sanPham in sanPhamList)
            {
                // Kiểm tra nếu sản phẩm đã tồn tại trước khi thêm
                bool exists = dgviewm_listSanPham.Rows.Cast<DataGridViewRow>()
                    .Any(row => row.Cells["MaSP"].Value.ToString() == sanPham.MaSP);

                if (!exists)
                {
                    dgviewm_listSanPham.Rows.Add(sanPham.MaSP, sanPham.TenSP, sanPham.GiaBan);
                }
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

            cbbkhuyenmai1.DataSource = loaiKhuyenMaiList;
            cbbkhuyenmai1.DisplayMember = "Value";
            cbbkhuyenmai1.ValueMember = "Key";

            cbbkhuyenmai2.DataSource = loaiKhuyenMaiList;
            cbbkhuyenmai2.DisplayMember = "Value";
            cbbkhuyenmai2.ValueMember = "Key";

            cbbkhuyenmai3.DataSource = loaiKhuyenMaiList;
            cbbkhuyenmai3.DisplayMember = "Value";
            cbbkhuyenmai3.ValueMember = "Key";
        }


        private async void ThemKhuyenMai_Tab1()
        {
            string makm = txtMaKM_Tab1.Text;
            string tenkm=txtTenKM_Tab1.Text;
            string maloai=cbbkhuyenmai.SelectedValue.ToString();
            // Thiết lập định dạng cho DateTimePicker
            date_NgayBD_Tab1.Format = DateTimePickerFormat.Custom;
            date_NgayBD_Tab1.CustomFormat = "dd/MM/yyyy";
            // Lấy giá trị từ DateTimePicker
            DateTime ngaybd = date_NgayBD_Tab1.Value;

            date_KetThuc_Tab1.Format=DateTimePickerFormat.Custom;
            date_KetThuc_Tab1.CustomFormat = "dd/MM/yyyy";
            DateTime ngaykt = date_KetThuc_Tab1.Value;

            string hinhthuc = txtHinhThuc_Tab1.Text;
            int sltt =int.Parse( txtSoLuongTT_Tab1.Text);
            float giamgia = float.Parse(txtGiamGia_Tab1.Text);

            KhuyenMai km = new KhuyenMai()
            {
                MaKM = GenerateRandomKhuyenMaiId(),
                TenKM = tenkm,
                MaLoaiKM = maloai,
                NgayBatDau = ngaybd,
                NgayKetThuc = ngaykt,
                DieuKien = new DieuKien()
                {
                    SanPham = sanPhamList,
                    SoLuongToiThieu = sltt,

                },
                GiamGia = giamgia,
            };


            // Gọi hàm thêm khách hàng
            var daokm = new DAO_KhuyenMai_Tab1();
            bool isAdded = await daokm.AddKhuyenMai(km);

            if (isAdded)
            {
                MessageBox.Show("Thêm khuyến mãi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string GenerateRandomKhuyenMaiId()
        {
            Random random = new Random();
            string randomNumber = random.Next(1000000000, int.MaxValue).ToString("D10");
            return "MAKM" + randomNumber;
        }

        private void btnLuu_Tab1_Click(object sender, EventArgs e)
        {
            ThemKhuyenMai_Tab1();
        }
    }
}
