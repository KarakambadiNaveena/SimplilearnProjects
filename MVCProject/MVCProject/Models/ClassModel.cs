using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Models
{
    public class ClassModel
    {
        private int _classno;

        public int classno
        {
            get { return _classno; }
            set { _classno = value; }
        }

        private string _section;

        public string section
        {

            get { return _section; }
            set { _section = value; }
        }
    }
}