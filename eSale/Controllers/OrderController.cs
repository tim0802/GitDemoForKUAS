using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eSale.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/

        public ActionResult Index()
        {
            //Models.OrderService orderservice = new Models.OrderService();
            //var order = orderservice.GetOrderById("123");
            //ViewBag.CustId = order.CustID;
            //ViewBag.CustName = order.CustName;
            
            return View();
        }

        /// <summary>
        /// 新增訂單畫面
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertOrder(Models.Order order)
        {
            ViewBag.Desc1 = "我是ViewBag";
            ViewData["Desc2"] = "我是ViewData";
            TempData["Desc3"] = "我是TempData";   
            
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 新增訂單存檔的Action
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost()]
        public ActionResult InsertOrder(Models.Order order)
        {
            Models.OrderService orderService = new Models.OrderService();
            orderService.InsertOrder(order);
            return View("Index");
        }
        [HttpGet()]
        public JsonResult TestJson()
        {
            var result = new Models.Order() { CustID = "ABC", CustName = "你好123" };
            return this.Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
