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
            Models.OrderService orderservice = new Models.OrderService();
            var order = orderservice.GetOrderById("123");
            ViewBag.CustId = order.CustID;
            ViewBag.CustName = order.CustName;
            return View();
        }

    }
}
