using System;
using System.Windows.Forms;

namespace Lab06_App
{
    // GIAO DIỆN: khởi tạo control, DataGridView, StatusStrip, tìm kiếm/làm mới
    public partial class FrmProduct
    {

        private void InitControls()
        {
            numDonGia.DecimalPlaces = 0;
            numDonGia.Minimum = 0;
            numDonGia.Maximum = 1000000000m;
            numDonGia.ThousandsSeparator = true;

            numSoLuong.DecimalPlaces = 0;
            numSoLuong.Minimum = 0;
            numSoLuong.Maximum = 1000000;

            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy";

            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void InitComboBox()
        {
            cboLoaiSP.Items.Clear();
            cboLoaiSP.Items.AddRange(new object[] { "Điện tử", "Văn phòng", "Gia dụng", "Thời trang" });
            cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSP.SelectedIndex = 0;
        }

        private void ConfigureGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.RowHeadersVisible = false;

            AddTextColumn("MaSP", "Mã SP", 12);
            AddTextColumn("TenSP", "Tên SP", 30);
            AddTextColumn("LoaiSP", "Loại", 14);
            var colGia = AddTextColumn("DonGia", "Đơn giá", 15);
            colGia.DefaultCellStyle.Format = "N0";
            colGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            var colSL = AddTextColumn("SoLuong", "Số lượng", 10);
            colSL.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            var colNgay = AddTextColumn("NgayNhap", "Ngày nhập", 14);
            colNgay.DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvProducts.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "ConKinhDoanh",
                HeaderText = "Còn KD",
                FillWeight = 8
            });

            dgvProducts.DataSource = _bs;
            dgvProducts.ClearSelection();
            dgvProducts.CurrentCell = null;
        }

        private DataGridViewTextBoxColumn AddTextColumn(string prop, string header, float weight)
        {
            var col = new DataGridViewTextBoxColumn
            {
                DataPropertyName = prop,
                HeaderText = header,
                Name = "col" + prop,
                FillWeight = weight
            };
            dgvProducts.Columns.Add(col);
            return col;
        }

        // null nếu chưa chọn dòng
        private Product GetSelectedProduct()
        {
            if (dgvProducts.CurrentRow == null) return null;
            return dgvProducts.CurrentRow.DataBoundItem as Product;
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = message;
            lblCount.Text = $"Tổng: {_repo.Count} sản phẩm | Giá trị tồn kho: {_repo.TongGiaTri():N0} đ";
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (_suppressSelection) return;
            var p = GetSelectedProduct();
            if (p == null) return;

            if (_editingMa != null && !string.Equals(_editingMa, p.MaSP, StringComparison.OrdinalIgnoreCase))
            {
                _editingMa = null;
                txtMaSP.ReadOnly = false;
            }
            if (_editingMa == null)
            {
                errorProvider.Clear();
                LoadProductToForm(p);
            }
        }

        private void dgvProducts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvProducts.ClearSelection();
                dgvProducts.Rows[e.RowIndex].Selected = true;
                dgvProducts.CurrentCell = dgvProducts.Rows[e.RowIndex].Cells[0];
            }
        }

        // Hiển thị danh sách theo từ khóa trong ô tìm kiếm (rỗng = tất cả)
        private void ApplyFilter()
        {
            string kw = (txtTimKiem.Text ?? "").Trim();
            _suppressSelection = true;
            try
            {
                if (kw.Length == 0) _bs.DataSource = _repo.Items;
                else _bs.DataSource = _repo.Search(kw);
                dgvProducts.ClearSelection();
                dgvProducts.CurrentCell = null;
            }
            finally { _suppressSelection = false; }
        }

        private void SearchProduct()
        {
            ApplyFilter();
            string kw = (txtTimKiem.Text ?? "").Trim();
            UpdateStatus(kw.Length == 0
                ? "Hiển thị toàn bộ sản phẩm"
                : $"Tìm thấy {_bs.Count} kết quả cho \"{kw}\"");
        }

        private void RefreshAll()
        {
            txtTimKiem.Clear();
            errorProvider.Clear();
            ClearInput();
            ApplyFilter();
            UpdateStatus("Đã làm mới");
        }
    }
}
