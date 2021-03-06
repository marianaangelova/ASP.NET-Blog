﻿using MVC_Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            var posts = db.Posts.OrderByDescending(p => p.Date);
            return View(posts.ToList());
        }


        public ActionResult Blog()
        {
            return View("Blog");
        }

        public ActionResult About()
        {
            return View("About");
        }

        public ActionResult Contacts()
        {
            return View("Contacts");
        }

        public ActionResult UserProfile()
        {
            return View("UserProfile");
        }
    }
}