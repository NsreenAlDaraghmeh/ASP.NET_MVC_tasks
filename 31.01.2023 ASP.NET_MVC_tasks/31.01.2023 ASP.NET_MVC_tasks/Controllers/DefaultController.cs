using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _31._01._2023_ASP.NET_MVC_tasks.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string ShowImage()
        {
            return "<a href='download'><img src='../img/cokdon.jfif'></a>";
        }

        public void download()
        {
            var imgPath = Server.MapPath("../img/cokdon.jfif");
            Response.AddHeader("Content-Disposition", "attachment;filename=DealerAdTemplate.png");
            Response.WriteFile(imgPath);
            Response.End();
        }



    }
}