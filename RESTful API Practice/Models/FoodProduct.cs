using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTful_API_Practice.Models
{
    public class FoodProduct : IFoodProduct
    {
        public int NumInStock { get; set; }
        public string Price { get; set; }
        public string ProductName { get; set; }
        public int Calories { get; set; } = 0;
    }
}