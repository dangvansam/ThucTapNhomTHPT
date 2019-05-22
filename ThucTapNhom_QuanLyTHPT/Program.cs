using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom_QuanLyTHPT
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            //FormLogin lg_f = new FormLogin();
            //Application.Run(lg_f);
            //if (lg_f.check_true)
            //{
            //    Application.Run(new FormMain());
            //}

        }
    }
}
