using Core.Context;
using Core.DataInterfaces;
using Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Data.DAO
{
    /// <summary>
    /// Класс доступа к данным групп товаров.
    /// </summary>
    public class GroupProductDAO : IGroupProductDAO
    {
        //Контекст данных групп товаров.
        GroupProductContext groupProductContext = new GroupProductContext();

        /// <summary>
        /// Получение всех груп товаров.
        /// </summary>
        /// <returns>Список групп товаров</returns>
        public IList<GroupProduct> GetGroupProducts()
        {
            try
            {
                groupProductContext.GroupProducts.Load();

                return groupProductContext.GroupProducts.Local.OrderBy(g => g.Name).ToList();
            }
            catch
            {
                throw new Exception("Ошибка во время получения данных");
            }
        }
    }
}
