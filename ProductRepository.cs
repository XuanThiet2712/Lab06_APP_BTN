using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_App
{
    // KHO DỮ LIỆU (trong bộ nhớ): thêm, sửa, xóa, tìm kiếm. Không đụng đến giao diện.
    public class ProductRepository
    {
        public BindingList<Product> Items { get; } = new BindingList<Product>();
        public int Count => Items.Count;

        public void LoadSample()
        {
            Items.Clear();
            Items.Add(new Product { MaSP = "SP001", TenSP = "iPhone 15", LoaiSP = "Điện tử", DonGia = 22000000m, SoLuong = 10, NgayNhap = DateTime.Today.AddDays(-30), ConKinhDoanh = true, DuongDanAnh = "" });
            Items.Add(new Product { MaSP = "SP002", TenSP = "Bút bi Thiên Long", LoaiSP = "Văn phòng", DonGia = 5000m, SoLuong = 200, NgayNhap = DateTime.Today.AddDays(-10), ConKinhDoanh = true, DuongDanAnh = "" });
            Items.Add(new Product { MaSP = "SP003", TenSP = "Nồi cơm điện", LoaiSP = "Gia dụng", DonGia = 1200000m, SoLuong = 15, NgayNhap = DateTime.Today.AddDays(-60), ConKinhDoanh = true, DuongDanAnh = "" });
            Items.Add(new Product { MaSP = "SP004", TenSP = "Áo thun nam", LoaiSP = "Thời trang", DonGia = 150000m, SoLuong = 50, NgayNhap = DateTime.Today.AddDays(-5), ConKinhDoanh = false, DuongDanAnh = "" });
            Items.Add(new Product { MaSP = "SP005", TenSP = "Tai nghe Bluetooth", LoaiSP = "Điện tử", DonGia = 850000m, SoLuong = 0, NgayNhap = DateTime.Today.AddDays(-90), ConKinhDoanh = false, DuongDanAnh = "" });
        }

        public Product FindByMa(string ma)
        {
            return Items.FirstOrDefault(p => SameMa(p.MaSP, ma));
        }

        // Kiểm tra mã đã tồn tại chưa (excludeMa: bỏ qua chính nó khi đang sửa)
        public bool Exists(string ma, string excludeMa = null)
        {
            return Items.Any(p => SameMa(p.MaSP, ma) && !SameMa(p.MaSP, excludeMa));
        }

        public void Add(Product p)
        {
            Items.Add(p);
        }

        // Cập nhật theo mã (không đổi mã). Trả về false nếu không tìm thấy.
        public bool Update(string ma, Product data)
        {
            var target = FindByMa(ma);
            if (target == null) return false;
            target.TenSP = data.TenSP;
            target.LoaiSP = data.LoaiSP;
            target.DonGia = data.DonGia;
            target.SoLuong = data.SoLuong;
            target.NgayNhap = data.NgayNhap;
            target.ConKinhDoanh = data.ConKinhDoanh;
            target.DuongDanAnh = data.DuongDanAnh;
            return true;
        }

        public bool Remove(Product p)
        {
            return Items.Remove(p);
        }

        // Tìm theo mã hoặc tên, không phân biệt hoa/thường
        public List<Product> Search(string keyword)
        {
            keyword = (keyword ?? "").Trim();
            if (keyword.Length == 0) return Items.ToList();
            return Items.Where(p => Contains(p.MaSP, keyword) || Contains(p.TenSP, keyword)).ToList();
        }

        public decimal TongGiaTri()
        {
            return Items.Sum(p => p.DonGia * p.SoLuong);
        }

        private static bool SameMa(string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }

        private static bool Contains(string source, string keyword)
        {
            return source != null && source.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}
