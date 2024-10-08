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
    public partial class Form_AddVourcher : Form
    {
        public Form_AddVourcher()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemVocher()
        {
            string mavc=txtMaVourcher.Text;

            NgayBDVC_Tab4.Format = DateTimePickerFormat.Custom;
            NgayBDVC_Tab4.CustomFormat = "dd/MM/yyyy";
            DateTime ngaybd = NgayBDVC_Tab4.Value;

            NgayKTVC_Tab4.Format = DateTimePickerFormat.Custom;
            NgayKTVC_Tab4.CustomFormat = "dd/MM/yyyy";
            DateTime ngaykt = NgayKTVC_Tab4.Value;

            float giamgia= float.Parse(txtGiamGia.Text);

            Voucher vc = new Voucher()
            {
               GiftCode=mavc,
               NgayBatDau=ngaybd,
               NgayKetThuc=ngaykt,
               GiamGia=giamgia,
            };
            Form_AddPromotion form2 = Application.OpenForms.OfType<Form_AddPromotion>().FirstOrDefault();
            form2.AddVoucher(vc);
            form2.vc = vc;
            this.Close();
        }

        private string GenerateRandomKhuyenMaiId()
        {
            Random random = new Random();
            string randomNumber = random.Next(1000000000, int.MaxValue).ToString("D10");
            return "MAKM" + randomNumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ThemVocher();
        }
    }
}
