using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orgamizer_ADO
{
    /// <summary>
    /// ------------------------------------------------------------------------
    /// Ваше задание - реализовать на основе присоединенного режима доступа к БД
    /// оставшийся функционал прототипа приложения "Персональный ораганайзер"
    /// ------------------------------------------------------------------------
    /// 1. Удаление категории
    /// 2. Отображение списка задач заданной категории
    /// 3. Отображение детальной информации при выборе задачи
    /// 4. Добавление задач
    /// 5. Удаление задач
    /// 6. Редактирование задач
    /// ------------------------------------------------------------------------
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
