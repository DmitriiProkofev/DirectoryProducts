using Core.Domain;
using Core.ManagerInterfaces;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manager
{
    public class ProductManager : IProductManager
    {
        public IList<Product> GetProducts(int groupProductId)
        {
            IList<Product> result = null;
            //var channel = GetChannel();
            //if (channel == null) return null;
            //try
            //{
            //    using ((IDisposable)channel)
            //    {
            //        result = channel.GetByFeatureObjectId(id);
            //    }
            //}

            try
            {
                ProductService productService = new ProductService();
                return result = productService.GetProducts(groupProductId);
            }
            catch (Exception e)
            {
                throw new Exception("Не удалось выполнить запрос к серверу.");
            }
        }
    }
}
