using Client.Models;
using Client.Presenters;
using Client.Views;
using System;
using System.Windows.Forms;

namespace Client
{
    static class DirectoryProdycts
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DirectoryProductsPresenter presenter = new DirectoryProductsPresenter();
            DirectoryProductsModel model = new DirectoryProductsModel();

            Application.Run(new DirectoryProductsView(presenter, model));
        }
    }
}
