using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritanceproject
{
    
        
            public class iSubjectTeacher : iTeacher
            {
                private string whichSubject;

                public string WhichSubject
                {
                    get { return whichSubject; }
                    set { whichSubject = value; }
                }
            }
        }




