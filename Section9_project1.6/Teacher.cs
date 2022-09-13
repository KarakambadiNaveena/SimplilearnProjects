using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlibrary
{
	public class Teacher : Interface1
	{
		private string _tname;

		public string TName
		{
			get { return _tname; }
			set { _tname = value; }
		}
		private int _tclass;

		public int Tclass
		{
			get { return _tclass; }
			set { _tclass = value; }
		}
		private string _tsection;

		public string TSection
		{
			get { return _tsection; }
			set { _tsection = value; }
		}
		private string _subject;

		public string Subject
		{
			get { return _subject; }
			set { _subject = value; }
		}
		public static List<Teacher> TeacherList = new List<Teacher>();
        public void Addtolist(Teacher t)
        {
            TeacherList.Add(t);

        }

        public void PrintData()
		{
			foreach (var item in TeacherList)
			{
				Console.WriteLine("Teacher Name :" + item.TName + "  Subject : " + item.Subject);
			}



		}
	}
}
