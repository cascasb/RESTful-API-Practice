using RESTful_API_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTful_API_Practice.Controllers
{
    public class BakeryController : ApiController
    {
        List<IBakeryProduct> inventory = new List<IBakeryProduct>();

        public BakeryController()
        {
            inventory.Add(new FoodProduct { ProductName = "Croissant", Calories = 250, Price = "$3.00", NumInStock = 3 });
            inventory.Add(new DrinkProduct { ProductName = "Latte", Calories = 200, Price = "$2.50", IsDecaf = false, NumInStock = 0 });
            inventory.Add(new DishesProduct { ProductName = "Souvenir Mug", Price = "$5.00", Color = "Blue", NumInStock = 2, IsDishwasherSafe = true }) ;
        }

        // GET: api/Bakery
        [Route("api/Bakery/GetInventory")]
        [HttpGet]
        public IEnumerable<IBakeryProduct> GetMenu()
        {
            return inventory;
        }

        [Route("api/Bakery/GetItemNames")]
        [HttpGet]
        public IEnumerable<String> GetItemNames()
        {
            List<string> output = new List<String>();
            foreach (var item in inventory)
            {
                output.Add(item.ProductName);
            }
            return output;
        }

        // GET: api/Bakery/nameOfItem
        [Route("api/Bakery/Name/{name}")]
        [HttpGet]
        public IBakeryProduct GetItemByName([FromUri]string name)
        {
            //return menu.Where(x => x.ItemName == name).FirstOrDefault();
            foreach (var item in inventory)
            {
                if (item.ProductName == name)
                {
                    return item;
                }
            }
            return null;
        }

        // GET: api/Bakery/#
        [Route("api/Bakery/Cal/{cal}")]
        [HttpGet]
        public IBakeryProduct GetItemByCal(int cal)
        {
            foreach (IFoodProduct item in inventory)
            {
                if (item.Calories == cal)
                {
                    return item;
                }
            }
            return null;
        }


        // POST: api/Bakery
        public void PostItem(IBakeryProduct item)
        {
            inventory.Add(item);
        }

        // PUT: api/Bakery/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Bakery/5
        public void Delete(int id)
        {
        }
    }
}
