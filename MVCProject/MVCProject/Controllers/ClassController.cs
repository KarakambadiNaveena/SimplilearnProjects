using Helper_library;
using BLL_library;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class ClassController : Controller
    {
        helper_class helper = null;
        public ClassController()
        {
            helper = new helper_class();
        }
        // GET: Class
        public ActionResult Index()
        {
            var clist = helper.ShowClassList();
            List<ClassModel> modelsList = new List<ClassModel>();
            foreach (var item in clist)
            {
                modelsList.Add(new ClassModel { classno = item.classno, section = item.section });
            }

            return View(modelsList);
        }

        // GET: Class/Details/5
        public ActionResult Details(int id)
        {

           
            return View();

        }

        // GET: Class/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Class/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Class/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Class/Edit/5
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

        // GET: Class/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Class/Delete/5
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
