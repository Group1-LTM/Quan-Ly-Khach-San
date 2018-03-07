﻿using Models;
using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace piccatinh.com.Areas.Administrator.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        // GET: Administrator/Category
        public ActionResult Index()
        {
            var iplCate = new CategoryModel();
            var model = iplCate.ListAll();
            return View(model);
        }

        // GET: Administrator/Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Administrator/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Category/Create
        [HttpPost]
        public ActionResult Create(Category collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                return View(collection);

            }
            catch
            {
                return View();
            }
        }

        // GET: Administrator/Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Administrator/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Administrator/Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Administrator/Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
