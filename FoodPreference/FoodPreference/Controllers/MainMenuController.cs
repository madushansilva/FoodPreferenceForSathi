using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodPreference.Controllers
{
    public class MainMenuController : Controller
    {
        // GET: MainMenu
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult StaffMenu()
        {
            return RedirectToAction("Index", "Staff");
        }
    }
}