using Core.Domain;
using Core.ServiceInterfaces;
using Data.DAO;
using System;
using System.Collections.Generic;

namespace Service
{
    /// <summary>
    /// Класс сервиса товаров.
    /// </summary>
    public class ProductService : IProductServise
    {
        /// <summary>
        /// Получение товаров по Ид группы товаров.
        /// </summary>
        /// <param name="groupProductId">Ид группы товаров.</param>
        /// <returns>Товары.</returns>
        public IList<ProductDTO> GetProducts(int groupProductId)
        {
            IList<ProductDTO> products;
            try
            {
                ProductDAO productDAO = new ProductDAO();
                products = productDAO.GetProducts(groupProductId);
            }
            catch 
            {
                throw new Exception("Ошибка во время получения данных");
            }

            return products;
        }
    }
}
