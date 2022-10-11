using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Models
{
    public class SubjectModel
    {
        private int subid;

        public int Subid
        {
            get { return subid; }
            set { subid = value; }
        }

        private string subname;

        public string Subname
        {
            get { return subname; }
            set { subname = value; }
        }

    }
}