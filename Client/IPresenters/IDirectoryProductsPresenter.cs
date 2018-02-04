using Client.Models;
using Client.Views;

namespace Client.IPresenters
{
    /// <summary>
    /// Интерфейс представителя "Справочник товаров".
    /// </summary>
    public interface IDirectoryProductsPresenter
    {
        /// <summary>
        /// Инициализация.
        /// </summary>
        /// <param name="view">Представление.</param>
        /// <param name="Model">Модель.</param>
        void Init(DirectoryProductsView view,DirectoryProductsModel Model);
    }
}
