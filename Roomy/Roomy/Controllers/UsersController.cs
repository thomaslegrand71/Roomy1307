using Roomy.Data;
using Roomy.Models;
using Roomy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roomy.Controllers
{
    public class UsersController : Controller
    {
        private RoomyDbContext db = new RoomyDbContext();
        // GET: Users





        [HttpGet]
        public ActionResult Create()
        {

            //ViewBag.NbrPersonne = 4;
            ViewBag.Civilities = db.Civilities.ToList();

            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                db.Configuration.ValidateOnSaveEnabled = false;
                //enlever le password de la base de données une fois validé
                //ModelState.Remove("Password");
                //ModelState.Remove("ConfirmedPassword");
                user.Password = user.Password.HashMD5();
                
                //enregistrer en bdd
                db.Users.Add(user);
                db.SaveChanges();
                //redirection
            }
            ViewBag.Civilities = db.Civilities.ToList();
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}