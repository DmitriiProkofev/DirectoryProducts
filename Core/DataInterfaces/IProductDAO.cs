using Core.Domain;
using System.Collections.Generic;

namespace Core.DataInterfaces
{
    /// <summary>
    /// Интерфейс доступа к данным товаров.
    /// </summary>
    public interface IProductDAO
    {
        /// <summary>
        /// Получение товаров по Ид группы товаров.
        /// </summary>
        /// <param name="groupProductId">Ид группы товаров.</param>
        /// <returns>Товары.</returns>
        IList<ProductDTO> GetProducts(int groupProductId);
    }
}
