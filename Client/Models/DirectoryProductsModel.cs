using Client.IModels;
using Core.Domain;
using System.Collections.Generic;

namespace Client.Models
{
    /// <summary>
    /// Класс модели "Справочник товаров".
    /// </summary>
    public class DirectoryProductsModel : IDirectoryProductsModel
    {
        /// <summary>
        /// Получение всех груп товаров.
        /// </summary>
        /// <returns>Список групп товаров</returns>
        public List<GroupProduct> GetGroupProducts()
        {
            ServiceReferenceGroupProduct.GroupProductServiceClient productGroupServiceclient = new ServiceReferenceGroupProduct.GroupProductServiceClient();

            return productGroupServiceclient.GetGroupProducts();
        }

        /// <summary>
        /// Получение товаров по Ид группы товаров.
        /// </summary>
        /// <param name="id">Ид группы товаров.</param>
        /// <returns>Товары.</returns>
        public List<ProductDTO> GetProducts(int id)
        {
            ServiceReferenceProduct.ProductServiseClient productServiseClient = new ServiceReferenceProduct.ProductServiseClient();

            return productServiseClient.GetProducts(id);
        }
    }
}
