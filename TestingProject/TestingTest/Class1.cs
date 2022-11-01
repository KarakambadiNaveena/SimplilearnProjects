using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject;
using System.Runtime.InteropServices;
namespace TestingTest
{
    public class SchoolTest
    {
        Student s = new Student();
        Teacher t = new Teacher();
        Subject sub = new Subject();
        public SchoolTest()
        {
            s.FileRead();
        }
        [TestCase("Sweety", ExpectedResult = true)]
        [TestCase("sweety", ExpectedResult = true)]
        [TestCase("Nani", ExpectedResult = true)]
        [TestCase("Siri", ExpectedResult = false)]
        public bool FindStudent(string ans)
        { 
     
            return s.SearchByName(ans);
        }
        [TestCase("Ram", ExpectedResult = true)]
        [TestCase("Raj", ExpectedResult = true)]
        [TestCase("Siri", ExpectedResult = false)]
        [TestCase("Shrini", ExpectedResult = true)]
        public bool FindTeacher(string ans)
        {
            return t.SearchByName(ans);
        }
        [TestCase("Maths", ExpectedResult = true)]
        [TestCase("Physics", ExpectedResult = false)]
        [TestCase("Telugu", ExpectedResult = true)]
        [TestCase("Hindi", ExpectedResult = true)]
        public bool FindSubject(string ans)
        {
            return sub.SearchByName(ans);
        }



    }
}
