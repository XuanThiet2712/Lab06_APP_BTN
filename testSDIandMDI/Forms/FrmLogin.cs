using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testSDIandMDI.Forms
{
    public partial class FrmLogin: Form
    {
        public User CurrentUser { get; private set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            { CurrentUser = new User { Username = "admin", FullName = "Quản trị viên", Role = "Admin" }; 
                DialogResult = DialogResult.OK; }
            else { MessageBox.Show("Đăng nhập thất bại!"); }
        }
    }
}
