using BLL_library;
using DAL_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*  MyContext context = new MyContext();
              context.depttable.Add(new deptmaster { deptcode = 1, deptname= "ECE" });
              context.depttable.Add(new deptmaster { deptcode = 2, deptname = "CSE" });
              context.depttable.Add(new deptmaster { deptcode = 3, deptname = "MECH" });
              context.depttable.Add(new deptmaster { deptcode = 4, deptname = "CIVIL" });
              context.depttable.Add(new deptmaster { deptcode = 5, deptname = "EEE" });
              context.emptable.Add(new empprofile { empcode = 1, empname = "Nani",dob = new DateTime(2000, 11, 11),email="naveena@123",deptcode=1});
              context.emptable.Add(new empprofile { empcode = 2, empname = "sweety", dob = new DateTime(2001, 10, 11), email = "sam@123", deptcode = 2 });
              context.emptable.Add(new empprofile { empcode = 3, empname = "pinky", dob = new DateTime(2002, 9, 11), email = "name@123", deptcode = 3 });
              context.emptable.Add(new empprofile { empcode = 4, empname = "sony", dob = new DateTime(2003, 8, 11), email = "magic@123", deptcode = 4 });
              context.emptable.Add(new empprofile { empcode = 5, empname = "bunny", dob = new DateTime(2004, 11, 11), email = "life@123", deptcode = 5 });
              context.SaveChanges();
              Console.WriteLine("done");
              Console.Read();*/
            bll_class co = new bll_class();
            List<empprofile> employees = co.ShowEmployeeList();

            foreach (var item in employees)
            {
                Console.WriteLine(item.empcode + " " + item.empname +" "+ item.dob + " "+item.email+" "+item.deptcode);
            }

          Console.WriteLine("=---------------------------");
            empprofile bal = new empprofile();
             Console.WriteLine("Update Employee");
              Console.WriteLine("enter empcode to update");
              bal.empcode = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("enter empname");
              bal.empname = Console.ReadLine();
              Console.WriteLine("enter dob");
              bal.dob = Convert.ToDateTime(Console.ReadLine());
              Console.WriteLine("enter email");
              bal.email = Console.ReadLine();
              Console.WriteLine("enter deptcode ");
              bal.deptcode = Convert.ToInt32(Console.ReadLine());
              co.EditEmployee(bal);
              Console.WriteLine("Updated successfully");
              Console.WriteLine("------------------------------");


              Console.WriteLine("Add employee");
              Console.WriteLine("enter empcode");

              bal.empcode = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("enter empname");
              bal.empname = Console.ReadLine();

              Console.WriteLine("enter email");
              bal.email = Console.ReadLine();
              Console.WriteLine("enter deptcode");

              bal.deptcode = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("enter dob");

              bal.dob = Convert.ToDateTime(Console.ReadLine());

              co.AddEmployee(bal);
              Console.WriteLine("Added successfully");

            Console.WriteLine("------------------------------");

            Console.WriteLine("Delete employee using empcode");
            Console.WriteLine("enter empcode to delete");
            int empcode = Convert.ToInt32(Console.ReadLine());
            co.RemoveEmployee(empcode);
            Console.WriteLine("Deleted successfully....");
            Console.ReadLine();
        }
    }
}
