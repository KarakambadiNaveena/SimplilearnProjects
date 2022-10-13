using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Helper_library;
using WebApiDemo.Models;
using BLL_library;


namespace WebApiDemo.Controllers
{
    public class StudentwebController : ApiController
    {
        helper_class obj = null;
        public StudentwebController()
        {
            obj = new helper_class();
        }
        // GET api/<controller>
        public List<Studentwebmodel> GetStudList()
        {
            List<BLL_class> studbal = new List<BLL_class>();
            studbal = obj.ShowStudentList();
            List<Studentwebmodel> s = new List<Studentwebmodel>();
            foreach (var item in studbal)
            {
                //Employees emp = new Employees();

                s.Add(new Studentwebmodel { StudentID = item.StudentID, StudName = item.StudName, StudentClass = item.StudentClass , studmarks = item.studmarks });

            }
            return s;
        }

        // GET api/<controller>/5
        public Studentwebmodel GetStudentByID(int id)
        {
            BLL_class bal = new BLL_class();
            bal = obj.SearchStudent(id);
            Studentwebmodel s = new Studentwebmodel();
            s.StudentID = id;
            s.StudName = bal.StudName;
            s.StudentClass = bal.StudentClass;
            s.studmarks=bal.studmarks;
            return s;
            //return "value";
        }

        // POST api/<controller>
        public HttpResponseMessage PostStudent([FromBody] Studentwebmodel studdata)
        {
            BLL_class bal = new BLL_class();
            bal.StudentID = studdata.StudentID;
            bal.StudName = studdata.StudName;
            bal.StudentClass = studdata.StudentClass;
            bal.studmarks = studdata.studmarks;
            


            bool ans = obj.AddStudent(bal);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }



        }

        // PUT api/<controller>/5
        public HttpResponseMessage PutStudent(int id, [FromBody] Studentwebmodel studdata)
        {
            BLL_class bal = new BLL_class();
            bal.StudentID = id;
            bal.StudName = studdata.StudName;
            bal.StudentClass = studdata.StudentClass;
            bal.studmarks=studdata.studmarks;
           



            bool ans = obj.EditStudent(id, bal);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage DeleteStudent(int id)
        {
            bool ans = obj.RemoveStudent(id);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

        }
    }
}