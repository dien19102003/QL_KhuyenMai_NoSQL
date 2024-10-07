using promotion_management_app.BASE;
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
    public partial class Form_Menu : Form
    {
        public Form_Menu(string tenNV)
        {
            InitializeComponent();
            Label_Heading.Text = $"Xin chào : {tenNV}";
        }

        private void btn_KhuyenMai_Click(object sender, EventArgs e)
        {
            //Form_Promotion form_Promotion = new Form_Promotion();
            //MyLib.LoadForm(panel_container, form_Promotion,DockStyle.Fill);

            Form_AddPromotion form_AddPromotion = new Form_AddPromotion(null);
            MyLib.LoadForm(panel_container, form_AddPromotion, DockStyle.Fill);
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            Form_Sell form_Sell = new Form_Sell();
            MyLib.LoadForm(panel_container,form_Sell,DockStyle.Fill);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_HeThong_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {

        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {

        }
    }
}
