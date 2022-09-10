using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structproject
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                doApp();
            }

            public static void doApp()
            {

                Student[] students = new Student[3];
                for (int i = 0; i < students.Length; i++)
                {
                    students[i].name = "Sweety " + i.ToString();
                    students[i].address = "Tirupati ";
                    students[i].rollNumber = 10;
                    students[i].className = " CSE";
                    students[i].dateOfBirth = Convert.ToDateTime("1992-09-10 00:00:00");
                }

                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine(students[i].name + ",");
                    Console.WriteLine(students[i].address + ",");
                    Console.WriteLine(students[i].rollNumber + ",");
                    Console.WriteLine(students[i].className + ",");
                    Console.WriteLine(students[i].dateOfBirth);
                   
                }
            }
        }

        struct Student
        {
            public string name;
            public string address;
            public int rollNumber;
            public string className;
            public DateTime dateOfBirth;
        }
    }



    

