using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class SignupController : Controller
    {
        IOperations ie;
        public SignupController()
        {
            ie = new DatabaseOperations();
        }
        // GET: Signup
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(User user)
        {
            ie.AddUser(user);
            return View();
        }
    }
}