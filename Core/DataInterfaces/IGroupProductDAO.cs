using Core.Domain;
using System.Collections.Generic;

namespace Core.DataInterfaces
{
    /// <summary>
    /// Интерфейс доступа к данным груп товаров.
    /// </summary>
    public interface IGroupProductDAO
    {
        /// <summary>
        /// Получение всех груп товаров.
        /// </summary>
        /// <returns>Список групп товаров</returns>
        IList<GroupProduct> GetGroupProducts();
    }
}
