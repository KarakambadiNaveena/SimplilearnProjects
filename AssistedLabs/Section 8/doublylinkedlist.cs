using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Assistedlabs
{
    public class doublylinkedlist
    {
        private dllnode root = null;
        private dllnode current = null;
        private int length;

        public dllnode Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public void add(dllnode node)
        {
            node.Next = null;
            if (root == null)
            {
                root = node;
                length = 1;
                current = root;
                root.Prev = null;
            }
            else
            {
                current.Next = node;
                node.Prev = current;
                current = node;
                length++;
            }
        }

        public dllnode getCurrent()
        {
            return this.current;
        }

        public dllnode getRoot()
        {
            current = root;
            return this.root;
        }

        public dllnode getNext()
        {
            if (current.Next != null)
            {
                current = current.Next;
                return current;
            }
            else
                return null;
        }

        public dllnode getPrev()
        {
            if (current.Prev != null)
            {
                current = current.Prev;
                return current;
            }
            else
                return null;
        }

        public int getLengthOfList()
        {
            return this.length;
        }
    }
}
