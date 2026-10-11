using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab06_App
{
    // XỬ LÝ ẢNH: chọn file và đọc ảnh (không khóa file)
    public static class ImageHelper
    {
        // Trả về đường dẫn ảnh, hoặc null nếu người dùng bấm Hủy
        public static string PickImagePath()
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh sản phẩm";
                ofd.Filter = "Ảnh|*.jpg;*.jpeg;*.png;*.bmp|Tất cả file|*.*";
                return ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : null;
            }
        }

        // Đọc ảnh qua stream rồi copy ra Bitmap để file không bị khóa. Lỗi/không có file -> null
        public static Image Load(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path)) return null;
            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (var img = Image.FromStream(fs))
                {
                    return new Bitmap(img);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}