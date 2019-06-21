using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnMvc.Models;

namespace LearnMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
//            return "start";
            return View();
        }
        [HttpGet]
        public ViewResult Ask()
        {
//            return "";
            return View();
        }

        [HttpPost]
        public ViewResult Ask(Student student)
        {
            if (ModelState.IsValid)
                return View("AskSuccess", student);
            return View();
        }
    }
}