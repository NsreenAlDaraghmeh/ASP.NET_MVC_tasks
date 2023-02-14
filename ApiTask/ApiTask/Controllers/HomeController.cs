using ApiTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiTask.Controllers
{
    public class HomeController : Controller
    {
       Entities1 moath = new Entities1();
        public ActionResult Index(int id)
        {
            ViewBag.Title = "Home Page";

            var lubna = moath.Majors.Where(x=>x.faculitiy_id== id);
                return View(lubna);
           


           
        }
    }
}
