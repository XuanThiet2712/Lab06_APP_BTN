using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab06_App
{
    // XUẤT FILE (gợi ý mở rộng)
    public static class ProductExporter
    {
        public static void ExportToTxt(IEnumerable<Product> products, string path)
        {
            var lines = products.Select(p =>
                $"{p.MaSP}\t{p.TenSP}\t{p.LoaiSP}\t{p.DonGia:N0}\t{p.SoLuong}\t{p.NgayNhap:dd/MM/yyyy}\t{(p.ConKinhDoanh ? "Còn KD" : "Ngừng KD")}");
            File.WriteAllLines(path, lines, Encoding.UTF8);
        }
    }
}