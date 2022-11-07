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
    public class blogController : ApiController
    {
        operation log;

        public blogController()
        {
            log = new operation();
        }
       
        public List<blogmodel> Getblog()
        {
            var ans = log.GetAllblog();
            List<blogmodel> deptlist = new List<blogmodel>();
            foreach (var item in ans)
            {
                deptlist.Add(new blogmodel()
                {
                    BlogId = item.BlogId,
                    Title = item.Title,
                    Subject = item.Subject,
                    DateOfCreation = item.DateOfCreation,
                    BlogUrl = item.BlogUrl,
                    EmpEmailId = item.EmpEmailId
                });
            }
            return deptlist;
        }

        // GET api/<controller>/5


        // POST api/<controller>
        public void Postblog([FromBody] blogmodel value)
        {
            BlogInfo dept = new BlogInfo();
            dept.BlogId = value.BlogId; ;
            dept.Title = value.Title;
            dept.Subject = value.Subject;
            dept.DateOfCreation = value.DateOfCreation;
            dept.BlogUrl = value.BlogUrl;
            dept.EmpEmailId = value.EmpEmailId;
            log.Addblog(dept);
        }

        // PUT api/<controller>/5
        public void Putblog(int id, [FromBody] blogmodel value)
        {
            BlogInfo dept = new BlogInfo();
            dept.BlogId = value.BlogId; ;
            dept.Title = value.Title;
            dept.Subject = value.Subject;
            dept.DateOfCreation = value.DateOfCreation;
            dept.BlogUrl = value.BlogUrl;
            dept.EmpEmailId = value.EmpEmailId;
            log.UpdateBlogDetails(id, dept);
        }

        // DELETE api/<controller>/5
        public void Deleteblog(int id)
        {
            log.DeleteBlogDetails(id);
        }
    }
}