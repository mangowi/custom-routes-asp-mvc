using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomRoutes.Models
{
    public class ProductManager
    {
        public static List<Product> GetProducts()
        {


            List<Product> products = new List<Product>{


            new Product { Name="dOT Product", Description="This that", ProductId= 23, Price=19.9M, Category = "Leo" },
            new Product { Name="POT Product", Description="This that", ProductId= 234, Price=10.2M, Category = "Leo" },
            new Product { Name="COT Product", Description="This that", ProductId=123, Price=19.3M, Category = "MwaLeo" },
            new Product { Name="WPOT Product", Description="This that", ProductId= 2234, Price=10.2M, Category = "MWaLeo" }


            };

            return products;
        }
    }
}