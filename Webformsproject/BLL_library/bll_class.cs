using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_library
{
    public class bll_class
    {
        private int _studid;

        public int StudentID
        {
            get { return _studid; }
            set { _studid = value; }
        }

        private string _studname;

        public string StudName
        {

            get { return _studname; }
            set { _studname = value; }
        }
        private int _studclass;

        public int StudentClass
        {
            get { return _studclass; }
            set { _studclass = value; }
        }
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
