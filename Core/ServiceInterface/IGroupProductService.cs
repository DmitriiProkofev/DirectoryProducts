using Core.Domain;
using System.Collections.Generic;
using System.ServiceModel;

namespace Core.ServiceInterfaces
{
    /// <summary>
    /// Интерфейс сервиса групп товаров.
    /// </summary>
    [ServiceContract]
    public interface IGroupProductService
    {
        /// <summary>
        /// Получение всех груп товаров.
        /// </summary>
        /// <returns>Список групп товаров</returns>
        [OperationContract]
        IList<GroupProduct> GetGroupProducts();
    }
}
