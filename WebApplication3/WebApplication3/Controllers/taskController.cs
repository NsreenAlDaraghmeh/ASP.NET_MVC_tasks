using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class taskController : Controller
    {
        // GET: task
        public ActionResult task0()
        {
          
            List<Models.student> students = new List<Models.student>();
            students.Add(new Models.student() { Id = 1, Name = "Nsreen", Major = "Mathematics", Faculity = "Sciences and Literature", });
            students.Add(new Models.student() { Id = 2, Name = "Laila", Major = "English", Faculity = "Sciences and Literature", });
            students.Add(new Models.student() { Id = 3, Name = "Kamel", Major = "Mechanical Engineering", Faculity = "Engineering", });
            return View(students);
        }
    }
}