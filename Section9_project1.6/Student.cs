using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlibrary
{
	public class Student : Interface1
	{
		private string _sname;

		public string SName
		{
			get { return _sname; }
			set { _sname = value; }
		}

		private int _class;

		public int Class
		{
			get { return _class; }
			set { _class = value; }
		}
		private string _section;

		public string Section
		{
			get { return _section; }
			set { _section = value; }
		}
		public static List<Student> StudentList = new List<Student>();
		public void Addtolist(Student s)
		{
            StudentList.Add(s);

        }
		public void PrintData()
		{
			foreach (var item in StudentList)
			{
                Console.WriteLine($"Student Name : {item._sname}  Class : {item._class}");
            }




		}
	}
}
