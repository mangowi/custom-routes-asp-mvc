using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomRoutes.Models;
namespace CustomRoutes.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {


            var products = ProductManager.GetProducts();
            return View(products);
        }
    }
}