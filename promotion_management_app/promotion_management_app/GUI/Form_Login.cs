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
using static promotion_management_app.DTO.DTO_NhanVien;

namespace promotion_management_app.GUI
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            chkShowPassword.CheckedChanged += ChkShowPassword_CheckedChanged;
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu checkbox được chọn thì hiển thị mật khẩu
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0'; // Hiển thị mật khẩu
            }
            else
            {
                txtPassword.PasswordChar = '*'; // Ẩn mật khẩu
            }
        }

        // Kiểm tra tên người dùng và mật khẩu
        public async void CheckUserPass(string username, string password)
        {
            DAO_NhanVien daoNhanVien = new DAO_NhanVien();

            // Gọi phương thức kiểm tra tài khoản
            bool isValidUser = await daoNhanVien.CheckUserCredentials(username, password);
            DTO_NhanVien.NhanVien nhanVien = await new DAO_NhanVien().GetNhanVienByUsernameAndPassword(username, password);
            // Thông báo kết quả
            if (isValidUser)
            {             
                this.Hide();
                Form_Menu formMenu = new Form_Menu(nhanVien.TenNV); // Truyền TenNV vào Form_Menu
                formMenu.Show();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; 
            string password = txtPassword.Text; 
            CheckUserPass(username, password);
        }
    }
}
