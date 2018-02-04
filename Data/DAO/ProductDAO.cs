using Core.Context;
using Core.DataInterfaces;
using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.DAO
{
    /// <summary>
    /// Класс доступа к данным товаров.
    /// </summary>
    public class ProductDAO : IProductDAO
    {
        //Контекст данных товаров.
        ProductContext productContext = new ProductContext();

        /// <summary>
        /// Получение товаров по Ид группы товаров.
        /// </summary>
        /// <param name="groupProductId">Ид группы товаров.</param>
        /// <returns>Товары.</returns>
        public IList<ProductDTO> GetProducts(int groupProductId)
        {
            try
            {
                return productContext.Products.Where(p => p.GroupProduct.Id == groupProductId).OrderBy(p => p.Name).Select(p => new
                {
                    pId = p.Id,
                    pName = p.Name
                }).AsEnumerable()
                .Select(product => new ProductDTO
                {
                    Id = product.pId,
                    Name = product.pName
                }).ToList();
            }
            catch
            {
                throw new Exception("Ошибка во время получения данных");
            }
        }
    }
}
