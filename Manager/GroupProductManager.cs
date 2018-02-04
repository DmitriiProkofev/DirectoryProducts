using Core.Domain;
using Core.ManagerInterfaces;
using Service;
using System;
using System.Collections.Generic;

namespace Manager
{
    public class GroupProductManager : IGroupProductManager
    {
        public IList<GroupProduct> GetGroupProducts()
        {
            IList<GroupProduct> result = null;
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
                GroupProductService groupProductService = new GroupProductService();
                return result = groupProductService.GetGroupProducts();
            }
            catch (Exception e)
            {
                throw new Exception("Не удалось выполнить запрос к серверу.");
            }
        }
    }
}
