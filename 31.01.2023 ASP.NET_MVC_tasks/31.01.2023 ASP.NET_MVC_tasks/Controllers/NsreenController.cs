using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _31._01._2023_ASP.NET_MVC_tasks.Controllers
{
    public class NsreenController : Controller
    {
        // GET: Nsreen
        public ActionResult Index()
        {
            return View();
        }

        public string Age()
        {
            return "My Age is : 26 Years Old";
        }

        public string Name()
        {
            return "My Name is : Nsreen Nedal Kamel Al-Daraghmeh";
        }

        public string Image()
        {
            return "<img src='../img/nsreen.jpg'>";
        }


        public string Email()
        {
            return "My Email is  : nsreendaraghmeh@yahoo.com";
        }





    }
}