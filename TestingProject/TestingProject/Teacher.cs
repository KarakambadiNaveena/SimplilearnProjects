using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject
{
    public class Teacher : IFileOperaions
    {
        private string _TeacherName;

        public string TeacherName
        {
            get { return _TeacherName; }
            set { _TeacherName = value; }
        }
        private int _Class;

        public int Class
        {
            get { return _Class; }
            set { _Class = value; }
        }
        private string _Subject;

        public string Subject
        {
            get { return _Subject; }
            set { _Subject = value; }
        }
        public static List<Teacher> TeacherList = new List<Teacher>();

        public void PrintData()
        {
            foreach (var item in TeacherList)
            {
                Console.WriteLine("Teacher Name :" + item.TeacherName + "  Subject : " + item.Subject);
            }
            Console.WriteLine("========================================");
        }
        public void FileWrite()
        {
            FileStream fs = new FileStream("Teacher.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sr = null;
            try
            {
                sr = new StreamWriter(fs);
                Console.WriteLine("Enter Teacher Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Class");
                string Class = Console.ReadLine();

                Console.WriteLine("Enter Subject :");
                string SubjectName = Console.ReadLine();
                sr.WriteLine(name + "-" + Class + "-" + SubjectName);
            }
            finally
            {
                sr.Close();
                fs.Close();
            }
        }
        public void FileRead()
        {
            FileStream fs2 = new FileStream("D:\\C#\\TestingProject\\TestingProject\\bin\\Debug\\Teacher.txt", FileMode.Open, FileAccess.Read);
            StreamReader swt = null;
            try
            {
                swt = new StreamReader(fs2);
                bool LastLine = false;
                while (!LastLine)
                {
                    Teacher s = new Teacher();
                    String temp = swt.ReadLine();
                    if (temp == null)
                    {
                        Console.WriteLine("Last Data reached...");
                        break;
                    }
                    var tempfile = temp.Split('-');
                    s.TeacherName = tempfile[0];
                    s.Class = Convert.ToInt32(tempfile[1]);
                    s.Subject = tempfile[2];
                    Teacher.TeacherList.Add(s);
                }

            }
            catch (Exception wx)
            {

                Console.WriteLine("Error message from teacher : " + wx.Message);
            }
            finally
            {
                swt.Close();
                fs2.Close();
            }
        }
        public void SearchTeacher()
        {
            Console.WriteLine("Enter Teacher  Name: ");
            string name = Console.ReadLine();
            var Details = File.ReadLines("Teacher.txt").OrderBy((line => (line.Split('-')[1])))
                 .ToList();
            bool found = false;
            foreach (var item in Details)
            {

                if (item.Contains(name))
                {
                    Console.WriteLine($"Teacher Name: {item.Split('-')[0]} \nClass   : {item.Split('-')[1]} \nSubject : {item.Split('-')[2]}");
                    found = true;

                }
            }
            if (!found)
            {
                Console.WriteLine("Teacher Not found  please enter a valid Teacher Name");
            }
        }
        public bool SearchByName(string data)
        {
            var Details = File.ReadLines("D:\\C#\\TestingProject\\TestingProject\\bin\\Debug\\Teacher.txt").OrderBy((line => (line.Split('-')[1])))
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