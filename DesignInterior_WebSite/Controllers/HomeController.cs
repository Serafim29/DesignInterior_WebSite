using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignInterior_WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {

            return View();
        }
        public ActionResult Contacts(string package = null)
        {
            ViewBag.SelectedPackage = package;
            return View();
        }
        public ActionResult Portofolio()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult SignIn()
        {
            return View();
        }
        public ActionResult ServiceDetails(int id)
        {
            ViewBag.PackageId = id;
            return View();
        }
    }
}