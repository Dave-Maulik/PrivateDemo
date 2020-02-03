using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class loginController : Controller
    {
        IOperations ie;
        // GET: login
        public loginController()
        {
            ie = new DatabaseOperations();
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(User user)
        {
            var model = ie.GetOne(user);
            var CurrentPassword = user.Password;
            if (CurrentPassword == model)
            {
                return RedirectToAction("Index", "Home", user);
               // return RedirectToAction("","",)
            }
            return View();
        }
    }
}