using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTful_API_Practice.Models
{
    public class DrinkProduct : IDrinkProduct
    {
        public int NumInStock { get; set; }
        public string Price { get; set; }
        public string ProductName { get; set; }
        public int Calories { get; set; }
        public bool IsDecaf { get; set; } = false;
    }
}