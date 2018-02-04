using Client.IPresenters;
using Client.Models;
using Client.Views;

namespace Client.Presenters
{
    /// <summary>
    /// Класс представителя "Справочник товаров".
    /// </summary>
    public class DirectoryProductsPresenter : IDirectoryProductsPresenter
    {
        private DirectoryProductsView _view;
        private DirectoryProductsModel _model;

        /// <summary>
        /// Инициализация.
        /// </summary>
        /// <param name="view">Представление.</param>
        /// <param name="Model">Модель.</param>
        public void Init(DirectoryProductsView view, DirectoryProductsModel model)
        {
            _view = view;
            _model = model;

            _view.GetGroupProducts += GetGroupProducts_Handler;
            _view.GetProducts += GetProducts_Handler;
            _view.ViewClosed += ViewClosed_Handler;
        }

        private void GetGroupProducts_Handler()
        {
            _view.GroupProducts = _model.GetGroupProducts();
        }

        private void GetProducts_Handler(int id)
        {
            _view.Products = _model.GetProducts(id);
        }

        private void ViewClosed_Handler()
        {
            _view.GetGroupProducts -= GetGroupProducts_Handler;
            _view.GetProducts -= GetProducts_Handler;
            _view.ViewClosed -= ViewClosed_Handler;
        }
    }
}
