using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject
{
    public class Student : IFileOperaions
    {
        private string _StudentName;

        public string StudentName
        {
            get { return _StudentName; }
            set { _StudentName = value; }
        }

        private int _Class;

        public int Class
        {
            get { return _Class; }
            set { _Class = value; }
        }
        //private char _Section;

        //public char Section
        //{
        //	get { return _Section; }
        //	set { _Section = value; }
        //}
        public static List<Student> StudentList = new List<Student>();
        public void PrintData()
        {
            foreach (var item in StudentList)
            {
                Console.WriteLine($"Student Name : {item.StudentName}  Class : {item.Class}");
            }
            Console.WriteLine("========================================");
        }
        public void FileWrite()
        {
            FileStream fs = new FileStream("Student.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sr = null;
            try
            {
                sr = new StreamWriter(fs);
                Console.WriteLine("Enter Student Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Class :");
                string Class = Console.ReadLine();
                sr.WriteLine(name + "-" + Class);
            }
            finally
            {
                sr.Close();
                fs.Close();

            }
        }
        public void FileRead()
        {
            FileStream fs1 = new FileStream("D:\\C#\\TestingProject\\TestingProject\\bin\\Debug\\Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(fs1);
                bool LastLine = false;
                while (!LastLine)
                {
                    Student s = new Student();
                    String temp = sr.ReadLine();
                    if (temp == null)
                    {
                        Console.WriteLine("Last Data reached...");
                        break;
                    }
                    s.StudentName = temp.Split('-')[0];
                    s.Class = Convert.ToInt32(temp.Split('-')[1]);
                    Student.StudentList.Add(s);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message form Student = " + ex.Message);

            }
            finally
            {
                sr.Close();
                fs1.Close();

            }
        }
        public void SearchStudent()
        {
            Console.WriteLine("Enter a student name: ");
            string name = Console.ReadLine();
            var Details = File.ReadLines("Student.txt").OrderBy((line => (line.Split('-')[1])))
                 .ToList();
            bool found = false;
            foreach (var item in Details)
            {

                if (item.Contains(name))
                {
                    Console.WriteLine($"Name: {item.Split('-')[0]} \nClass Room  : {item.Split('-')[1]} ");
                    found = true;

                }
            }
            if (!found)
            {
                Console.WriteLine("Student Not found or student not in the list please enter a valid Student Name");
            }
        }
        public bool SearchByName(string data)
        {
            var Details = File.ReadLines("D:\\C#\\TestingProject\\TestingProject\\bin\\Debug\\Subject.txt").OrderBy((line => (line.Split('-')[1])))
                .ToList();


            foreach (var item in Details)
            {

                if (item.Contains(data))
                {
                    return true;
                }
            }
            return false;

        }
    }
}
