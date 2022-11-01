using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject
{
    public class Subject : IFileOperaions
    {
        public static List<Subject> SubjectList = new List<Subject>();

        public void PrintData()
        {
            foreach (var item in SubjectList)
            {
                Console.WriteLine("Subject Name : " + item.SubjectName + " Subject Code :" + item.SubCode);
            }
            Console.WriteLine("========================================");
        }
        private string _SubjectName;

        public string SubjectName
        {
            get { return _SubjectName; }
            set { _SubjectName = value; }
        }

        private int _SubCode;

        public int SubCode
        {
            get { return _SubCode; }
            set { _SubCode = value; }
        }
        public void FileRead()
        {
            FileStream fs3 = new FileStream("D:\\C#\\TestingProject\\TestingProject\\bin\\Debug\\Subject.txt", FileMode.Open, FileAccess.Read);
            StreamReader ss = null;

            try
            {
                ss = new StreamReader(fs3);
                bool LastLine = false;
                while (!LastLine)
                {
                    Subject s = new Subject();
                    String temp = ss.ReadLine();
                    if (temp == null)
                    {
                        Console.WriteLine("Last Data reached...");
                        break;
                    }
                    s.SubjectName = temp.Split('-')[0];
                    s.SubCode = Convert.ToInt32(temp.Split('-')[1]);
                    Subject.SubjectList.Add(s);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message = " + ex.Message);

            }
            finally
            {
                ss.Close();
                fs3.Close();

            }
        }

        public void FileWrite()
        {
            FileStream fs = new FileStream("Subject.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sr = null;
            try
            {
                sr = new StreamWriter(fs);
                Console.WriteLine("Enter Subject Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Subject Code :");
                string Class = Console.ReadLine();
                sr.WriteLine(name + "-" + Class);
            }
            finally
            {
                sr.Close();
                fs.Close();

            }

        }

        public void SearchSubject()
        {
            Console.WriteLine("Enter Subject name: ");
            string name = Console.ReadLine();
            var Details = File.ReadLines("Subject.txt").OrderBy((line => (line.Split('-')[1])))
                 .ToList();
            bool found = false;
            foreach (var item in Details)
            {

                if (item.Contains(name))
                {
                    Console.WriteLine($" Subject Name: {item.Split('-')[0]} \nSubject Code  : {item.Split('-')[1]} ");
                    found = true;

                }
            }
            if (!found)
            {
                Console.WriteLine("Subject  Not found  please enter a valid Subject Name");
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