using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL_library;
using DAL_library;
using EMSwebapiproject.Models;

namespace EMSwebapiproject.Controllers
{
    public class EmpController : ApiController
    {
        bll_class obj = null;
        public EmpController()
        {
            obj = new bll_class();
        }
        // GET api/<controller>
        public List<EmpModel> Get()
        {
            var ans = obj.ShowEmployeeList();
            List<EmpModel> emplist = new List<EmpModel>();
            foreach (var item in ans)
            {
                emplist.Add(new EmpModel() { empcode = item.empcode, empname = item.empname, dob = item.dob, email = item.email, deptcode = item.deptcode });
            }
            return emplist;
        }


        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] EmpModel value)
        {
            empprofile emp = new empprofile();
            emp.empcode = value.empcode;
            emp.empname = value.empname;
            emp.dob = value.dob;
            emp.deptcode = value.deptcode;
            emp.email = value.email;
            

            obj.AddEmployee(emp);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] EmpModel value)
        {
            empprofile emp = new empprofile();
            emp.empcode = value.empcode;
            emp.dob = value.dob;
            emp.empname = value.empname;
            emp.deptcode = value.deptcode;
            emp.email = value.email;
            obj.EditEmployee(emp);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            obj.RemoveEmployee(id);
        }
    }
}