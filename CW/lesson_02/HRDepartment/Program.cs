using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRDepartment
{
    /// <summary>
    /// Вам необходимо:
    /// 1. Реализовать вывод списка сотрудников с фильтрацией по отделам.
    /// 2. Реализовать отображение персональной информации о сотруднике при его выборе в списке.
    /// </summary>
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
            Application.Run(new FormMain());
        }
    }
}
