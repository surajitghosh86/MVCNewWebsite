using MVC_NewWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_NewWebsite.Controllers
{
    public class LoginController : Controller
    {
        #region LOGIN
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        } 
        #endregion

        #region EMPLOYEE_LOGIN
        [HttpGet]
        public ActionResult LoginEmployee()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateGoogleCaptcha]
        public ActionResult LoginEmployee(Users users)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/Home/Index");
            }
            return View();
        }
        #endregion

        #region ADMIN_LOGIN
        [HttpGet]
        public ActionResult LoginAdmin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateGoogleCaptcha]
        public ActionResult LoginAdmin(Users users)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/Home/Index");
            }
            return View();
        }
        #endregion

        #region REGISTRATION
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateGoogleCaptcha]
        public ActionResult Registration(Users users)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/Login/LoginEmployee");
            }
            return View();
        } 
        #endregion
    }
}