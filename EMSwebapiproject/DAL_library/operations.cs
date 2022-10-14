using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_library
{
    public class operations
    {
        public List<empprofile> GetEmployees()
        {
            MyContext context = new MyContext();

            List<empprofile> clist = context.emptable.ToList();
            List<empprofile> cblist = new List<empprofile>();
            foreach (var item in clist)
            {
                cblist.Add(new empprofile { empcode = item.empcode, empname = item.empname, dob = item.dob, email = item.email, deptcode = item.deptcode });



            }
            return cblist;
        }
        public void UpdateEmployee(empprofile bal)
        {
            MyContext context = new MyContext();
            List<empprofile> employees = context.emptable.ToList();
            empprofile obj = employees.Find(cust => cust.empcode == bal.empcode);
            obj.empname = bal.empname;
            obj.dob = bal.dob;
            obj.email = bal.email;
            obj.deptcode = bal.deptcode;
            context.SaveChanges();

        }
        public void Insertemployee(empprofile bal)
        {
            MyContext context = new MyContext();
            empprofile c = new empprofile();
            c.empcode = bal.empcode;
            c.empname = bal.empname;
            c.email = bal.email;
            c.deptcode = bal.deptcode;
            c.dob = bal.dob;

            context.emptable.Add(c);
            context.SaveChanges();

        }
        public void DeleteEmployee(int empcode)
        {

            MyContext context = new MyContext();
            List<empprofile> employees = context.emptable.ToList();
            empprofile obj = employees.Find(cust => cust.empcode == empcode);
            context.emptable.Remove(obj);

            context.SaveChanges();
        }
    }
}

