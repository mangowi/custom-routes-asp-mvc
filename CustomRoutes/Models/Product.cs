﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomRoutes.Models
{

  
    public class Product
    {

        public string Name { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}