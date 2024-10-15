using System.Windows.Forms;

namespace promotion_management_app.GUI
{
    partial class Form_Sell : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GiaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_SanPham = new Guna.UI2.WinForms.Guna2Panel();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaNB = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKhuyenMai = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbbLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnThanhToanInHD = new Guna.UI2.WinForms.Guna2GradientButton();
            this.KhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgviewm_listSanPham = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaNB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_layoutPage = new System.Windows.Forms.FlowLayoutPanel();
            this.check_promotion = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbb_KhuyenMai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_InHoaDon = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewm_listSanPham)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayout_InHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // GiaSP
            // 
            this.GiaSP.DataPropertyName = "GiaSP";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.GiaSP.DefaultCellStyle = dataGridViewCellStyle1;
            this.GiaSP.DividerWidth = 1;
            this.GiaSP.HeaderText = "Giá Sản Phẩm";
            this.GiaSP.MinimumWidth = 6;
            this.GiaSP.Name = "GiaSP";
            this.GiaSP.ReadOnly = true;
            // 
            // panel_SanPham
            // 
            this.panel_SanPham.BackColor = System.Drawing.Color.White;
            this.panel_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SanPham.Location = new System.Drawing.Point(4, 207);
            this.panel_SanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_SanPham.Name = "panel_SanPham";
            this.panel_SanPham.Size = new System.Drawing.Size(739, 678);
            this.panel_SanPham.TabIndex = 6;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.DividerWidth = 1;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.Navy;
            this.guna2Panel7.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel7.Location = new System.Drawing.Point(751, 153);
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(552, 44);
            this.guna2Panel7.TabIndex = 5;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(196, 7);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(113, 21);
            this.guna2HtmlLabel5.TabIndex = 0;
            this.guna2HtmlLabel5.Text = "Danh dách đơn hàng";
            // 
            // MaKM
            // 
            this.MaKM.DataPropertyName = "MaKM";
            this.MaKM.HeaderText = "MaKM";
            this.MaKM.MinimumWidth = 6;
            this.MaKM.Name = "MaKM";
            this.MaKM.Visible = false;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Navy;
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel6.Location = new System.Drawing.Point(4, 153);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(739, 44);
            this.guna2Panel6.TabIndex = 4;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(284, 9);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(116, 21);
            this.guna2HtmlLabel4.TabIndex = 0;
            this.guna2HtmlLabel4.Text = "Danh sách sản phẩm";
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "MaSP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Visible = false;
            // 
            // txtMaNB
            // 
            this.txtMaNB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMaNB.BackColor = System.Drawing.Color.White;
            this.txtMaNB.BorderColor = System.Drawing.Color.Black;
            this.txtMaNB.BorderRadius = 8;
            this.txtMaNB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNB.DefaultText = "";
            this.txtMaNB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNB.FocusedState.FillColor = System.Drawing.Color.Red;
            this.txtMaNB.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtMaNB.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMaNB.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNB.ForeColor = System.Drawing.Color.Black;
            this.txtMaNB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNB.Location = new System.Drawing.Point(4, 33);
            this.txtMaNB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNB.Name = "txtMaNB";
            this.txtMaNB.PasswordChar = '\0';
            this.txtMaNB.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMaNB.PlaceholderText = "Mã hóa đơn .....";
            this.txtMaNB.SelectedText = "";
            this.txtMaNB.Size = new System.Drawing.Size(283, 44);
            this.txtMaNB.TabIndex = 0;
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtKhuyenMai.BackColor = System.Drawing.Color.White;
            this.txtKhuyenMai.BorderColor = System.Drawing.Color.Black;
            this.txtKhuyenMai.BorderRadius = 8;
            this.txtKhuyenMai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKhuyenMai.DefaultText = "";
            this.txtKhuyenMai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKhuyenMai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKhuyenMai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKhuyenMai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKhuyenMai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKhuyenMai.FocusedState.FillColor = System.Drawing.Color.Red;
            this.txtKhuyenMai.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtKhuyenMai.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtKhuyenMai.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhuyenMai.ForeColor = System.Drawing.Color.Black;
            this.txtKhuyenMai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKhuyenMai.Location = new System.Drawing.Point(4, 123);
            this.txtKhuyenMai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.PasswordChar = '\0';
            this.txtKhuyenMai.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtKhuyenMai.PlaceholderText = "";
            this.txtKhuyenMai.SelectedText = "";
            this.txtKhuyenMai.Size = new System.Drawing.Size(283, 45);
            this.txtKhuyenMai.TabIndex = 0;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.GhostWhite;
            this.guna2Panel5.BorderRadius = 20;
            this.guna2Panel5.Controls.Add(this.btnAdd);
            this.guna2Panel5.Controls.Add(this.btnSearch);
            this.guna2Panel5.Controls.Add(this.txtSoDienThoai);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.Location = new System.Drawing.Point(751, 57);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(552, 87);
            this.guna2Panel5.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BorderRadius = 8;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(439, 21);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 49);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnSearch.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(325, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 49);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoDienThoai.BorderColor = System.Drawing.Color.Gray;
            this.txtSoDienThoai.BorderRadius = 8;
            this.txtSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoai.DefaultText = "";
            this.txtSoDienThoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDienThoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDienThoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai.Location = new System.Drawing.Point(4, 23);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSoDienThoai.MaximumSize = new System.Drawing.Size(600, 49);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.PasswordChar = '\0';
            this.txtSoDienThoai.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSoDienThoai.PlaceholderText = "Nhập số điện thoại .......";
            this.txtSoDienThoai.SelectedText = "";
            this.txtSoDienThoai.Size = new System.Drawing.Size(313, 44);
            this.txtSoDienThoai.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.BorderColor = System.Drawing.Color.Black;
            this.txtTongTien.BorderRadius = 8;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.DefaultText = "";
            this.txtTongTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.FocusedState.FillColor = System.Drawing.Color.Red;
            this.txtTongTien.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtTongTien.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTongTien.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Black;
            this.txtTongTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.Location = new System.Drawing.Point(295, 123);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PasswordChar = '\0';
            this.txtTongTien.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTongTien.PlaceholderText = "Tổng tiền ....";
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.Size = new System.Drawing.Size(253, 45);
            this.txtTongTien.TabIndex = 0;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTenKhachHang.BackColor = System.Drawing.Color.White;
            this.txtTenKhachHang.BorderColor = System.Drawing.Color.Black;
            this.txtTenKhachHang.BorderRadius = 8;
            this.txtTenKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhachHang.DefaultText = "";
            this.txtTenKhachHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhachHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhachHang.FocusedState.FillColor = System.Drawing.Color.Red;
            this.txtTenKhachHang.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtTenKhachHang.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.ForeColor = System.Drawing.Color.Black;
            this.txtTenKhachHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhachHang.Location = new System.Drawing.Point(295, 33);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.PasswordChar = '\0';
            this.txtTenKhachHang.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTenKhachHang.PlaceholderText = "Tên khách hàng ....";
            this.txtTenKhachHang.SelectedText = "";
            this.txtTenKhachHang.Size = new System.Drawing.Size(253, 44);
            this.txtTenKhachHang.TabIndex = 0;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.GhostWhite;
            this.guna2Panel4.BorderRadius = 5;
            this.guna2Panel4.Controls.Add(this.cbbLoai);
            this.guna2Panel4.Controls.Add(this.txtSearchSP);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(4, 57);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(739, 87);
            this.guna2Panel4.TabIndex = 2;
            // 
            // cbbLoai
            // 
            this.cbbLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoai.BorderRadius = 8;
            this.cbbLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoai.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoai.ForeColor = System.Drawing.Color.Black;
            this.cbbLoai.ItemHeight = 30;
            this.cbbLoai.Location = new System.Drawing.Point(408, 26);
            this.cbbLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbLoai.MaximumSize = new System.Drawing.Size(465, 0);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(329, 36);
            this.cbbLoai.TabIndex = 1;
            // 
            // txtSearchSP
            // 
            this.txtSearchSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchSP.BorderColor = System.Drawing.Color.Gray;
            this.txtSearchSP.BorderRadius = 8;
            this.txtSearchSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchSP.DefaultText = "";
            this.txtSearchSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchSP.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchSP.Location = new System.Drawing.Point(9, 26);
            this.txtSearchSP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearchSP.MaximumSize = new System.Drawing.Size(467, 49);
            this.txtSearchSP.Name = "txtSearchSP";
            this.txtSearchSP.PasswordChar = '\0';
            this.txtSearchSP.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearchSP.PlaceholderText = "Nhập tên sản phẩm .......";
            this.txtSearchSP.SelectedText = "";
            this.txtSearchSP.Size = new System.Drawing.Size(319, 44);
            this.txtSearchSP.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Navy;
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(4, 5);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(739, 42);
            this.guna2Panel2.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(284, 6);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(106, 21);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Tìm kiếm sản phẩm";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Navy;
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(751, 5);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(552, 42);
            this.guna2Panel3.TabIndex = 1;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(196, 6);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(114, 21);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Kiểm tra khách hàng";
            // 
            // btnThanhToanInHD
            // 
            this.btnThanhToanInHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThanhToanInHD.BorderRadius = 8;
            this.tableLayout_InHoaDon.SetColumnSpan(this.btnThanhToanInHD, 2);
            this.btnThanhToanInHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToanInHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToanInHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToanInHD.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToanInHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToanInHD.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnThanhToanInHD.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnThanhToanInHD.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToanInHD.ForeColor = System.Drawing.Color.White;
            this.btnThanhToanInHD.Location = new System.Drawing.Point(82, 180);
            this.btnThanhToanInHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThanhToanInHD.MaximumSize = new System.Drawing.Size(667, 49);
            this.btnThanhToanInHD.Name = "btnThanhToanInHD";
            this.btnThanhToanInHD.Size = new System.Drawing.Size(388, 49);
            this.btnThanhToanInHD.TabIndex = 4;
            this.btnThanhToanInHD.Text = "Thanh toán và in hóa đơn";
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.DataPropertyName = "KhuyenMai";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.KhuyenMai.DefaultCellStyle = dataGridViewCellStyle2;
            this.KhuyenMai.DividerWidth = 1;
            this.KhuyenMai.HeaderText = "Khuyến Mãi";
            this.KhuyenMai.MinimumWidth = 6;
            this.KhuyenMai.Name = "KhuyenMai";
            this.KhuyenMai.ReadOnly = true;
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.Color.White;
            this.guna2Panel9.Controls.Add(this.dgviewm_listSanPham);
            this.guna2Panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel9.Location = new System.Drawing.Point(751, 207);
            this.guna2Panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(552, 676);
            this.guna2Panel9.TabIndex = 7;
            // 
            // dgviewm_listSanPham
            // 
            this.dgviewm_listSanPham.AllowUserToAddRows = false;
            this.dgviewm_listSanPham.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgviewm_listSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgviewm_listSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgviewm_listSanPham.ColumnHeadersHeight = 40;
            this.dgviewm_listSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgviewm_listSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNB,
            this.TenSP,
            this.GiaSP,
            this.KhuyenMai,
            this.SoLuong,
            this.MaKM,
            this.MaSP});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewm_listSanPham.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgviewm_listSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgviewm_listSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgviewm_listSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgviewm_listSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.dgviewm_listSanPham.Name = "dgviewm_listSanPham";
            this.dgviewm_listSanPham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgviewm_listSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgviewm_listSanPham.RowHeadersVisible = false;
            this.dgviewm_listSanPham.RowHeadersWidth = 51;
            this.dgviewm_listSanPham.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgviewm_listSanPham.RowTemplate.Height = 40;
            this.dgviewm_listSanPham.Size = new System.Drawing.Size(552, 676);
            this.dgviewm_listSanPham.TabIndex = 3;
            this.dgviewm_listSanPham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgviewm_listSanPham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgviewm_listSanPham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgviewm_listSanPham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgviewm_listSanPham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgviewm_listSanPham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgviewm_listSanPham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgviewm_listSanPham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgviewm_listSanPham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgviewm_listSanPham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgviewm_listSanPham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgviewm_listSanPham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgviewm_listSanPham.ThemeStyle.HeaderStyle.Height = 40;
            this.dgviewm_listSanPham.ThemeStyle.ReadOnly = false;
            this.dgviewm_listSanPham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgviewm_listSanPham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgviewm_listSanPham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgviewm_listSanPham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgviewm_listSanPham.ThemeStyle.RowsStyle.Height = 40;
            this.dgviewm_listSanPham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgviewm_listSanPham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaNB
            // 
            this.MaNB.DataPropertyName = "MaNB";
            this.MaNB.DividerWidth = 1;
            this.MaNB.HeaderText = "Mã Sản Phẩm";
            this.MaNB.MinimumWidth = 6;
            this.MaNB.Name = "MaNB";
            this.MaNB.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.DividerWidth = 1;
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel_layoutPage, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.check_promotion, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbb_KhuyenMai, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 893);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(739, 236);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // panel_layoutPage
            // 
            this.panel_layoutPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_layoutPage.BackColor = System.Drawing.Color.White;
            this.panel_layoutPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel3.SetColumnSpan(this.panel_layoutPage, 2);
            this.panel_layoutPage.Location = new System.Drawing.Point(20, 84);
            this.panel_layoutPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_layoutPage.Name = "panel_layoutPage";
            this.panel_layoutPage.Size = new System.Drawing.Size(699, 68);
            this.panel_layoutPage.TabIndex = 0;
            // 
            // check_promotion
            // 
            this.check_promotion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.check_promotion.AutoSize = true;
            this.check_promotion.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_promotion.CheckedState.BorderRadius = 0;
            this.check_promotion.CheckedState.BorderThickness = 0;
            this.check_promotion.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_promotion.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_promotion.Location = new System.Drawing.Point(373, 182);
            this.check_promotion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check_promotion.Name = "check_promotion";
            this.check_promotion.Size = new System.Drawing.Size(153, 27);
            this.check_promotion.TabIndex = 2;
            this.check_promotion.Text = "guna2CheckBox1";
            this.check_promotion.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_promotion.UncheckedState.BorderRadius = 0;
            this.check_promotion.UncheckedState.BorderThickness = 0;
            this.check_promotion.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // cbb_KhuyenMai
            // 
            this.cbb_KhuyenMai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbb_KhuyenMai.BackColor = System.Drawing.Color.Transparent;
            this.cbb_KhuyenMai.BorderRadius = 8;
            this.cbb_KhuyenMai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_KhuyenMai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_KhuyenMai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_KhuyenMai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_KhuyenMai.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_KhuyenMai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_KhuyenMai.ItemHeight = 30;
            this.cbb_KhuyenMai.Location = new System.Drawing.Point(5, 178);
            this.cbb_KhuyenMai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_KhuyenMai.Name = "cbb_KhuyenMai";
            this.cbb_KhuyenMai.Size = new System.Drawing.Size(360, 36);
            this.cbb_KhuyenMai.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1307, 1294);
            this.guna2Panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.22892F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.77108F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel_SanPham, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayout_InHoaDon, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 686F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1307, 1157);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayout_InHoaDon
            // 
            this.tableLayout_InHoaDon.ColumnCount = 2;
            this.tableLayout_InHoaDon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.71868F));
            this.tableLayout_InHoaDon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.28132F));
            this.tableLayout_InHoaDon.Controls.Add(this.txtMaNB, 0, 1);
            this.tableLayout_InHoaDon.Controls.Add(this.txtKhuyenMai, 0, 3);
            this.tableLayout_InHoaDon.Controls.Add(this.txtTongTien, 1, 3);
            this.tableLayout_InHoaDon.Controls.Add(this.txtTenKhachHang, 1, 1);
            this.tableLayout_InHoaDon.Controls.Add(this.btnThanhToanInHD, 0, 4);
            this.tableLayout_InHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayout_InHoaDon.Location = new System.Drawing.Point(751, 893);
            this.tableLayout_InHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayout_InHoaDon.Name = "tableLayout_InHoaDon";
            this.tableLayout_InHoaDon.RowCount = 5;
            this.tableLayout_InHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.4878F));
            this.tableLayout_InHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.51219F));
            this.tableLayout_InHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayout_InHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayout_InHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayout_InHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayout_InHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayout_InHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayout_InHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayout_InHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayout_InHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayout_InHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayout_InHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayout_InHoaDon.Size = new System.Drawing.Size(552, 236);
            this.tableLayout_InHoaDon.TabIndex = 8;
            // 
            // Form_Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 1100);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Sell";
            this.Text = "Form_Sell";
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewm_listSanPham)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayout_InHoaDon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSP;
        private Guna.UI2.WinForms.Guna2Panel panel_SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKM;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNB;
        private Guna.UI2.WinForms.Guna2TextBox txtKhuyenMai;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoai;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTien;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKhachHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoai;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchSP;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2GradientButton btnThanhToanInHD;
        private System.Windows.Forms.TableLayoutPanel tableLayout_InHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuyenMai;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2DataGridView dgviewm_listSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel panel_layoutPage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2CheckBox check_promotion;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_KhuyenMai;
    }
}