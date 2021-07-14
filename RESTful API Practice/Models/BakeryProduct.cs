using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTful_API_Practice.Models
{
    public class BakeryProduct : IBakeryProduct
    {
        public string ProductName { get; set; } = "";

        public string Price { get; set; } = "";

        public int NumInStock { get; set; } = 0;
    }
}