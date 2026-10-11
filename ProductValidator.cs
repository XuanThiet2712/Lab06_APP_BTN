using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_App
{
    public class ValidationError
    {
        public string Field { get; set; }   // tên thuộc tính: "MaSP", "TenSP", ...
        public string Message { get; set; }
    }

    // KIỂM TRA DỮ LIỆU: chỉ trả về danh sách lỗi, không biết gì về control
    public static class ProductValidator
    {
        public static List<ValidationError> Validate(Product p, ProductRepository repo, string editingMa)
        {
            var errors = new List<ValidationError>();

            if (string.IsNullOrWhiteSpace(p.MaSP))
                errors.Add(Err("MaSP", "Mã SP không được rỗng"));
            else if (repo.Exists(p.MaSP.Trim(), editingMa))
                errors.Add(Err("MaSP", "Mã SP đã tồn tại"));

            if (string.IsNullOrWhiteSpace(p.TenSP))
                errors.Add(Err("TenSP", "Tên SP không được rỗng"));

            if (string.IsNullOrWhiteSpace(p.LoaiSP))
                errors.Add(Err("LoaiSP", "Hãy chọn loại SP"));

            if (p.DonGia <= 0)
                errors.Add(Err("DonGia", "Đơn giá phải > 0"));

            if (p.SoLuong < 0)
                errors.Add(Err("SoLuong", "Số lượng phải ≥ 0"));

            if (p.NgayNhap.Date > DateTime.Today)
                errors.Add(Err("NgayNhap", "Ngày nhập không được ở tương lai"));

            return errors;
        }

        private static ValidationError Err(string field, string msg)
        {
            return new ValidationError { Field = field, Message = msg };
        }
    }
}
