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
    public partial class Form_AddPromotion : Form
    {
        public Form_AddPromotion()
        {
            InitializeComponent();
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
    }
}
