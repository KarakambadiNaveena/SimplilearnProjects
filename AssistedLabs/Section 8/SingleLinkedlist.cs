using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistedlabs
{
    public class SingleLinkedlist
    {
        private SllNode root = null;
        private SllNode current = null;
        private int length;

        public SllNode Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public void add(SllNode node)
        {
            node.Next = null;
            if (root == null)
            {
                root = node;
                length = 1;
                current = root;
            }
            else
            {
                current.Next = node;
                current = node;
                length++;
            }
        }

        public SllNode getCurrent()
        {
            return this.current;
        }

        public SllNode getRoot()
        {
            current = root;
            return this.root;
        }

        public SllNode getNext()
        {
            if (current.Next != null)
            {
                current = current.Next;
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

    

