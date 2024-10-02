using Guna.UI2.WinForms;
using MongoDB.Driver;
using promotion_management_app.BASE;
using promotion_management_app.DAO;
using promotion_management_app.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using static promotion_management_app.DTO.DTO_SanPham;
using static promotion_management_app.DTO.DTO_LoaiSanPham;

namespace promotion_management_app.GUI
{
    public partial class Form_Sell : Form
    {
        DAO_SanPham daoSanPham = new DAO_SanPham();
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private List<SanPham> productList;
        private List<SanPham> allProducts; // Lưu trữ danh sách tất cả sản phẩm
        

        public Form_Sell()
        {
            InitializeComponent();
            loadDataSanPham();
            LoadCBB();
            cbbLoai.SelectedIndexChanged += CbbLoai_SelectedIndexChanged;
            txtSearchSP.TextChanged += TxtSearchSP_TextChanged;
            dgviewm_listSanPham.UserDeletedRow += Dgviewm_listSanPham_UserDeletedRow;
            dgviewm_listSanPham.CellValueChanged += Dgviewm_listSanPham_CellValueChanged;
        }

        private void Dgviewm_listSanPham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex>=0)
            {
                calculateDiscount();           
            }    
        }

        private void Dgviewm_listSanPham_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calculateDiscount();
        }


        private void TxtSearchSP_TextChanged(object sender, EventArgs e)
        {
            loadDataSanPham();
        }

        private void CbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataSanPham();
        }

        private async void TimKiemKhachHang()
        {
            // Lấy số điện thoại từ TextBox
            string sdt = txtSoDienThoai.Text.Trim();

            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DAO_KhachHang daoKhachHang = new DAO_KhachHang();

            // Tìm khách hàng theo SDT
            var khachHang = await daoKhachHang.FindKhachHangBySDT(sdt);

            if (khachHang != null)
            {
                // Nếu tìm thấy, hiển thị tên khách hàng vào TextBox
                txtTenKhachHang.Text = khachHang.TenKH;
            }
            else
            {
                // Nếu không tìm thấy, thông báo
                MessageBox.Show("Khách hàng không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhachHang.Clear(); // Xóa nội dung TextBox tên khách hàng
            }
        }

        private void LoadCBB()
        {
            DAO_LoaiSanPham daoLoaiSanPham = new DAO_LoaiSanPham();
            List<KeyValuePair<string, string>> loaiSanPhamList = daoLoaiSanPham.GetLoaiSanPham();
            loaiSanPhamList.Insert(0, new KeyValuePair<string, string>("All", "Tất cả"));
            
            cbbLoai.DataSource = loaiSanPhamList;
            cbbLoai.DisplayMember = "Value";
            cbbLoai.ValueMember = "Key";            
        }

        private void loadDataSanPham()
        {          
            allProducts = daoSanPham.GetListSanPham();

            string selectedMaLoaiSP = cbbLoai.SelectedValue?.ToString();
            string searchKeyword = txtSearchSP.Text.Trim().ToLower(); 

            // Lọc sản phẩm theo LoaiSP nếu có chọn
            if (!string.IsNullOrEmpty(selectedMaLoaiSP) && selectedMaLoaiSP != "All")
            {
                productList = allProducts.Where(p => p.LoaiSP == selectedMaLoaiSP).ToList();
            }
            else
            {
                productList = allProducts;
            }

            // Lọc sản phẩm theo tên sản phẩm nếu từ khóa tìm kiếm không rỗng
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                productList = productList.Where(p => p.TenSP.ToLower().Contains(searchKeyword)).ToList();
            }

            // Tính toán số trang dựa trên số lượng sản phẩm đã lọc và số sản phẩm trên mỗi trang
            int totalPages = (int)Math.Ceiling((double)productList.Count / itemsPerPage);

            // Lấy các sản phẩm cho trang hiện tại
            var productsToShow = productList
                .Skip((currentPage - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToList();

            // Xóa các điều khiển hiện tại và thêm sản phẩm mới
            panel_SanPham.Controls.Clear();
            FlowLayoutPanel flowLayoutPanel = CreateProductsFlowPanel(productsToShow);
            panel_SanPham.Controls.Add(flowLayoutPanel);

            // Xóa các điều khiển phân trang hiện tại
            panel_layoutPage.Controls.Clear();

            // Tạo và thêm các nút phân trang (Previous, Page Buttons, Next)
            CreatePaginationControls(totalPages);
        }



        private void CreatePaginationControls(int totalPages)
        {
            // Tạo và thêm nút trang trước
            Guna2Button prevButton = new Guna2Button
            {
                Text = "<",
                BorderRadius = 5,
                FillColor = Color.LightGray,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                ForeColor = Color.Black,
                Size = new Size(50, 40),
                Enabled = currentPage > 1,
                Margin = new Padding(5)
            };
            prevButton.Click += (s, e) =>
            {
                if (currentPage > 1)
                {
                    currentPage--;
                    loadDataSanPham();
                }
            };
            panel_layoutPage.Controls.Add(prevButton);

            // Tạo và thêm nút phân trang
            for (int i = 1; i <= totalPages; i++)
            {
                Guna2Button pageButton = new Guna2Button
                {
                    Text = i.ToString(),
                    BorderRadius = 5,
                    FillColor = Color.LightGray,
                    Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Size = new Size(50, 40),
                    Tag = i,
                    Margin = new Padding(5)
                };
                pageButton.Click += PageButton_Click;

                // Tô màu nút trang hiện tại
                if (i == currentPage)
                {
                    pageButton.FillColor = Color.CornflowerBlue;
                    pageButton.ForeColor = Color.White;
                }
                panel_layoutPage.Controls.Add(pageButton);
            }

            // Tạo và thêm nút trang tiếp theo
            Guna2Button nextButton = new Guna2Button
            {
                Text = ">",
                BorderRadius = 5,
                FillColor = Color.LightGray,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                ForeColor = Color.Black,
                Size = new Size(50, 40),
                Enabled = currentPage < totalPages,
                Margin = new Padding(5)
            };
            nextButton.Click += (s, e) =>
            {
                if (currentPage < totalPages)
                {
                    currentPage++;
                    loadDataSanPham();
                }
            };
            panel_layoutPage.Controls.Add(nextButton);
        }

        private FlowLayoutPanel CreateProductsFlowPanel(IEnumerable<SanPham> products)
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                AutoScroll = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Padding = new Padding(40, 50, 30, 30),
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Margin = new Padding(0)
            };

            foreach (var product in products)
            {
                flowLayoutPanel.Controls.Add(CreateProductPanel(product));
            }

            panel_SanPham.Controls.Clear();
            panel_SanPham.Controls.Add(flowLayoutPanel);
            flowLayoutPanel.Dock = DockStyle.Fill;

            return flowLayoutPanel;
        }
        private void PageButton_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            if (clickedButton != null)
            {
                currentPage = (int)clickedButton.Tag;
                loadDataSanPham();
            }
        }
        private Panel CreateProductPanel(SanPham product)
        {
            Panel productPanel = new Panel
            {
                Size = new Size(150, 200),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                BackColor = Color.Gray,
                Tag = product
            };

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(150, 150),
                SizeMode = PictureBoxSizeMode.StretchImage,
                ImageLocation = product.HinhAnh.Split(',').FirstOrDefault(),
                Dock = DockStyle.Top
            };

            Label nameLabel = new Label
            {
                Text = product.TenSP,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                ForeColor = Color.White,
            };

            Label priceLabel = new Label
            {
                Text = $"{MyLib.AddCommas(product.GiaBan):C}",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                ForeColor = Color.White

            };

            productPanel.Controls.Add(priceLabel);
            productPanel.Controls.Add(nameLabel);
            productPanel.Controls.Add(pictureBox);

            pictureBox.Click += (s, e) =>
            {
                var selectedProduct = productPanel.Tag as SanPham;
                if (selectedProduct != null)
                {
                    var result = MessageBox.Show($"Bạn có muốn thêm sản phẩm {selectedProduct.TenSP} vào danh sách ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        insertProductToDTGV(selectedProduct);
                    }
                }
            };

            return productPanel;
        }
        private void insertProductToDTGV(SanPham product)
        {
            if (dgviewm_listSanPham == null)
            {
                MessageBox.Show("DataGridView is not initialized");
                return;
            }

            foreach (DataGridViewRow row in dgviewm_listSanPham.Rows)
            {
                if (row.IsNewRow) continue;
                if ((row.Cells["MaSP"].Value) == product.MaSP)
                {
                    int currentQuantity = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    row.Cells["SoLuong"].Value = currentQuantity + 1;
                    calculateDiscount();
                    return;
                }
            }

            dgviewm_listSanPham.Rows.Add(product.MaSP, product.TenSP, product.GiaBan, null, 1, null, product.MaSP);
            calculateDiscount();
        }

        private void calculateDiscount()
        {
            foreach (DataGridViewRow row in dgviewm_listSanPham.Rows)
            {
                if (row.IsNewRow) continue;

                string maSP = row.Cells["MaSP"].Value.ToString();
               // int maKM = Convert.ToInt32(row.Cells["MaKM"].Value);
                int SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                var sanPham = daoSanPham.GetSanPhamByMaSP(maSP);
               // var khuyenMai = kmb.LoadKM().FirstOrDefault(km => km.MaKM == sanPham.MaKM);

                //decimal soTienKhuyenMai = 0;
                //if (khuyenMai != null)
                //{
                //    soTienKhuyenMai = (decimal)SoLuong * (decimal)sanPham.GiaSP * ((decimal)khuyenMai.GiamGia / 100);
                //}

                //row.Cells["KhuyenMai"].Value = soTienKhuyenMai;

            }
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            decimal totalAmount = 0;
            decimal totalDiscount = 0;
            foreach (DataGridViewRow row in dgviewm_listSanPham.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["SoLuong"].Value != null && row.Cells["GiaSP"].Value != null )
                {
                    int quantity = 0;
                    decimal price = 0;
                    decimal discount = 0;

                    if (int.TryParse(row.Cells["SoLuong"].Value.ToString(), out quantity) &&
                        decimal.TryParse(row.Cells["GiaSP"].Value.ToString(), out price) )
                        //decimal.TryParse(row.Cells["KhuyenMai"].Value.ToString(), out discount))
                    {
                        // Apply discount to price
                        decimal discountedPrice = quantity * price - discount;
                        totalAmount += discountedPrice;
                        totalDiscount += discount;
                    }
                    else
                    {
                        MessageBox.Show("Invalid data in DataGridView");
                    }
                }
            }
            txtTongTien.Text = MyLib.AddCommas(totalAmount);
            txtKhuyenMai.Text = " - " + MyLib.AddCommas(totalDiscount);

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            TimKiemKhachHang();
        }
    }
}