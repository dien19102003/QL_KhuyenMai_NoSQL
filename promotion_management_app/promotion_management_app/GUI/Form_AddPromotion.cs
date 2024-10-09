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
        // Các danh sách sản phẩm cho từng tab
        //private List<SanPham> sanPhamTab1 = new List<SanPham>();
        //private List<SanPham> sanPhamTab2 = new List<SanPham>();
        //private List<SanPham> sanPhamTab3 = new List<SanPham>();
        //private List<SanPham> sanPhamTab4 = new List<SanPham>();
        //List<Voucher> voucherList;
        public Voucher vc;


        public Form_AddPromotion(List<SanPham> sanPhamList)
        {
            InitializeComponent();
            vc=new Voucher();
            this.sanPhamList = sanPhamList;
            LoadDataToGrid(this.sanPhamList);          
            txtMaKM_Tab1.Enabled = false;
            MaKM_Tab3.Enabled=false;
            MaKM_Tab4.Enabled=false;
            MaKM_Tab2.Enabled=false;
            LoadCBB();
            viewDataPromotion();
            
        }
        
        public void AddVoucher(Voucher voucher)
        {
           
            dgview_Voucher_Tab4.Rows.Add(voucher.GiftCode,voucher.NgayBatDau,voucher.NgayKetThuc,voucher.GiamGia);
             
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

        public void AddSanPhamToList_Tab2(List<SanPham> sanPhamList)
        {
            foreach (var sanPham in sanPhamList)
            {
                // Kiểm tra nếu sản phẩm đã tồn tại trước khi thêm
                bool exists =dgview_Sp_Tab2.Rows.Cast<DataGridViewRow>()
                    .Any(row => row.Cells["MaSPTab2"].Value.ToString() == sanPham.MaSP);

                if (!exists)
                {
                    dgview_Sp_Tab2.Rows.Add(sanPham.MaSP, sanPham.TenSP, sanPham.GiaBan);
                }
            }
        }

        public void AddSanPhamToList_Tab2QT(List<SanPham> sanPhamTab2)
        {
            foreach (var sanPham in sanPhamTab2)
            {
                // Kiểm tra nếu sản phẩm đã tồn tại trước khi thêm
                bool exists = dgview_QuaTang_Tab2.Rows.Cast<DataGridViewRow>()
                    .Any(row => row.Cells["MaSP_Tab2QT"].Value.ToString() == sanPham.MaSP);

                if (!exists)
                {
                    dgview_QuaTang_Tab2.Rows.Add(sanPham.MaSP, sanPham.TenSP, sanPham.GiaBan);
                }
            }
        }

        public void AddSanPhamToList_Tab4(List<SanPham> sanPhamList)
        {
            foreach (var sanPham in sanPhamList)
            {
                // Kiểm tra nếu sản phẩm đã tồn tại trước khi thêm
                bool exists = dgview_SP_Tab4.Rows.Cast<DataGridViewRow>()
                    .Any(row => row.Cells["MaSP_Tab4"].Value.ToString() == sanPham.MaSP);

                if (!exists)
                {
                    dgview_SP_Tab4.Rows.Add(sanPham.MaSP, sanPham.TenSP, sanPham.GiaBan);
                }
            }
        }
        public void AddSanPhamToList_Tab4_Voucher(List<SanPham> sanPhamList)
        {
            foreach (var sanPham in sanPhamList)
            {
                // Kiểm tra nếu sản phẩm đã tồn tại trước khi thêm
                bool exists = dgview_Voucher_Tab4.Rows.Cast<DataGridViewRow>()
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
            form_AddProductPromotion.flag = 2;
            form_AddProductPromotion.ShowDialog();
        }

        private void btnThemQT_Click(object sender, EventArgs e)
        {
            Form_AddProductPromotion form_AddProductPromotion = new Form_AddProductPromotion();
            form_AddProductPromotion.flag = 22;
            form_AddProductPromotion.ShowDialog();
        }

        private void btnThemVoucher_Click(object sender, EventArgs e)
        {
            Form_AddVourcher form_AddVourcher = new Form_AddVourcher();
            form_AddVourcher.ShowDialog();
        }

        private void btnAddProduct_Tab4_Click(object sender, EventArgs e)
        {
            Form_AddProductPromotion form_AddProductPromotion = new Form_AddProductPromotion();
            form_AddProductPromotion.flag = 4;
            form_AddProductPromotion.ShowDialog();
        }

        private void LoadCBB()
        {
            DAO_LoaiKhuyenMai daoLoaiKhuyenMai = new DAO_LoaiKhuyenMai();
            List<KeyValuePair<string, string>> loaiKhuyenMaiList = daoLoaiKhuyenMai.GetLoaiKhuyenMai();

            cbbkhuyenmai_Tab1.DataSource = loaiKhuyenMaiList;
            cbbkhuyenmai_Tab1.DisplayMember = "Value";
            cbbkhuyenmai_Tab1.ValueMember = "Key";

            cbbkhuyenmai_Tab2.DataSource = loaiKhuyenMaiList;
            cbbkhuyenmai_Tab2.DisplayMember = "Value";
            cbbkhuyenmai_Tab2.ValueMember = "Key";

            cbbkhuyenmai_Tab3.DataSource = loaiKhuyenMaiList;
            cbbkhuyenmai_Tab3.DisplayMember = "Value";
            cbbkhuyenmai_Tab3.ValueMember = "Key";

            cbbkhuyenmai_Tab4.DataSource = loaiKhuyenMaiList;
            cbbkhuyenmai_Tab4.DisplayMember = "Value";
            cbbkhuyenmai_Tab4.ValueMember = "Key";
        }


        private async void ThemKhuyenMai_Tab1()
        {
            string makm = txtMaKM_Tab1.Text;
            string tenkm=txtTenKM_Tab1.Text;
            string maloai=cbbkhuyenmai_Tab1.SelectedValue.ToString();
            // Thiết lập định dạng cho DateTimePicker
            date_NgayBD_Tab1.Format = DateTimePickerFormat.Custom;
            date_NgayBD_Tab1.CustomFormat = "dd/MM/yyyy";
            // Lấy giá trị từ DateTimePicker
            DateTime ngaybd = date_NgayBD_Tab1.Value;

            date_KetThuc_Tab1.Format=DateTimePickerFormat.Custom;
            date_KetThuc_Tab1.CustomFormat = "dd/MM/yyyy";
            DateTime ngaykt = date_KetThuc_Tab1.Value;

            List<SanPham> sanPhamList = new List<SanPham>();
            foreach (DataGridViewRow item in dgviewm_listSanPham.Rows)
            {
                SanPham sp = new SanPham()
                {
                    MaSP = item.Cells[0].Value.ToString(),
                    TenSP = item.Cells[1].Value.ToString(),
                    GiaBan = int.Parse(item.Cells[2].Value.ToString())
                };
                sanPhamList.Add(sp);

            }
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

        private async void ThemKhuyenMai_Tab3()
        {
            string makm = MaKM_Tab3.Text;
            string tenkm = TenKM_Tab3.Text;
            string maloai = cbbkhuyenmai_Tab3.SelectedValue.ToString();
            // Thiết lập định dạng cho DateTimePicker
            NgayBD_Tab3.Format = DateTimePickerFormat.Custom;
            NgayBD_Tab3.CustomFormat = "dd/MM/yyyy";
            // Lấy giá trị từ DateTimePicker
            DateTime ngaybd = date_NgayBD_Tab1.Value;

            NgayKT_Tab3.Format = DateTimePickerFormat.Custom;
            NgayKT_Tab3.CustomFormat = "dd/MM/yyyy";
            DateTime ngaykt = date_KetThuc_Tab1.Value;

            string hinhthuc = HinhThuc_Tab3.Text;
            decimal tttt = decimal.Parse(txtTongTienTT_Tab3.Text);
            float giamgia = float.Parse(Giamgia_Tab3.Text);

            KhuyenMai km = new KhuyenMai()
            {
                MaKM = GenerateRandomKhuyenMaiId(),
                TenKM = tenkm,
                MaLoaiKM = maloai,
                NgayBatDau = ngaybd,
                NgayKetThuc = ngaykt,
                DieuKien = new DieuKien()
                {                  
                    TongTienToiThieu = tttt,
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

        private async void ThemKhuyenMai_Tab2()
        {
            string makm = MaKM_Tab2.Text;
            string tenkm = TenKM_Tab2.Text;
            string maloai = cbbkhuyenmai_Tab3.SelectedValue.ToString();
            // Thiết lập định dạng cho DateTimePicker
            NgayBD_Tab3.Format = DateTimePickerFormat.Custom;
            NgayBD_Tab3.CustomFormat = "dd/MM/yyyy";
            // Lấy giá trị từ DateTimePicker
            DateTime ngaybd = date_NgayBD_Tab1.Value;

            NgayKT_Tab3.Format = DateTimePickerFormat.Custom;
            NgayKT_Tab3.CustomFormat = "dd/MM/yyyy";
            DateTime ngaykt = date_KetThuc_Tab1.Value;

            string hinhthuc = HinhThuc_Tab3.Text;
            int sltt = int.Parse(sltt_Tab2.Text);

            List<SanPham> SanPhamMua = new List<SanPham>();
            foreach (DataGridViewRow item in dgview_Sp_Tab2.Rows)
            {
                SanPham sp = new SanPham()
                {
                    MaSP = item.Cells[0].Value.ToString(),
                    TenSP = item.Cells[1].Value.ToString(),
                    GiaBan = int.Parse(item.Cells[2].Value.ToString())
                };
                SanPhamMua.Add(sp);

            }

            List<SanPham> SanPhamQT = new List<SanPham>();
            foreach (DataGridViewRow item in dgview_QuaTang_Tab2.Rows)
            {
                SanPham sp = new SanPham()
                {
                    MaSP = item.Cells[0].Value.ToString(),
                    TenSP = item.Cells[1].Value.ToString(),
                    GiaBan = int.Parse(item.Cells[2].Value.ToString())
                };
                SanPhamQT.Add(sp);
            }
            KhuyenMai km = new KhuyenMai()
            {
                MaKM = GenerateRandomKhuyenMaiId(),
                TenKM = tenkm,
                MaLoaiKM = maloai,
                NgayBatDau = ngaybd,
                NgayKetThuc = ngaykt,
                DieuKien = new DieuKien()
                {
                    SanPham = SanPhamMua,
                    SoLuongToiThieu = sltt,
                },
                QuaTang = SanPhamQT,
               
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

        private async void ThemKhuyenMai_Tab4()
        {
            string makm = MaKM_Tab4.Text;
            string tenkm = TenKM_Tab4.Text;
            string maloai = cbbkhuyenmai_Tab4.SelectedValue.ToString();
            // Thiết lập định dạng cho DateTimePicker
            NgayBD_Tab4.Format = DateTimePickerFormat.Custom;
            NgayBD_Tab4.CustomFormat = "dd/MM/yyyy";
            // Lấy giá trị từ DateTimePicker
            DateTime ngaybd = date_NgayBD_Tab1.Value;

            NgayKT_Tab4.Format = DateTimePickerFormat.Custom;
            NgayKT_Tab4.CustomFormat = "dd/MM/yyyy";
            DateTime ngaykt = date_KetThuc_Tab1.Value;

            string hinhthuc = HinhThuc_Tab4.Text;
            int? sltt = int.Parse(sltt_Tab4.Text);
            
            List<SanPham> SanPhamMua = new List<SanPham>();
            foreach (DataGridViewRow item in dgview_SP_Tab4.Rows)
            {
                SanPham sp = new SanPham()
                {
                    MaSP = item.Cells[0].Value.ToString(),
                    TenSP = item.Cells[1].Value.ToString(),
                    GiaBan = int.Parse(item.Cells[2].Value.ToString())
                };
                SanPhamMua.Add(sp);

            }
            //// Lấy giá trị ngày từ DataGridView
            //string ngayBatDauStr = dgview_Voucher_Tab4.Rows[0].Cells[1].Value.ToString();
            //string ngayKetThucStr = dgview_Voucher_Tab4.Rows[0].Cells[2].Value.ToString();

            //// Chuyển đổi chuỗi thành DateTime với định dạng dd/MM/yyyy
            //DateTime ngaybd1 = DateTime.ParseExact(ngayBatDauStr, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //DateTime ngaykt1 = DateTime.ParseExact(ngayKetThucStr, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            //Voucher vc = new Voucher()
            //    {
            //        GiftCode = dgview_Voucher_Tab4.Rows[0].Cells[0].Value.ToString(),
            //        NgayBatDau=ngaybd1,           
            //        NgayKetThuc = ngaykt1,
            //        GiamGia = float.Parse(dgview_Voucher_Tab4.Rows[0].Cells[3].Value.ToString())
            // };

               
           
            KhuyenMai km = new KhuyenMai()
            {
                MaKM = GenerateRandomKhuyenMaiId(),
                TenKM = tenkm,
                MaLoaiKM = maloai,
                NgayBatDau = ngaybd,
                NgayKetThuc = ngaykt,
                DieuKien = new DieuKien()
                {
                    SanPham = SanPhamMua,
                    SoLuongToiThieu = sltt,
                }, 
                Voucher=vc,

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

        private void BtnLuu_Tab3_Click_1(object sender, EventArgs e)
        {
            ThemKhuyenMai_Tab3();
        }

        private void BtnLuu_Tab2_Click(object sender, EventArgs e)
        {
            ThemKhuyenMai_Tab2();
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            ThemKhuyenMai_Tab4();
        }

        private void viewDataPromotion()
        {
            var daoKhuyenMai = new DAO_KhuyenMai_Tab1();
            List<KhuyenMai> khuyenMaiList = daoKhuyenMai.GetListKhuyenMai();
            dgvPro.DataSource = khuyenMaiList;
        }

        private void dgvPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedRow = dgvPro.Rows[e.RowIndex];
                string maKM = selectedRow.Cells["MaKM"].Value.ToString();
                string tenKM = selectedRow.Cells["TenKM"].Value.ToString();
                string maLoai = selectedRow.Cells["MaLoaiKM"].Value.ToString();
                DateTime ngayBatDau = Convert.ToDateTime(selectedRow.Cells["NgayBatDau"].Value);
                DateTime ngayKetThuc = Convert.ToDateTime(selectedRow.Cells["NgayKetThuc"].Value);
                double giamGia = double.Parse(selectedRow.Cells["GiamGia"].Value.ToString());

                if (maLoai == "LoaiKM01")
                {
                    tabPromotion.SelectedTab = LKM01;
                    MaKM_Tab3.Text = maKM;
                    TenKM_Tab3.Text = tenKM;
                    NgayBD_Tab3.Value = ngayBatDau;
                    NgayKT_Tab3.Value = ngayKetThuc;
                    Giamgia_Tab3.Text = giamGia.ToString();
                    cbbkhuyenmai_Tab3.SelectedIndex = 0;
                    //DieuKien
                    if (selectedRow.Cells["DieuKien"].Value != null)
                    {
                        var dieukien = selectedRow.Cells["DieuKien"].Value as DieuKien;
                        if (dieukien != null)
                        {
                            txtTongTienTT_Tab3.Text = dieukien.TongTienToiThieu?.ToString();
                        }
                    }
                }
                else if (maLoai == "LoaiKM02")
                {
                    tabPromotion.SelectedTab = LKM02;
                    txtMaKM_Tab1.Text = maKM;
                    txtTenKM_Tab1.Text = tenKM;
                    date_NgayBD_Tab1.Value = ngayBatDau;
                    date_KetThuc_Tab1.Value = ngayKetThuc;
                    txtGiamGia_Tab1.Text = giamGia.ToString();
                    cbbkhuyenmai_Tab3.SelectedIndex = 1;
                    //DieuKien
                    if (selectedRow.Cells["DieuKien"].Value != null)
                    {
                        var dieukien = selectedRow.Cells["DieuKien"].Value as DieuKien;
                        if (dieukien != null)
                        {
                            txtSoLuongTT_Tab1.Text = dieukien.SoLuongToiThieu?.ToString();
                            //SanPham
                            if (dieukien.SanPham != null && dieukien.SanPham.Count > 0)
                            {
                               dgviewm_listSanPham.Rows.Clear();
                                foreach (var sanPham in dieukien.SanPham)
                                {
                                    dgviewm_listSanPham.Rows.Add(sanPham.MaSP, sanPham.TenSP, sanPham.GiaBan);
                                }
                            }
                        }
                    }
                }
                else if (maLoai == "LoaiKM03")
                {
                    tabPromotion.SelectedTab = LKM03;
                    MaKM_Tab2.Text = maKM;
                    TenKM_Tab2.Text = tenKM;
                    NgayBD_Tab2.Value = ngayBatDau;
                    NgayKT_Tab2.Value = ngayKetThuc;
                    cbbkhuyenmai_Tab3.SelectedIndex = 2;
                    //DieuKien
                    if (selectedRow.Cells["DieuKien"].Value != null)
                    {
                        var dieukien = selectedRow.Cells["DieuKien"].Value as DieuKien;
                        if (dieukien != null)
                        {
                            sltt_Tab2.Text = dieukien.SoLuongToiThieu?.ToString();
                            //SanPham
                            if (dieukien.SanPham != null && dieukien.SanPham.Count > 0)
                            {
                                dgview_Sp_Tab2.Rows.Clear();
                                foreach (var sanPham in dieukien.SanPham)
                                {
                                    dgview_Sp_Tab2.Rows.Add(sanPham.MaSP, sanPham.TenSP, sanPham.GiaBan);
                                }
                            }
                        }
                    }
                    //QuaTang
                    if (selectedRow.Cells["QuaTang"].Value != null)
                    {
                        var quaTang = selectedRow.Cells["QuaTang"].Value as ICollection<SanPham>;
                        if (quaTang != null && quaTang.Count > 0)
                        {
                            dgview_QuaTang_Tab2.Rows.Clear();
                            foreach (var sanPham in quaTang)
                            {
                                dgview_QuaTang_Tab2.Rows.Add(sanPham.MaSP, sanPham.TenSP, sanPham.GiaBan);
                            }
                        }
                    }
                }
                else
                {
                    tabPromotion.SelectedTab = LKM04;
                    MaKM_Tab4.Text = maKM;
                    TenKM_Tab4.Text = tenKM;
                    NgayBD_Tab4.Value = ngayBatDau;
                    NgayKT_Tab4.Value = ngayKetThuc;
                    cbbkhuyenmai_Tab4.SelectedIndex = 3;
                    //DieuKien
                    if (selectedRow.Cells["DieuKien"].Value != null)
                    {
                        var dieukien = selectedRow.Cells["DieuKien"].Value as DieuKien;
                        if (dieukien != null)
                        {
                            sltt_Tab4.Text = dieukien.SoLuongToiThieu?.ToString();
                            tttt_Tab4.Text = dieukien.TongTienToiThieu?.ToString();
                            //SanPham
                            if (dieukien.SanPham != null)
                            {
                                dgview_SP_Tab4.Rows.Clear();
                                foreach (var sanPham in dieukien.SanPham)
                                {
                                    dgview_SP_Tab4.Rows.Add(sanPham.MaSP, sanPham.TenSP, sanPham.GiaBan);
                                }
                            }
                        }
                    }
                    //QuaTang
                    if (selectedRow.Cells["Voucher"].Value != null)
                    {
                        var voucher = selectedRow.Cells["Voucher"].Value as Voucher;
                        if (voucher != null)
                        {
                            dgview_Voucher_Tab4.Rows.Clear();
                            dgview_Voucher_Tab4.Rows.Add(voucher.GiftCode,voucher.GiamGia,voucher.NgayBatDau,voucher.NgayKetThuc);
                        }
                    }
                }    
            }
        }
    }

}
