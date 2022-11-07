using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal_lib;
using NUnit.Framework;

namespace Unit_Test
{
  
        [TestFixture]
        public class blog_app_test
        {
            [TestCase]
            public void Admin_mail_Test()
            {
                
            MyContext db = new MyContext();
                var found = db.AdminInfos.ToList();

                Assert.AreEqual("naveena@gmail.com", found[0].EmailId);

            }
        [TestCase]
        public void Admin_password_Test()
        {

            MyContext db = new MyContext();
            var found = db.AdminInfos.ToList();

            Assert.AreEqual("naveena123", found[0].Password);

        }
        validate v=new validate();  
        [TestCase]
        public void AdminTest()
        {
            v.check();
            

        }
    }
    }
