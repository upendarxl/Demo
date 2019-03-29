using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Student s = new Student() { id = 1, name = "Ajay", marks = 90 };

            ViewBag.student = s;
            ViewData["name"] = "Ajay";
            ViewBag.address = "Delhi";
            return View();  
        }
        public ActionResult Index1()
            {
            return View();

        }
        public ActionResult Data()
        {
            Student s = new Student() { id = 1, name = "Ajay", marks = 90 };


            return View(s);
        }

        public ActionResult Data1()
        {
            Student s = new Student() { id = 1, name = "Ajay", marks = 90 };

            return View(s);
        }
        public ActionResult List()
        {
            List<Student> list = new List<Student>()
            {
                new Student() { id = 1, name = "Ajay", marks = 90 },
                new Student() { id = 2, name = "Vijay", marks = 90 },
                new Student() { id = 3, name = "Jay", marks = 90 },
                new Student() { id = 4, name = "Ajay", marks = 90 },


        };
           // Student s = new Student() { id = 1, name = "Ajay", marks = 90 };

            return View(list);
        }

        public ActionResult List1()
        {
            List<Student> list = new List<Student>()
            {
                new Student() { id = 1, name = "Ajay", marks = 90 },
                new Student() { id = 2, name = "Vijay", marks = 90 },
                new Student() { id = 3, name = "Jay", marks = 90 },
                new Student() { id = 4, name = "Ajay", marks = 90 },


        };
            // Student s = new Student() { id = 1, name = "Ajay", marks = 90 };

            return View(list);
        }

    }
}