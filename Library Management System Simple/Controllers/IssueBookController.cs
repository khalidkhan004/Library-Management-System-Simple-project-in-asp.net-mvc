﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library_Management_System_Simple.Models;

namespace Library_Management_System_Simple.Controllers
{
   
    public class IssueBookController : Controller
    {
        private Library_management_system_DBEntities db = new Library_management_system_DBEntities();
        // GET: IssueBook
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult getMid(int mid)
        {
            var memberid = (from s in db.members where s.id == mid select s.name).ToList();
            return Json(memberid ,JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Getbook()
        {
            var books = db.books.Select(p => new
            {
                ID = p.id,
                Bname = p.bname
            }).ToList();
            return Json(books, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Save(issuebook issue)
        {
            if (ModelState.IsValid)
            {
                db.issuebooks.Add(issue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(issue);
        }
    }
}