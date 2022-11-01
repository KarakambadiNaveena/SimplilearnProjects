using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestingProject
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                #region CreateFile
               //File.Create("Student.txt");
               // File.Create("Teacher.txt");
               // File.Create("Subject.txt"); 
                #endregion
                //Student s = new Student();
                //s.FileWrite();
              // s.FileRead();
               // s.PrintStudent();
               // Teacher t = new Teacher();
               // t.FileWrite();
                //t.FileRead();
                //t.ShowList();
                //Subject ss = new Subject();
                //ss.FileWrite();
                //ss.FileRead();
               // ss.PrintData();
                bool con;
                do
                {

                    Console.WriteLine("1.Add 2.Print 3.Search");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("1.Student 2.Teacher 3.Subject");
                            int ch1 = Convert.ToInt32(Console.ReadLine());
                            switch (ch1)
                            {
                                case 1:
                                    Student s = new Student();
                                    s.FileWrite();
                                    break;
                                case 2:
                                    Teacher t = new Teacher();
                                    t.FileWrite();
                                    break;
                                case 3:
                                    Subject ss = new Subject();
                                    ss.FileWrite();
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("1.Student 2.Teacher 3.Subject");
                            int ch2 = Convert.ToInt32(Console.ReadLine());
                            switch (ch2)
                            {
                                case 1:
                                    Student s = new Student();
                                    s.FileRead();
                                    s.PrintData();
                                    break;
                                case 2:
                                    Teacher t = new Teacher();
                                    t.FileRead();
                                    t.PrintData();

                                    break;
                                case 3:
                                    Subject ss = new Subject();
                                    ss.FileRead();
                                    ss.PrintData();
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("1.Student 2.Teacher 3.Subject");
                            int ch3 = Convert.ToInt32(Console.ReadLine());
                            switch (ch3)
                            {
                                case 1:
                                    Student s = new Student();
                                    s.SearchStudent();
                                    break;
                                case 2:
                                    Teacher t = new Teacher();
                                    t.SearchTeacher();

                                    break;
                                case 3:
                                    Subject ss = new Subject();
                                    ss.SearchSubject();
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:


                            break;
                    }
                    Console.WriteLine("Do you want to continue(Y/N) : ");
                    string ans = Console.ReadLine();
                    if (ans == "y" || ans == "Y")
                    {
                        con = true;
                    }
                    else
                    {
                        con = false;
                    }
                } while (con);
            }
        }
    }

    

