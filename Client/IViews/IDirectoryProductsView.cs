using Core.Domain;
using System;
using System.Collections.Generic;

namespace Client.IViews
{
    /// <summary>
    /// Интерфейс представления "Справочник товаров".
    /// </summary>
    public interface IDirectoryProductsView
    {
        /// <summary>
        /// Список групп товаров.
        /// </summary>
        List<GroupProduct> GroupProducts { set; }

        /// <summary>
        /// Список товаров.
        /// </summary>
        List<ProductDTO> Products { set; }

        /// <summary>
        /// Событие вызывает получение списка групп товаров.
        /// </summary>
        event Action GetGroupProducts;

        /// <summary>
        /// Сщбытие вызывает получение списка товаров.
        /// </summary>
        event Action<int> GetProducts;

        /// <summary>
        /// Закрытие формы.
        /// </summary>
        event Action ViewClosed;
    }
}
