using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsproject
{
    internal class classProgram
    {
      
            static void Main(string[] args)
            {
                runApp();
            }

            public static void runApp()
            {

                string[] arrSubjects = { "English Literature", "English Language", "Maths", "Geography", "History", "Physics", "Chemistry", "Biology" };
                string[] arrSubjectShorts = { "ELIT", "ELANG", "MATH", "GEOG", "HIST", "PHY", "CHEM", "BIO" };


                string[] arrStudents = { "Rahul Gandhi", "Vijay Mallya", "Lady Gaga", "Arun Jaitley", "MS Dhoni", "Kim Kardashian" };
                List<Student> listStudents = new List<Student>();
                List<Subject> listSubjects = new List<Subject>();

                for (int i = 0; i < arrSubjects.Length; i++)
                {
                    Subject subject = new Subject();
                    subject.Name = arrSubjects[i];
                    subject.ShortName = arrSubjectShorts[i];
                    listSubjects.Add(subject);
                }

                for (int i = 0; i < arrStudents.Length; i++)
                {
                    Student student = new Student();
                    student.Name = arrStudents[i];
                    student.Address = "Some address";
                    student.ContactNumber = "124567";
                    student.GuardianName = "My Guardian";
                    listStudents.Add(student);
                   Console.WriteLine(student.Name);
                  Console.WriteLine(student.Address);
                  Console.WriteLine(student.ContactNumber);
                  Console.WriteLine(student.GuardianName);
                }

                Teacher classTeacher = new Teacher();
                classTeacher.Name = "Mr.RadheShyam";
                classTeacher.DateOfJoining = Convert.ToDateTime("2010-09-11 00:00:00");
                classTeacher.ContactAddress = "Some address";
               Console.WriteLine(classTeacher.Name);
               Console.WriteLine(classTeacher.DateOfJoining);
               Console.WriteLine(classTeacher.ContactAddress);

                CClass class1A = new CClass();
                class1A.Name = "1A";
                class1A.Students = listStudents;
                class1A.Subjects = listSubjects;
                class1A.ClassTeacher = classTeacher;
              Console.WriteLine(class1A.Name);
              Console.WriteLine(class1A.Students);
              Console.WriteLine(class1A.Subjects);
              Console.WriteLine(class1A.ClassTeacher);
              Console.ReadLine();
            }
        }
    }




    

