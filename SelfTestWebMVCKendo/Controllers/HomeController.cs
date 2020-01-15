using SelfTestWebMVCKendo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelfTestWebMVCKendo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello World!";
            return View();
        }


        [HttpPost]
        public ActionResult Index(TestModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return View(model);
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

        public ActionResult RadioBoxSearch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TestContent(string[] userType, string[] deleteType, string[] activeType, string[] teacherType)
        {
            return Content("YOU WIN");
        }

        public ActionResult RadioBoxUser()
        {
            var target = new SelectList(provinces, "Id", "Name", "2");
            ViewBag.List = target;
            return View();
        }

        private List<Province> provinces => new List<Province>() { new Province { Id = 1, Name="北京"}, new Province { Id = 2, Name = "天津" } };
    }

    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}