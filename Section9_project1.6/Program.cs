using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPlibrary;

namespace OOPproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu 1 for student, 2 for Teacher, 3  for Subject");
            int ch = Convert.ToInt32(Console.ReadLine());
            
           
            bool status;
            string temp;
            status = false;


            do { 
            switch (ch)
                {
                    case 1:
                        Student s = new Student();

                        Console.WriteLine("Enter student name");
                        s.SName = Console.ReadLine();
                        Console.WriteLine("Enter class");
                        s.Class = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter section");
                        s.Section = Console.ReadLine();
                        s.Addtolist(s);
                    
                        Console.WriteLine("Printing student details ");
                        
                        s.PrintData();
                       
                        Console.WriteLine("do you want to continue(Y/N)");
                        temp = Console.ReadLine();
                        if (temp == "y" || temp == "Y")
                        {
                            status = true;
                        }
                    
                        break;
                    case 2:
                        Teacher t = new Teacher();

                        Console.WriteLine("Enter teacher name");
                        t.TName = Console.ReadLine();
                        Console.WriteLine("Enter class");
                        t.Tclass = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter section");
                        t.TSection = Console.ReadLine();
                        Console.WriteLine("Enter subject");
                        t.Subject = Console.ReadLine();
                        t.Addtolist(t);

                        Console.WriteLine("Printing  teacher details");
                        t.PrintData();
                        Console.WriteLine("do you want to continue(Y/N)");
                        temp = Console.ReadLine();
                        if (temp == "y" || temp == "Y")
                        {
                        status = true;
                        }
                        
                            break;
                    case 3:
                        Subject su = new Subject();

                        Console.WriteLine("Enter subject name");
                        su.SubName = Console.ReadLine();
                        Console.WriteLine("Enter subject code");
                        su.Code = Convert.ToInt32(Console.ReadLine());
                        su.Addtolist(su);
                        Console.WriteLine("Printing subject details");
                        su.PrintData();
                        Console.WriteLine("do you want to continue(Y/N)");
                        temp = Console.ReadLine();
                        if (temp == "y" || temp == "Y")
                        {
                        status = true;
                        }
                    
                         break;
                        default:
                        Environment.Exit(1);
                        break;
            }
            } while (status);
        } 





    }
}
 

