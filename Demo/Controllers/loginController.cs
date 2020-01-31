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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(User user)
        {
            var model = ie.GetOne(user);
            var CurrentEmail = user.Email;
            if (CurrentEmail == model.Email)
            {
                return RedirectToAction("Index","Home");
            }
            return View();
            
        }
    }
}