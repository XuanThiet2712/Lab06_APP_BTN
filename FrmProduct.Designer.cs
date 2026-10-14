namespace Lab06_App
{
    partial class FrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLamMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.tsbLamMoi = new System.Windows.Forms.ToolStripButton();
            this.tsbTimKiem = new System.Windows.Forms.ToolStripButton();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.Grbox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNhapLieu = new System.Windows.Forms.Label();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.chkConKinhDoanh = new System.Windows.Forms.CheckBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxSua = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxXemChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.Grbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.trợGiúpToolStripMenuItem,
            this.mnuGioiThieu,
            this.chứcNăngToolStripMenuItem,
            this.mnuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // mnuGioiThieu
            // 
            this.mnuGioiThieu.Name = "mnuGioiThieu";
            this.mnuGioiThieu.Size = new System.Drawing.Size(87, 24);
            this.mnuGioiThieu.Text = "Giới thiệu";
            this.mnuGioiThieu.Click += new System.EventHandler(this.mnuGioiThieu_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThem,
            this.mnuSua,
            this.mnuXoa,
            this.mnuLamMoi});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            this.chứcNăngToolStripMenuItem.Click += new System.EventHandler(this.chứcNăngToolStripMenuItem_Click);
            // 
            // mnuThem
            // 
            this.mnuThem.Name = "mnuThem";
            this.mnuThem.Size = new System.Drawing.Size(150, 26);
            this.mnuThem.Text = "Thêm";
            // 
            // mnuSua
            // 
            this.mnuSua.Name = "mnuSua";
            this.mnuSua.Size = new System.Drawing.Size(150, 26);
            this.mnuSua.Text = "Sửa";
            // 
            // mnuXoa
            // 
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.Size = new System.Drawing.Size(150, 26);
            this.mnuXoa.Text = "Xoá";
            // 
            // mnuLamMoi
            // 
            this.mnuLamMoi.Name = "mnuLamMoi";
            this.mnuLamMoi.Size = new System.Drawing.Size(150, 26);
            this.mnuLamMoi.Text = "Làm mới";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(61, 24);
            this.mnuThoat.Text = "Thoát";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThem,
            this.tsbSua,
            this.tsbXoa,
            this.tsbLamMoi,
            this.tsbTimKiem,
            this.txtTimKiem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(757, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbThem
            // 
            this.tsbThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbThem.Image = ((System.Drawing.Image)(resources.GetObject("tsbThem.Image")));
            this.tsbThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThem.Name = "tsbThem";
            this.tsbThem.Size = new System.Drawing.Size(50, 24);
            this.tsbThem.Text = "Thêm";
            // 
            // tsbSua
            // 
            this.tsbSua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSua.Image = ((System.Drawing.Image)(resources.GetObject("tsbSua.Image")));
            this.tsbSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSua.Name = "tsbSua";
            this.tsbSua.Size = new System.Drawing.Size(38, 24);
            this.tsbSua.Text = "Sửa";
            // 
            // tsbXoa
            // 
            this.tsbXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbXoa.Image = ((System.Drawing.Image)(resources.GetObject("tsbXoa.Image")));
            this.tsbXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoa.Name = "tsbXoa";
            this.tsbXoa.Size = new System.Drawing.Size(39, 24);
            this.tsbXoa.Text = "Xóa";
            // 
            // tsbLamMoi
            // 
            this.tsbLamMoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("tsbLamMoi.Image")));
            this.tsbLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLamMoi.Name = "tsbLamMoi";
            this.tsbLamMoi.Size = new System.Drawing.Size(71, 24);
            this.tsbLamMoi.Text = "Làm mới";
            // 
            // tsbTimKiem
            // 
            this.tsbTimKiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("tsbTimKiem.Image")));
            this.tsbTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTimKiem.Name = "tsbTimKiem";
            this.tsbTimKiem.Size = new System.Drawing.Size(74, 24);
            this.tsbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 27);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(757, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 20);
            this.lblStatus.Text = "lblStatus";
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(65, 20);
            this.lblCount.Text = "lblCount";
            // 
            // Grbox
            // 
            this.Grbox.Controls.Add(this.label5);
            this.Grbox.Controls.Add(this.label4);
            this.Grbox.Controls.Add(this.label3);
            this.Grbox.Controls.Add(this.label2);
            this.Grbox.Controls.Add(this.label1);
            this.Grbox.Controls.Add(this.lblNhapLieu);
            this.Grbox.Controls.Add(this.btnChonAnh);
            this.Grbox.Controls.Add(this.picProduct);
            this.Grbox.Controls.Add(this.chkConKinhDoanh);
            this.Grbox.Controls.Add(this.dtpNgayNhap);
            this.Grbox.Controls.Add(this.numSoLuong);
            this.Grbox.Controls.Add(this.numDonGia);
            this.Grbox.Controls.Add(this.cboLoaiSP);
            this.Grbox.Controls.Add(this.txtTenSP);
            this.Grbox.Controls.Add(this.txtMaSP);
            this.Grbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grbox.Location = new System.Drawing.Point(0, 55);
            this.Grbox.Margin = new System.Windows.Forms.Padding(4);
            this.Grbox.Name = "Grbox";
            this.Grbox.Padding = new System.Windows.Forms.Padding(4);
            this.Grbox.Size = new System.Drawing.Size(757, 177);
            this.Grbox.TabIndex = 3;
            this.Grbox.TabStop = false;
            this.Grbox.Text = "Thông tin sản phẩm";
            this.Grbox.Enter += new System.EventHandler(this.Grbox_Enter);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(296, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Loại sản phẩm:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày nhập:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(296, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số lượng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(296, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đơn giá:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên sản phẩm:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNhapLieu
            // 
            this.lblNhapLieu.Location = new System.Drawing.Point(16, 38);
            this.lblNhapLieu.Name = "lblNhapLieu";
            this.lblNhapLieu.Size = new System.Drawing.Size(121, 30);
            this.lblNhapLieu.TabIndex = 9;
            this.lblNhapLieu.Text = "Mã sản phẩm:";
            this.lblNhapLieu.Click += new System.EventHandler(this.lblNhapLieu_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(621, 136);
            this.btnChonAnh.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(100, 28);
            this.btnChonAnh.TabIndex = 8;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            // 
            // picProduct
            // 
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Location = new System.Drawing.Point(601, 36);
            this.picProduct.Margin = new System.Windows.Forms.Padding(4);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(133, 92);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 7;
            this.picProduct.TabStop = false;
            // 
            // chkConKinhDoanh
            // 
            this.chkConKinhDoanh.AutoSize = true;
            this.chkConKinhDoanh.Checked = true;
            this.chkConKinhDoanh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConKinhDoanh.Location = new System.Drawing.Point(16, 132);
            this.chkConKinhDoanh.Margin = new System.Windows.Forms.Padding(4);
            this.chkConKinhDoanh.Name = "chkConKinhDoanh";
            this.chkConKinhDoanh.Size = new System.Drawing.Size(121, 20);
            this.chkConKinhDoanh.TabIndex = 6;
            this.chkConKinhDoanh.Text = "Còn kinh doanh";
            this.chkConKinhDoanh.UseVisualStyleBackColor = true;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(141, 93);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(107, 22);
            this.dtpNgayNhap.TabIndex = 5;
            this.dtpNgayNhap.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(410, 66);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.numSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(160, 22);
            this.numSoLuong.TabIndex = 4;
            this.numSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSoLuong.ValueChanged += new System.EventHandler(this.numSoLuong_ValueChanged);
            // 
            // numDonGia
            // 
            this.numDonGia.Location = new System.Drawing.Point(410, 35);
            this.numDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.numDonGia.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(160, 22);
            this.numDonGia.TabIndex = 3;
            this.numDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDonGia.ValueChanged += new System.EventHandler(this.numDonGia_ValueChanged);
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(410, 104);
            this.cboLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(160, 24);
            this.cboLoaiSP.TabIndex = 2;
            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(141, 65);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(132, 22);
            this.txtTenSP.TabIndex = 1;
            this.txtTenSP.Text = "Tên sản phẩm";
            this.txtTenSP.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(141, 35);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(132, 22);
            this.txtMaSP.TabIndex = 0;
            this.txtMaSP.Text = "Mã sản phẩm";
            this.txtMaSP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 232);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(757, 191);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // ctxMenu
            // 
            this.ctxMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxSua,
            this.ctxXoa,
            this.ctxXemChiTiet});
            this.ctxMenu.Name = "contextMenuStrip2";
            this.ctxMenu.Size = new System.Drawing.Size(158, 76);
            // 
            // ctxSua
            // 
            this.ctxSua.Name = "ctxSua";
            this.ctxSua.Size = new System.Drawing.Size(157, 24);
            this.ctxSua.Text = "Sửa";
            // 
            // ctxXoa
            // 
            this.ctxXoa.Name = "ctxXoa";
            this.ctxXoa.Size = new System.Drawing.Size(157, 24);
            this.ctxXoa.Text = "Xoá";
            // 
            // ctxXemChiTiet
            // 
            this.ctxXemChiTiet.Name = "ctxXemChiTiet";
            this.ctxXemChiTiet.Size = new System.Drawing.Size(157, 24);
            this.ctxXemChiTiet.Text = "Xem chi tiết";
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 449);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.Grbox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Grbox.ResumeLayout(false);
            this.Grbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripButton tsbLamMoi;
        private System.Windows.Forms.ToolStripButton tsbTimKiem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.GroupBox Grbox;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.CheckBox chkConKinhDoanh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNhapLieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuThem;
        private System.Windows.Forms.ToolStripMenuItem mnuSua;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private System.Windows.Forms.ToolStripMenuItem mnuLamMoi;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxSua;
        private System.Windows.Forms.ToolStripMenuItem ctxXoa;
        private System.Windows.Forms.ToolStripMenuItem ctxXemChiTiet;
    }
}

