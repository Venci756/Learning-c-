using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TrteMrte.Controllers
{
    public class HomeController : Controller
    {     
      

        public ActionResult AboutUs()
        {           
            return View();
        }


        public ActionResult Index()
        {
            return RedirectToAction("AboutUS");
        }
        
        public ActionResult File()
        {         
            return File("~/TextFajlovi/TrteMrte.txt" ,"application/txt");
        }

    }
}