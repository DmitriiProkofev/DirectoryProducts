using Core.Domain;
using Core.ServiceInterfaces;
using Data.DAO;
using System;
using System.Collections.Generic;

namespace Service
{
    /// <summary>
    /// Класс сервиса групп товаров.
    /// </summary>
    public class GroupProductService : IGroupProductService
    {
        /// <summary>
        /// Получение всех груп товаров.
        /// </summary>
        /// <returns>Список групп товаров</returns>
        public IList<GroupProduct> GetGroupProducts()
        {
            IList<GroupProduct> groupProducts;
            try
            {
                GroupProductDAO groupProductDAO = new GroupProductDAO();
                groupProducts = groupProductDAO.GetGroupProducts();
            }
            catch 
            {
                throw new Exception("Ошибка во время получения данных");
            }

            return groupProducts;
        }
    }
}
