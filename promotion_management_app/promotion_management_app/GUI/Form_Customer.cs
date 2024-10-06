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

namespace promotion_management_app.GUI
{
    public partial class Form_Customer : Form
    {
        public Form_Customer()
        {
            InitializeComponent();
            txtID.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các TextBox có trống hay không
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtphone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng KhachHang từ các TextBox
            var khachHang = new DTO_KhachHang.KhachHang
            {
                MaKH = GenerateRandomCustomerId(),
                TenKH = txtName.Text.Trim(),
                SDT = txtphone.Text.Trim(),
                DiaChi = txtAddress.Text.Trim()
            };

            // Gọi hàm thêm khách hàng
            var daoKhachHang = new DAO_KhachHang();
            bool isAdded = await daoKhachHang.AddKhachHang(khachHang);

            if (isAdded)
            {
                MessageBox.Show("Thêm khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XoaText();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void XoaText()
        {
            txtName.Clear();
            txtphone.Clear();
            txtAddress.Clear();
        }

        private string GenerateRandomCustomerId()
        {
            Random random = new Random();
            string randomNumber = random.Next(1000000000, int.MaxValue).ToString("D10");
            return "MAKH" + randomNumber;
        }
    }
}
