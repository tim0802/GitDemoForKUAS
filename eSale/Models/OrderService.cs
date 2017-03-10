using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSale.Models
{
    /// <summary>
    /// 訂單服務
    /// </summary>
    public class OrderService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        public void InsertOrer() 
        {

        }
        /// <summary>
        /// 刪除訂單By Id
        /// </summary>
        public void DeleteOrderById() 
        {

        }
        /// <summary>
        /// 更新訂單
        /// </summary>
        public void UpdateOrder()
        {
 
        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <param name="id">訂單Id</param>
        /// <returns></returns>
        public Models.Order GetOrderById(string id)
        {
            Models.Order result = new Order();
            result.CustID = "AAA";
            result.CustName = "卡加布列島";
            return result;
        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrders()
        {
            return new List<Order>();
        }
        
    }
}