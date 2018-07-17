﻿using Roomy.Data;
using Roomy.Models;
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