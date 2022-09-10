using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistedlabs
{
    public class StackNode
    {
        private string data;
        private StackNode next = null;
        private StackNode prev = null;

        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public StackNode Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public StackNode Prev
        {
            get { return this.prev; }
            set { this.prev = value; }
        }
    }
}

