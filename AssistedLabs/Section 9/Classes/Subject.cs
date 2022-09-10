using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oopsproject
{
    
        public class Subject
        {
            private string name;
            private string shortName;

            public string Name
            {
                get { return name; }
                set { this.name = value; }
            }

            public string ShortName
            {
                get { return shortName; }
                set { shortName = value; }
            }
        }
    }

