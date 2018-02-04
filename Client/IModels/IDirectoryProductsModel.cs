using Core.Domain;
using System.Collections.Generic;

namespace Client.IModels
{
    /// <summary>
    /// Интерфейс модели "Справочник товаров".
    /// </summary>
    public interface IDirectoryProductsModel
    {
        /// <summary>
        /// Получение всех груп товаров.
        /// </summary>
        /// <returns>Список групп товаров</returns>
        List<GroupProduct> GetGroupProducts();

        /// <summary>
        /// Получение товаров по Ид группы товаров.
        /// </summary>
        /// <param name="id">Ид группы товаров.</param>
        /// <returns>Товары.</returns>
        List<ProductDTO> GetProducts(int id);
    }
}
