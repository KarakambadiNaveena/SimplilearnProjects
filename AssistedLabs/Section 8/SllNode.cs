using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistedlabs
{
    public class SllNode
    {
        private string data;
        private SllNode next = null;
        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public SllNode Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}

    

