using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceproject
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                runApp();
            }

            public static void runApp()
            {

                Teacher teacher = new Teacher();
                teacher.Name = "Mahesh Babu";
                teacher.Address = "Mumbai";
                teacher.DateOfJoining = DateTime.Today;

                Student student = new Student();
                student.Name = "Samantha";
                student.Address = "America";
                student.DateOfJoining = DateTime.Today;

                OfficeStaff staff = new OfficeStaff();
                staff.Name = "Shrini";
                staff.Address = "pune";
                staff.DateOfJoining = DateTime.Today;


                Console.WriteLine(teacher.getInfo() + "\n" + teacher.getTypeOfPerson());
                Console.WriteLine(student.getInfo() + "\n" + student.getTypeOfPerson());
                Console.WriteLine(staff.getInfo() + "\n" + staff.getTypeOfPerson());
            }
        }
    }


    

