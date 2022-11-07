using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using UI_layer.Models;
using Dal_lib;
using System.Runtime.Remoting.Messaging;

namespace UI_layer.Controllers
{
    public class empuiController : Controller
    {
        // GET: empui
     MyContext db=new MyContext(); 
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Login(Adminmodel log)
        {
            var user = db.AdminInfos.Where(x => x.EmailId == log.EmailId && x.Password == log.Password).Count();
            if (user > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Index()
        {
            List<empmodel> emplist = new List<empmodel>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44378//api/");

                var responseTask = client.GetAsync("employee");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readData = result.Content.ReadAsAsync<empmodel[]>();
                    readData.Wait();
                    var empdata = readData.Result;
                    foreach (var item in empdata)
                    {
                        emplist.Add(new empmodel
                        {
                            EmailId = item.EmailId,
                            Name = item.Name,
                            DateOfJoining = item.DateOfJoining,
                            PassCode = item.PassCode
                        });

                    }
                }
            }
            return View(emplist);

        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]

        public ActionResult Create(empmodel empmodel)
        {


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44378//api/employee");

                var emp = new empmodel
                {
                    EmailId = empmodel.EmailId,
                    Name = empmodel.Name,
                    DateOfJoining = empmodel.DateOfJoining,
                    PassCode = empmodel.PassCode
                };

                var postTask = client.PostAsJsonAsync<empmodel>(client.BaseAddress, emp);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readtaskResult = result.Content.ReadAsAsync<empmodel>();

                    readtaskResult.Wait();
                    var dataInserted = readtaskResult.Result;
                }


            }

            return RedirectToAction("Index");
        }

        operation op = null;
        public empuiController()
        {
            op = new operation();
        }
      
        public ActionResult Edit(int id)
        {
            var emp = op.Getempbyid(id);
            empmodel model = new empmodel();
            model.PassCode = id;
            model.EmailId=emp.EmailId;
            model.Name = emp.Name;
            model.DateOfJoining = emp.DateOfJoining;
           
            return View(model);
        }

        // POST: Emp/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var emp = op.Getempbyid(id);
                emp.EmailId = Request["EmailId"].ToString();
              
                emp.Name = Request["Name"].ToString();
                emp.DateOfJoining = Convert.ToDateTime(Request["DateOfJoining"]);
                emp.PassCode = Convert.ToInt32(Request["PassCode"]);
                bool ans =op.UpdateEmployeeDetails(id, emp);
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

        // GET: Emp/Delete/5
        public ActionResult Delete(int id)
        {
            var emp = op.Getempbyid(id);
           empmodel model = new empmodel();
            model.PassCode = id;
            model.EmailId = emp.EmailId;
            model.Name = emp.Name;
            model.DateOfJoining = emp.DateOfJoining;
          
            return View(model);
        }

        // POST: Emp/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var dataFound = op.Getempbyid(id);
                if (dataFound != null)
                {
                    bool ans = op.DeleteEmployeeDetails(id);
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