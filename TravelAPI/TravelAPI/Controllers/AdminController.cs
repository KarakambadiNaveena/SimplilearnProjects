using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TravelAPI.Models;

namespace TravelAPI.Controllers
{
    public class AdminController : ApiController
    {
        Operations op = new Operations();
        // GET api/<controller>
        public IEnumerable<Admin> Get()
        {
            return op.GetAdmin();
        }

        // GET api/<controller>/5
        public Admin Get(int id)
        {
            return op.GetAdmin(id);
        }

        // POST api/<controller>
        public void Post([FromBody] Admin value)
        {
            op.PostAdmin(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] Admin value)
        {
            op.PutAdmin(id, value);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            op.DeleteAdmin(id);
        }
    }
}
