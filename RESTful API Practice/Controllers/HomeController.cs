using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RESTful_API_Practice.Controllers
{
    //Powers the home page of the website
    //it inherits from an MVC class 'Controller'
    //This means it has a view which is located in 
    //The index view is located at: Views > Home > Index.cshtml
    //
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //This method loads the index view

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
