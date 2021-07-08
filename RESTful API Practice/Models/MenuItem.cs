using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTful_API_Practice.Models
{
    public class MenuItem
    {
        public string ItemName { get; set; } = "";
        public int Calories { get; set; } = 0;
        public string Price { get; set; } = "$0.00";
    }
}