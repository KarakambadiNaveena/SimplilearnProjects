using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanceproject
{

    public class iClassTeacher : iTeacher
    {
        private hclass whichClass;

        public hclass WhichClass
        {
            get { return whichClass; }
            set { whichClass = value; }
        }
    }
}


