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
    public partial class FrmMain: Form
    {
        private User _currentUser;

        public FrmMain(User user) { 
            InitializeComponent();
            _currentUser = user;
            IsMdiContainer = true; }
        private void FrmMain_Load(object sender, EventArgs e) {
            lblUser.Text = $"Người dùng: {_currentUser.FullName}"; 
            lblRole.Text = $"Vai trò: {_currentUser.Role}"; 
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClass frm = new FrmClass();
            frm.MdiParent = this;
            frm.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudent frm = new FrmStudent();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
