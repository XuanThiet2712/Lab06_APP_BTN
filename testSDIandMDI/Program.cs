using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using testSDIandMDI.Forms;

namespace testSDIandMDI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            using (FrmLogin login = new FrmLogin())

            {

                // Chỉ khi đăng nhập thành công mới khởi chạy FrmMain

                if (login.ShowDialog() == DialogResult.OK)

                {

                    // Truyền thông tin User sang FrmMain qua constructor

                    Application.Run(new FrmMain(login.CurrentUser));

                }

            }

        }
    }
}
