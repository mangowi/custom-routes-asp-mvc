using CustomRoutes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomRoutes.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: 
        // /Categories
        // /Category/Gagets

        // /Category/Gagets/1
        public ActionResult Index(string category = null, int ordinal = -1)
        {
            //  Counting on the CategoriesByOrdinal route to handle teh /Categories/Widgets case
            //If no category passed, grap all category
            if (string.IsNullOrEmpty(category) && ordinal == -1)
            {
                var products = ProductManager.GetProducts();
                var categories = products.Select(p => p.Category).Distinct();
                return View("CategoryList", categories);
            }

            // /Category/Gagets
            else if (!string.IsNullOrEmpty(category) && ordinal == -1)
            {
                var products = ProductManager.GetProducts().Where(p => p.Category == category);
                ViewBag.Category = category;
                return View("ProductList", products);

            }

            // /Category/Gagets/1
            else
            {
                var products = ProductManager.GetProducts().Where(p => p.Category == category).ToList();
                var product = products[ordinal];
                return View("ProductDetail", product);

            }

        }


        public ActionResult Details(string category, int id)
        {
            var product = ProductManager.GetProducts().FirstOrDefault(p => p.Category ==  category && p.ProductId == id);
            return View("ProductDetail", product);
        }
    }
}