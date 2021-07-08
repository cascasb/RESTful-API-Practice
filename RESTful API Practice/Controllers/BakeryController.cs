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
        List<MenuItem> menu = new List<MenuItem>();

        public BakeryController()
        {
            menu.Add(new MenuItem { ItemName = "Black Coffee", Calories = 1, Price = "$1.00" });
            menu.Add(new MenuItem { ItemName = "Croissant", Calories = 250, Price = "$3.00" });
            menu.Add(new MenuItem { ItemName = "Cheesecake Slice", Calories = 400, Price = "$3.50" });
        }

        // GET: api/Bakery
        [Route("api/Bakery/GetMenu")]
        [HttpGet]
        public IEnumerable<MenuItem> GetMenu()
        {
            return menu;
        }

        [Route("api/Bakery/GetItemNames")]
        [HttpGet]
        public IEnumerable<String> GetItemNames()
        {
            List<string> output = new List<String>();
            foreach (var item in menu)
            {
                output.Add(item.ItemName);
            }
            return output;
        }

        // GET: api/Bakery/nameOfItem
        [Route("api/Bakery/Name/{name}")]
        [HttpGet]
        public MenuItem GetItemByName([FromUri]string name)
        {
            //return menu.Where(x => x.ItemName == name).FirstOrDefault();
            foreach (var item in menu)
            {
                if (item.ItemName == name)
                {
                    return item;
                }
            }
            return null;
        }

        // GET: api/Bakery/#
        [Route("api/Bakery/Cal/{cal}")]
        [HttpGet]
        public MenuItem GetItemByCal(int cal)
        {
            return menu.Where(x => x.Calories == cal).FirstOrDefault();
        }


        // POST: api/Bakery
        public void PostItem(MenuItem item)
        {
            menu.Add(item);
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
