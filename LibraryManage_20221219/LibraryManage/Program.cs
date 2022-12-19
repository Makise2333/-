using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManage
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            login Login = new login();
            //界面转换
            Login.ShowDialog();//模态窗口(必须关闭了该窗口，后面的代码才会执行，并且不能跟其他界面自由切换)
            if (Login.DialogResult == DialogResult.OK)
            {
                Login.Dispose();//释放资源
                Application.Run(new LibraryManage.user());
            }
            else if (Login.DialogResult == DialogResult.Cancel)
            {
                Login.Dispose();
                return;
            }

            if (Login.DialogResult == DialogResult.Yes)
            {
                Login.Dispose();
                Application.Run(new LibraryManage.admin());
            }
            else if (Login.DialogResult == DialogResult.Cancel)
            {
                Login.Dispose();
                return;
            }

    }
}
}
