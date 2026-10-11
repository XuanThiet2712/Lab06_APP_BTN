using System;
using System.Windows.Forms;

namespace Lab06_App
{
    // GIAO DIỆN: chỉ đọc/ghi control và gọi các class bên ngoài
    public partial class FrmProduct : Form
    {
        private readonly ProductRepository _repo = new ProductRepository();
        private readonly BindingSource _bs = new BindingSource();
        private string _editingMa = null;        // null = đang thêm mới, khác null = đang sửa
        private string _imagePath = "";
        private bool _suppressSelection = false; // chặn SelectionChanged khi ta tự gán DataSource

        public FrmProduct()
        {
            InitializeComponent();
            WireEvents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _suppressSelection = true;
            try
            {
                InitControls();
                InitComboBox();
                _repo.LoadSample();
                _bs.DataSource = _repo.Items;
                ConfigureGrid();
            }
            finally { _suppressSelection = false; }
            ClearInput();
            UpdateStatus("Sẵn sàng");
        }

        // ---------- Nối sự kiện ----------
        private void WireEvents()
        {
            Load -= Form1_Load; // tránh gán 2 lần nếu Designer đã gán sẵn
            Load += Form1_Load;

            tsbThem.Click += (s, e) => AddProduct();
            tsbSua.Click += (s, e) => EditProduct();
            tsbXoa.Click += (s, e) => DeleteProduct();
            tsbLamMoi.Click += (s, e) => RefreshAll();
            tsbTimKiem.Click += (s, e) => SearchProduct();
            txtTimKiem.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { SearchProduct(); e.SuppressKeyPress = true; }
            };

            mnuThem.Click += (s, e) => AddProduct();
            mnuSua.Click += (s, e) => EditProduct();
            mnuXoa.Click += (s, e) => DeleteProduct();
            mnuLamMoi.Click += (s, e) => RefreshAll();
            mnuThoat.Click += (s, e) => ExitApp();
            mnuGioiThieu.Click += (s, e) => MessageBox.Show(
                "ProductManager - Lab 06\nMôn: COMP1019 - Lập trình trên Windows\nNhóm: (ghi tên nhóm/thành viên)",
                "Giới thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ctxSua.Click += (s, e) => EditProduct();
            ctxXoa.Click += (s, e) => DeleteProduct();
            ctxXemChiTiet.Click += (s, e) => ShowProductDetail();
            dgvProducts.ContextMenuStrip = ctxMenu;

            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            dgvProducts.CellMouseDown += dgvProducts_CellMouseDown;
            dgvProducts.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) EditProduct(); };

            btnChonAnh.Click += (s, e) => ChooseImage();

            KeyPreview = true;
            KeyDown += FrmProduct_KeyDown;

            // Gõ lại thì xóa biểu tượng lỗi
            txtMaSP.TextChanged += (s, e) => errorProvider.SetError(txtMaSP, "");
            txtTenSP.TextChanged += (s, e) => errorProvider.SetError(txtTenSP, "");
            cboLoaiSP.SelectedIndexChanged += (s, e) => errorProvider.SetError(cboLoaiSP, "");
            numDonGia.ValueChanged += (s, e) => errorProvider.SetError(numDonGia, "");
            numSoLuong.ValueChanged += (s, e) => errorProvider.SetError(numSoLuong, "");
            dtpNgayNhap.ValueChanged += (s, e) => errorProvider.SetError(dtpNgayNhap, "");
        }

        private void FrmProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) { AddProduct(); e.SuppressKeyPress = true; }
            else if (e.Control && e.KeyCode == Keys.F) { txtTimKiem.Focus(); e.SuppressKeyPress = true; }
            else if (e.KeyCode == Keys.F5) { RefreshAll(); e.SuppressKeyPress = true; }
            else if (e.KeyCode == Keys.Escape) { CancelEdit(); }
            else if (e.KeyCode == Keys.Delete && dgvProducts.Focused) { DeleteProduct(); e.SuppressKeyPress = true; }
        }

        private void ExitApp()
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        // ===== HÀM RỖNG DO DESIGNER GÁN SẴN =====
        // Designer.cs đang tham chiếu các hàm này nên PHẢI giữ lại,
        // trừ khi bạn xóa luôn dòng "+= new ...(this.tên_hàm)" tương ứng trong FrmProduct.Designer.cs.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void Grbox_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void numSoLuong_ValueChanged(object sender, EventArgs e) { }
        private void numDonGia_ValueChanged(object sender, EventArgs e) { }
        private void lblNhapLieu_Click(object sender, EventArgs e) { }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}