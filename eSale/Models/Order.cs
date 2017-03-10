using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSale.Models
{
    public class Order
    {
        /// <summary>
        /// 訂單編號
        /// </summary>
        public int OrderID { get; set;}

        /// <summary>
        /// 客戶代號
        /// </summary>
        public string CustID { get; set;}

        /// <summary>
        /// 客戶名稱
        /// </summary>
        public string CustName { get; set;}

        /// <summary>
        /// 訂單日期
        /// </summary>
        public DateTime? OrderDate { get; set;}


    }
}