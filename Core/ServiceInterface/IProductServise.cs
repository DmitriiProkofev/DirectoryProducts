using System.Collections.Generic;
using System.ServiceModel;
using Core.Domain;

namespace Core.ServiceInterfaces
{
    /// <summary>
    /// Интерфейс сервиса товаров.
    /// </summary>
    [ServiceContract]
    public interface IProductServise
    {
        /// <summary>
        /// Получение товаров по Ид группы товаров.
        /// </summary>
        /// <param name="groupProductId">Ид группы товаров.</param>
        /// <returns>Товары.</returns>
        [OperationContract]
        IList<ProductDTO> GetProducts(int groupProductId);
    }
}
