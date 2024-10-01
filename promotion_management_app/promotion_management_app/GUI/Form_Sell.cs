using Guna.UI2.WinForms;
using MongoDB.Driver;
using promotion_management_app.BASE;
using promotion_management_app.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using static promotion_management_app.DTO.DTO_SanPham;

namespace promotion_management_app.GUI
{
    public partial class Form_Sell : Form
    {
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private List<SanPham> productList;

        public Form_Sell()
        {
            InitializeComponent();        
            loadDataSanPham();               
        }


        
        private void loadDataSanPham()
        {
            DTO_SanPham sanpham = new DTO_SanPham();
            IMongoCollection<SanPham> collection = sanpham.GetCollectionSanPham();

            var projection = Builders<SanPham>.Projection
                .Include(x => x.TenSP)
                .Include(x => x.HinhAnh)
                .Include(x => x.GiaBan)
                .Include(x => x.SoLuong);

            productList = collection
                .Find(Builders<SanPham>.Filter.Empty)
                .Project<SanPham>(projection)
                .ToList();
            // Calculate total pages based on the number of filtered products and items per page
            int totalPages = (int)Math.Ceiling((double)productList.Count / itemsPerPage);

            // Fetch products for the current page
            var productsToShow = productList
                .Skip((currentPage - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToList();

            // Clear existing controls and add new products
            panel_SanPham.Controls.Clear();
            FlowLayoutPanel flowLayoutPanel = CreateProductsFlowPanel(productsToShow);
            panel_SanPham.Controls.Add(flowLayoutPanel);

            // Clear existing pagination controls
            panel_layoutPage.Controls.Clear();

            // Create and add previous page button
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

            // Create and add page buttons
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

                // Highlight the current page button
                if (i == currentPage)
                {
                    pageButton.FillColor = Color.CornflowerBlue;
                    pageButton.ForeColor = Color.White;
                }
                panel_layoutPage.Controls.Add(pageButton);
            }

            // Create and add next page button
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

            // Configure layout settings
            panel_layoutPage.FlowDirection = FlowDirection.LeftToRight;
            panel_layoutPage.WrapContents = false;
            panel_layoutPage.AutoSize = true;
            panel_layoutPage.Anchor = AnchorStyles.None;
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
                       //insertProductToDTGV(selectedProduct);
                    }
                }
            };

            return productPanel;
        }
        
    }
}