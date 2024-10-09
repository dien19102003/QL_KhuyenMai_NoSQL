using System.Windows.Forms;
using System.Drawing;

namespace promotion_management_app.GUI
{
    partial class Form_Menu : Form
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.button8 = new System.Windows.Forms.Button();
            this.Resize_Admin = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.DragControl_Admin = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TableLayoutPanel_Header = new System.Windows.Forms.TableLayoutPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Label_Heading = new System.Windows.Forms.Label();
            this.BorderLess_Admin = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel_sidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel_Logo = new Guna.UI2.WinForms.Guna2Panel();
            this.TableLayoutPanel_Body = new System.Windows.Forms.TableLayoutPanel();
            this.panel_container = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel_MasterSanPham = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_KhuyenMai = new Guna.UI2.WinForms.Guna2Button();
            this.btn_BanHang = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel10 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_HeThong = new Guna.UI2.WinForms.Guna2Button();
            this.btn_DangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_TrangChu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.TableLayoutPanel_Header.SuspendLayout();
            this.panel_sidebar.SuspendLayout();
            this.Panel_Logo.SuspendLayout();
            this.TableLayoutPanel_Body.SuspendLayout();
            this.Panel_MasterSanPham.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            this.guna2Panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button8.Location = new System.Drawing.Point(203, 4);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 32);
            this.button8.TabIndex = 8;
            this.button8.Text = "Tìm kiếm";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Resize_Admin
            // 
            this.Resize_Admin.TargetForm = this;
            // 
            // DragControl_Admin
            // 
            this.DragControl_Admin.DockForm = true;
            this.DragControl_Admin.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl_Admin.TargetControl = this.TableLayoutPanel_Header;
            this.DragControl_Admin.UseTransparentDrag = true;
            // 
            // TableLayoutPanel_Header
            // 
            this.TableLayoutPanel_Header.ColumnCount = 5;
            this.TableLayoutPanel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.TableLayoutPanel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TableLayoutPanel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TableLayoutPanel_Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TableLayoutPanel_Header.Controls.Add(this.guna2ControlBox1, 4, 0);
            this.TableLayoutPanel_Header.Controls.Add(this.guna2ControlBox2, 3, 0);
            this.TableLayoutPanel_Header.Controls.Add(this.guna2ControlBox3, 2, 0);
            this.TableLayoutPanel_Header.Controls.Add(this.Label_Heading, 1, 0);
            this.TableLayoutPanel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanel_Header.Location = new System.Drawing.Point(7, 0);
            this.TableLayoutPanel_Header.Name = "TableLayoutPanel_Header";
            this.TableLayoutPanel_Header.RowCount = 1;
            this.TableLayoutPanel_Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel_Header.Size = new System.Drawing.Size(891, 30);
            this.TableLayoutPanel_Header.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(857, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 30);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(823, 0);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(34, 30);
            this.guna2ControlBox2.TabIndex = 7;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.Animated = true;
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(789, 0);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(34, 30);
            this.guna2ControlBox3.TabIndex = 8;
            // 
            // Label_Heading
            // 
            this.Label_Heading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Heading.ForeColor = System.Drawing.Color.White;
            this.Label_Heading.Location = new System.Drawing.Point(418, 4);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(55, 21);
            this.Label_Heading.TabIndex = 9;
            this.Label_Heading.Text = "Heading";
            // 
            // BorderLess_Admin
            // 
            this.BorderLess_Admin.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            this.BorderLess_Admin.BorderRadius = 12;
            this.BorderLess_Admin.ContainerControl = this;
            this.BorderLess_Admin.DockIndicatorColor = System.Drawing.Color.IndianRed;
            this.BorderLess_Admin.DockIndicatorTransparencyValue = 0.6D;
            this.BorderLess_Admin.TransparentWhileDrag = true;
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.AutoScroll = true;
            this.panel_sidebar.BorderRadius = 12;
            this.panel_sidebar.Controls.Add(this.guna2Panel9);
            this.panel_sidebar.Controls.Add(this.guna2Panel10);
            this.panel_sidebar.Controls.Add(this.guna2Panel7);
            this.panel_sidebar.Controls.Add(this.guna2Panel8);
            this.panel_sidebar.Controls.Add(this.guna2Panel5);
            this.panel_sidebar.Controls.Add(this.guna2Panel6);
            this.panel_sidebar.Controls.Add(this.guna2Panel3);
            this.panel_sidebar.Controls.Add(this.guna2Panel4);
            this.panel_sidebar.Controls.Add(this.guna2Panel2);
            this.panel_sidebar.Controls.Add(this.Panel_MasterSanPham);
            this.panel_sidebar.Controls.Add(this.guna2Panel1);
            this.panel_sidebar.Controls.Add(this.Panel_Logo);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_sidebar.FillColor = System.Drawing.Color.White;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Padding = new System.Windows.Forms.Padding(7);
            this.panel_sidebar.Size = new System.Drawing.Size(228, 726);
            this.panel_sidebar.TabIndex = 11;
            // 
            // Panel_Logo
            // 
            this.Panel_Logo.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Logo.BorderRadius = 12;
            this.Panel_Logo.Controls.Add(this.btn_TrangChu);
            this.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Logo.FillColor = System.Drawing.Color.Black;
            this.Panel_Logo.Location = new System.Drawing.Point(7, 7);
            this.Panel_Logo.Name = "Panel_Logo";
            this.Panel_Logo.Size = new System.Drawing.Size(214, 214);
            this.Panel_Logo.TabIndex = 0;
            // 
            // TableLayoutPanel_Body
            // 
            this.TableLayoutPanel_Body.ColumnCount = 2;
            this.TableLayoutPanel_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.TableLayoutPanel_Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel_Body.Controls.Add(this.panel_sidebar, 0, 0);
            this.TableLayoutPanel_Body.Controls.Add(this.panel_container, 1, 0);
            this.TableLayoutPanel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel_Body.Location = new System.Drawing.Point(7, 30);
            this.TableLayoutPanel_Body.Name = "TableLayoutPanel_Body";
            this.TableLayoutPanel_Body.RowCount = 1;
            this.TableLayoutPanel_Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel_Body.Size = new System.Drawing.Size(891, 726);
            this.TableLayoutPanel_Body.TabIndex = 10;
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.White;
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(237, 2);
            this.panel_container.Margin = new System.Windows.Forms.Padding(9, 2, 3, 2);
            this.panel_container.Name = "panel_container";
            this.panel_container.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel_container.Size = new System.Drawing.Size(651, 722);
            this.panel_container.TabIndex = 12;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(7, 221);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(214, 20);
            this.guna2Panel1.TabIndex = 23;
            // 
            // Panel_MasterSanPham
            // 
            this.Panel_MasterSanPham.BackColor = System.Drawing.Color.White;
            this.Panel_MasterSanPham.Controls.Add(this.btn_KhuyenMai);
            this.Panel_MasterSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_MasterSanPham.Location = new System.Drawing.Point(7, 241);
            this.Panel_MasterSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_MasterSanPham.MinimumSize = new System.Drawing.Size(213, 35);
            this.Panel_MasterSanPham.Name = "Panel_MasterSanPham";
            this.Panel_MasterSanPham.Size = new System.Drawing.Size(214, 43);
            this.Panel_MasterSanPham.TabIndex = 24;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(7, 284);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(214, 10);
            this.guna2Panel2.TabIndex = 25;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(7, 337);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(214, 10);
            this.guna2Panel3.TabIndex = 27;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.White;
            this.guna2Panel4.Controls.Add(this.btn_BanHang);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(7, 294);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel4.MinimumSize = new System.Drawing.Size(213, 35);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(214, 43);
            this.guna2Panel4.TabIndex = 26;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.White;
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.Location = new System.Drawing.Point(7, 390);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(214, 10);
            this.guna2Panel5.TabIndex = 29;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.White;
            this.guna2Panel6.Controls.Add(this.btn_ThongKe);
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel6.Location = new System.Drawing.Point(7, 347);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel6.MinimumSize = new System.Drawing.Size(213, 35);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(214, 43);
            this.guna2Panel6.TabIndex = 28;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.White;
            this.guna2Panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel7.Location = new System.Drawing.Point(7, 443);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(214, 10);
            this.guna2Panel7.TabIndex = 31;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.White;
            this.guna2Panel8.Controls.Add(this.btn_HeThong);
            this.guna2Panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel8.Location = new System.Drawing.Point(7, 400);
            this.guna2Panel8.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel8.MinimumSize = new System.Drawing.Size(213, 35);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(214, 43);
            this.guna2Panel8.TabIndex = 30;
            // 
            // btn_KhuyenMai
            // 
            this.btn_KhuyenMai.BorderRadius = 8;
            this.btn_KhuyenMai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_KhuyenMai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_KhuyenMai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_KhuyenMai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_KhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_KhuyenMai.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhuyenMai.ForeColor = System.Drawing.Color.White;
            this.btn_KhuyenMai.Location = new System.Drawing.Point(0, 0);
            this.btn_KhuyenMai.Name = "btn_KhuyenMai";
            this.btn_KhuyenMai.Size = new System.Drawing.Size(214, 43);
            this.btn_KhuyenMai.TabIndex = 0;
            this.btn_KhuyenMai.Text = "Khuyến Mãi";
            this.btn_KhuyenMai.Click += new System.EventHandler(this.btn_KhuyenMai_Click);
            // 
            // btn_BanHang
            // 
            this.btn_BanHang.BorderRadius = 8;
            this.btn_BanHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_BanHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_BanHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_BanHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_BanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_BanHang.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BanHang.ForeColor = System.Drawing.Color.White;
            this.btn_BanHang.Location = new System.Drawing.Point(0, 0);
            this.btn_BanHang.Name = "btn_BanHang";
            this.btn_BanHang.Size = new System.Drawing.Size(214, 43);
            this.btn_BanHang.TabIndex = 1;
            this.btn_BanHang.Text = "Bán Hàng";
            this.btn_BanHang.Click += new System.EventHandler(this.btn_BanHang_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BorderRadius = 8;
            this.btn_ThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ThongKe.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.ForeColor = System.Drawing.Color.White;
            this.btn_ThongKe.Location = new System.Drawing.Point(0, 0);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(214, 43);
            this.btn_ThongKe.TabIndex = 1;
            this.btn_ThongKe.Text = "Thống Kê";
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.Color.White;
            this.guna2Panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel9.Location = new System.Drawing.Point(7, 496);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(214, 10);
            this.guna2Panel9.TabIndex = 33;
            // 
            // guna2Panel10
            // 
            this.guna2Panel10.BackColor = System.Drawing.Color.White;
            this.guna2Panel10.Controls.Add(this.btn_DangXuat);
            this.guna2Panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel10.Location = new System.Drawing.Point(7, 453);
            this.guna2Panel10.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel10.MinimumSize = new System.Drawing.Size(213, 35);
            this.guna2Panel10.Name = "guna2Panel10";
            this.guna2Panel10.Size = new System.Drawing.Size(214, 43);
            this.guna2Panel10.TabIndex = 32;
            // 
            // btn_HeThong
            // 
            this.btn_HeThong.BorderRadius = 8;
            this.btn_HeThong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_HeThong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_HeThong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_HeThong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_HeThong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_HeThong.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HeThong.ForeColor = System.Drawing.Color.White;
            this.btn_HeThong.Location = new System.Drawing.Point(0, 0);
            this.btn_HeThong.Name = "btn_HeThong";
            this.btn_HeThong.Size = new System.Drawing.Size(214, 43);
            this.btn_HeThong.TabIndex = 2;
            this.btn_HeThong.Text = "Hệ Thống";
            this.btn_HeThong.Click += new System.EventHandler(this.btn_HeThong_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BorderRadius = 8;
            this.btn_DangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DangXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DangXuat.FillColor = System.Drawing.Color.SlateBlue;
            this.btn_DangXuat.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.White;
            this.btn_DangXuat.Location = new System.Drawing.Point(0, 0);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(214, 43);
            this.btn_DangXuat.TabIndex = 2;
            this.btn_DangXuat.Text = "Đăng Xuất";
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Black;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(160, 50);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(150, 50);
            this.guna2ImageButton1.Location = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(62, 60);
            this.guna2ImageButton1.TabIndex = 0;
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_TrangChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_TrangChu.HoverState.ImageSize = new System.Drawing.Size(190, 190);
            this.btn_TrangChu.Image = global::promotion_management_app.Properties.Resources.logo_tra_sua_dep;
            this.btn_TrangChu.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_TrangChu.ImageRotate = 0F;
            this.btn_TrangChu.ImageSize = new System.Drawing.Size(200, 200);
            this.btn_TrangChu.Location = new System.Drawing.Point(0, 0);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_TrangChu.Size = new System.Drawing.Size(214, 214);
            this.btn_TrangChu.TabIndex = 0;
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(905, 763);
            this.Controls.Add(this.TableLayoutPanel_Body);
            this.Controls.Add(this.TableLayoutPanel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Menu";
            this.Padding = new System.Windows.Forms.Padding(7, 0, 7, 7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TableLayoutPanel_Header.ResumeLayout(false);
            this.TableLayoutPanel_Header.PerformLayout();
            this.panel_sidebar.ResumeLayout(false);
            this.Panel_Logo.ResumeLayout(false);
            this.TableLayoutPanel_Body.ResumeLayout(false);
            this.Panel_MasterSanPham.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button button8;
        private Guna.UI2.WinForms.Guna2ResizeForm Resize_Admin;
        private Guna.UI2.WinForms.Guna2DragControl DragControl_Admin;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderLess_Admin;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private TableLayoutPanel TableLayoutPanel_Header;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Label Label_Heading;
        private TableLayoutPanel TableLayoutPanel_Body;
        private Guna.UI2.WinForms.Guna2Panel panel_sidebar;
        private Panel panel_container;
        private Guna.UI2.WinForms.Guna2Panel Panel_Logo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Button btn_ThongKe;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button btn_BanHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel Panel_MasterSanPham;
        private Guna.UI2.WinForms.Guna2Button btn_KhuyenMai;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel10;
        private Guna.UI2.WinForms.Guna2Button btn_DangXuat;
        private Guna.UI2.WinForms.Guna2Button btn_HeThong;
        private Guna.UI2.WinForms.Guna2ImageButton btn_TrangChu;
    }
}