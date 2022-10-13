using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        static List<string> mylist = null;
        static ValuesController()
        {
            mylist = new List<string>();
            mylist.Add("Hello");
            mylist.Add("Welcome");
        }
        public List<string> Get()
        {
            //return new string[] { "value1", "value2" };


            return mylist;
        }

        // GET api/values/5
        public string Get(int id)
        {

            return mylist.ElementAt(id);
        }

        // POST api/values
        public void Post([FromBody] string value)
        {

            mylist.Add(value);
        }

        // PUT api/values/5---Update
        public void Put(int id, [FromBody] string value)
        {
            mylist.RemoveAt(id);
            mylist.Insert(id, value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            mylist.RemoveAt(id);
        }
    }
}