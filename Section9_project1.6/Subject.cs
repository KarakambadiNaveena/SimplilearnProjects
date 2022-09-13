using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlibrary
{
	public class Subject : Interface1
	{
		private string _subname;

		public string SubName
		{
			get { return _subname; }
			set { _subname = value; }
		}
		private int _code;

		public int Code
		{
			get { return _code; }
			set { _code = value; }
		}
		public static List<Subject> SubjectList = new List<Subject>();
        public void Addtolist(Subject su)
        {
            SubjectList.Add(su);

        }

        public void PrintData()
		{
			foreach (var item in SubjectList)
			{
				Console.WriteLine("Subject Name : " + item.SubName +  " Subject Code :" + item.Code);
			}


		}
	}
}
