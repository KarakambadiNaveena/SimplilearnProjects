using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsproject
{
    public class CClass
    {
        private string name;
        private Teacher classTeacher;
        private List<Student> students;
        private List<Subject> subjects;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Teacher ClassTeacher
        {
            get { return classTeacher; }
            set { classTeacher = value; }
        }

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public List<Subject> Subjects
        {
            get { return subjects; }
            set { subjects = value; }
        }
    }
}


    

