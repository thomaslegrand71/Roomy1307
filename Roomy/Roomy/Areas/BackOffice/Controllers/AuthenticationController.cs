using Roomy.Areas.BackOffice.Models;
using Roomy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roomy.Utils;
using Roomy.Filters;

namespace Roomy.Areas.BackOffice.Controllers
{
    
    public class AuthenticationController : Controller
    {
        private RoomyDbContext db = new RoomyDbContext();


        // GET: BackOffice/Authentication/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: BackOffice/Authentication/Login
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Login(AuthenticationLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var passwordHash = model.Password.HashMD5();//insérer dans une variable car méthode non appelable dans linq
                var user = db.Users.SingleOrDefault(x => x.Mail == model.Login && x.Password == passwordHash);
                if (user == null)
                {
                    //1
                    //ModelState.AddModelError("", "mail ou password invalid");

                    //2
                    ViewBag.ErrorMessage = "mail ou password invalid";
                    return View(model);

                    //return RedirectToAction("Login");
                }
                else
                {
                    //ajout de la session
                    Session.Add("USER_BO", user);//nom USER_BO et la valeur de user en paramètre

                    //redirection
                    return RedirectToAction("Index", "Dashboard", new { area = "BackOffice" });
                }
                
            }
            return View(model);
        }

        // GET: BackOffice/Authentication/Login
        [AuthenticationFilter]
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}