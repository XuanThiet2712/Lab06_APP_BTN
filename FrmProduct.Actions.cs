using System;
using System.Windows.Forms;

namespace Lab06_App
{
    // GIAO DIỆN: Thêm/Sửa/Xóa, đọc-ghi form, validate (hiển thị lỗi), ảnh, xuất file
    public partial class FrmProduct
    {
        // ---------- Đọc / ghi form ----------
        private Product GetProductFromForm()
        {
            return new Product
            {
                MaSP = txtMaSP.Text.Trim(),
                TenSP = txtTenSP.Text.Trim(),
                LoaiSP = cboLoaiSP.Text,
                DonGia = numDonGia.Value,
                SoLuong = (int)numSoLuong.Value,
                NgayNhap = dtpNgayNhap.Value.Date,
                ConKinhDoanh = chkConKinhDoanh.Checked,
                DuongDanAnh = _imagePath ?? ""
            };
        }

        private void LoadProductToForm(Product p)
        {
            if (p == null) return;
            txtMaSP.Text = p.MaSP;
            txtTenSP.Text = p.TenSP;
            int idx = cboLoaiSP.FindStringExact(p.LoaiSP);
            cboLoaiSP.SelectedIndex = idx >= 0 ? idx : 0;
            numDonGia.Value = Math.Min(Math.Max(p.DonGia, numDonGia.Minimum), numDonGia.Maximum);
            numSoLuong.Value = Math.Min(Math.Max(p.SoLuong, numSoLuong.Minimum), numSoLuong.Maximum);
            dtpNgayNhap.Value = p.NgayNhap < dtpNgayNhap.MinDate ? DateTime.Today : p.NgayNhap;
            chkConKinhDoanh.Checked = p.ConKinhDoanh;
            _imagePath = p.DuongDanAnh ?? "";
            ShowImage(_imagePath);
        }

        private void ClearInput()
        {
            _editingMa = null;
            txtMaSP.ReadOnly = false;
            txtMaSP.Clear();
            txtTenSP.Clear();
            if (cboLoaiSP.Items.Count > 0) cboLoaiSP.SelectedIndex = 0;
            numDonGia.Value = 0;
            numSoLuong.Value = 0;
            dtpNgayNhap.Value = DateTime.Today;
            chkConKinhDoanh.Checked = true;
            _imagePath = "";
            ShowImage(null);
            txtMaSP.Focus();
        }

        // ---------- Validation: gọi ProductValidator rồi hiện lỗi lên ErrorProvider ----------
        private bool ValidateInput()
        {
            errorProvider.Clear();
            var errors = ProductValidator.Validate(GetProductFromForm(), _repo, _editingMa);
            if (errors.Count == 0) return true;

            Control first = null;
            foreach (var er in errors)
            {
                Control c = FieldToControl(er.Field);
                errorProvider.SetError(c, er.Message);
                if (first == null) first = c;
            }
            MessageBox.Show("Dữ liệu chưa hợp lệ, vui lòng kiểm tra các ô có biểu tượng lỗi.",
                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (first != null) first.Focus();
            return false;
        }

        private Control FieldToControl(string field)
        {
            switch (field)
            {
                case "MaSP": return txtMaSP;
                case "TenSP": return txtTenSP;
                case "LoaiSP": return cboLoaiSP;
                case "DonGia": return numDonGia;
                case "SoLuong": return numSoLuong;
                default: return dtpNgayNhap;
            }
        }

        // ---------- CRUD ----------
        private void AddProduct()
        {
            if (_editingMa != null)
            {
                MessageBox.Show("Đang ở chế độ sửa. Nhấn Làm mới (F5) hoặc Esc để hủy sửa rồi mới thêm.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!ValidateInput()) return;

            _repo.Add(GetProductFromForm());
            ApplyFilter();
            ClearInput();
            UpdateStatus("Đã thêm sản phẩm");
        }

        // Bấm lần 1: đưa dữ liệu lên form, khóa mã. Bấm lần 2: lưu thay đổi.
        private void EditProduct()
        {
            if (_editingMa == null)
            {
                var p = GetSelectedProduct();
                if (p == null)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                errorProvider.Clear();
                _editingMa = p.MaSP;
                LoadProductToForm(p);
                txtMaSP.ReadOnly = true;
                txtTenSP.Focus();
                UpdateStatus($"Đang sửa: {p.MaSP} - chỉnh thông tin rồi bấm Sửa lần nữa để lưu (Esc để hủy)");
                return;
            }

            if (!ValidateInput()) return;

            string ma = _editingMa;
            if (!_repo.Update(ma, GetProductFromForm()))
            {
                MessageBox.Show("Không tìm thấy sản phẩm cần sửa.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInput();
                return;
            }
            ApplyFilter();
            _bs.ResetBindings(false);
            ClearInput();
            UpdateStatus($"Đã cập nhật sản phẩm {ma}");
        }

        private void DeleteProduct()
        {
            var p = GetSelectedProduct();
            if (p == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var rs = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm \"{p.TenSP}\" ({p.MaSP})?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes) return;

            string ma = p.MaSP;
            _repo.Remove(p);
            ApplyFilter();
            ClearInput();
            UpdateStatus($"Đã xóa sản phẩm {ma}");
        }

        private void CancelEdit()
        {
            if (_editingMa == null) return;
            errorProvider.Clear();
            ClearInput();
            UpdateStatus("Đã hủy sửa");
        }

        // ---------- Ảnh, chi tiết, xuất file ----------
        private void ChooseImage()
        {
            string path = ImageHelper.PickImagePath();
            if (path == null) return;
            if (ImageHelper.Load(path) == null)
            {
                MessageBox.Show("Không đọc được file ảnh này.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _imagePath = path;
            ShowImage(path);
            UpdateStatus("Đã chọn ảnh: " + System.IO.Path.GetFileName(path));
        }

        private void ShowImage(string path)
        {
            var old = picProduct.Image;
            picProduct.Image = ImageHelper.Load(path);
            if (old != null) old.Dispose();
        }

        private void ShowProductDetail()
        {
            var p = GetSelectedProduct();
            if (p == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xem chi tiết.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show(p.ToDetailString(), "Chi tiết sản phẩm",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Gợi ý mở rộng: gắn vào 1 menu nếu muốn dùng
        private void ExportToTxt()
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text file|*.txt";
                sfd.FileName = "DanhSachSanPham.txt";
                if (sfd.ShowDialog() != DialogResult.OK) return;
                ProductExporter.ExportToTxt(_repo.Items, sfd.FileName);
                UpdateStatus("Đã xuất file: " + sfd.FileName);
            }
        }
    }
}
