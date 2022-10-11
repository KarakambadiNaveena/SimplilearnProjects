using BLL_library;
using Helper_library;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class StudentController : Controller
    {
        helper_class helper = null;
        public StudentController()
        {
            helper = new helper_class();
        }
        // GET: Rainbow
        public ActionResult Index()
        {
            var Studlist = helper.ShowStudentList();
            List<StudentModel> modelsList = new List<StudentModel>();
            foreach (var item in Studlist)
            {
                modelsList.Add(new StudentModel { StudentID = item.StudentID, StudName=item.StudName, StudentClass=item.StudentClass });
            }

            return View(modelsList);
        }
    

        // GET: Rainbow/Details/5
        public ActionResult Details(int id)
        {

            var data = helper.SearchStudent(id);
            StudentModel s = new StudentModel();
           s.StudentID = id;
            s.StudName = data.StudName;
            s.StudentClass = data.StudentClass;
            return View(s);
            
        }

        // GET: Rainbow/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rainbow/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
      

                BLL_class bal = new BLL_class();
                bal.StudentID = Convert.ToInt32(Request["studid"]);
                bal.StudName = Request["studname"].ToString();
                bal.StudentClass = Convert.ToInt32(Request["studclass"]);

                bool ans = helper.AddStudent(bal);
                if (ans)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }

            }
            catch (Exception ex)
            {
                ViewBag.exMsg = ex.Message;
                return View();
            }
        }


    // GET: Rainbow/Edit/5
    public ActionResult Edit(int studid)
        {
           var stud = helper.SearchStudent(studid);
            StudentModel model = new StudentModel();
            model.StudentID = studid;
            model.StudName = stud.StudName;
            model.StudentClass =stud.StudentClass;

            return View(model );
        }


        // POST: Rainbow/Edit/5
        [HttpPost]
        public ActionResult Edit(int studid, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var stud = helper.SearchStudent(studid);
                stud.StudentID = studid;
                stud.StudName = Request["studname"].ToString();
                stud.StudentClass =Convert.ToInt32( Request["studclass"]);

                bool ans = helper.EditStudent(stud);


                if (ans)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
      public ActionResult Delete(int studid)
        {
            var stud = helper.SearchStudent(studid);
            StudentModel model = new StudentModel();
            model.StudentID = studid;
            model.StudName = stud.StudName;
            model.StudentClass = stud.StudentClass;



            return View(model);
         }

        // POST: NW_Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int studid, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var dataFound = helper.SearchStudent(studid);
                if (dataFound != null)
                {
                    bool ans = helper.RemoveStudent(studid);
                    if (ans)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View();
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
    }
}
