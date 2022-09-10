using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assistedlabs
{
    public class dllnode
    {
        private string data;
        private dllnode next = null;
        private dllnode prev = null;

        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public dllnode Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public dllnode Prev
        {
            get { return this.prev; }
            set { this.prev = value; }
        }
    }
}

    

