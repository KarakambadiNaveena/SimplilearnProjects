using blog_application.Models;
using Dal_lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace blog_application.Controllers
{
    public class employeeController : ApiController
    {
        operation log;

        public employeeController()
        {
            log = new operation();
        }
        //  [Route("getemp")]
        public List<empmodel> Getemp()
        {
            var ans = log.GetAllEmp();
            List<empmodel> emplist = new List<empmodel>();
            foreach (var item in ans)
            {
                emplist.Add(new empmodel()
                {
                    EmailId = item.EmailId,
                    Name = item.Name,
                    DateOfJoining = item.DateOfJoining,
                    PassCode = item.PassCode
                });
            }
            return emplist;
        }

        // GET api/<controller>/5


        // POST api/<controller>

        public void Postemp([FromBody] empmodel value)
        {
            EmpInfo emp = new EmpInfo();
            emp.EmailId = value.EmailId;
            emp.Name = value.Name;
            emp.DateOfJoining = value.DateOfJoining;
            emp.PassCode = value.PassCode;


            log.AddEmp(emp);
        }

        // PUT api/<controller>/5
        public void Putemp(int id, [FromBody] empmodel value)
        {
            EmpInfo emp = new EmpInfo();
            emp.EmailId = value.EmailId;
            emp.Name = value.Name;
            emp.DateOfJoining = value.DateOfJoining;
            emp.PassCode = value.PassCode;
            log.UpdateEmployeeDetails(id, emp);
        }

        // DELETE api/<controller>/5
        public void Deleteemp(int id)
        {
            log.DeleteEmployeeDetails(id);
        }

    }
}