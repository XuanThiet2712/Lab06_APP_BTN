using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_App
{
    // MODEL: chỉ chứa dữ liệu của 1 sản phẩm
    public class Product
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string LoaiSP { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayNhap { get; set; }
        public bool ConKinhDoanh { get; set; }
        public string DuongDanAnh { get; set; }

        public string ToDetailString()
        {
            return
                $"Mã SP: {MaSP}\n" +
                $"Tên SP: {TenSP}\n" +
                $"Loại: {LoaiSP}\n" +
                $"Đơn giá: {DonGia:N0} đ\n" +
                $"Số lượng: {SoLuong}\n" +
                $"Ngày nhập: {NgayNhap:dd/MM/yyyy}\n" +
                $"Tình trạng: {(ConKinhDoanh ? "Còn kinh doanh" : "Ngừng kinh doanh")}\n" +
                $"Ảnh: {(string.IsNullOrEmpty(DuongDanAnh) ? "(chưa có)" : DuongDanAnh)}";
        }
    }
}

