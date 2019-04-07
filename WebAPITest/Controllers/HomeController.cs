using Mina.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPITest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDeptservice deptservice;
        public HomeController(IDeptservice deptservice)
        {
            this.deptservice = deptservice;
        }
        public ActionResult Index()
        {
            //deptservice.Add(new Mina.Entity.Dept() { Id = 1, Name = "Mina"});
            var result = deptservice.GetAll();
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
    }
}