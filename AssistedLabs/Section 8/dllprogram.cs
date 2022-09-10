using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assistedlabs
{
    public class dllprogram
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            doublylinkedlist list = new doublylinkedlist();
            dllnode n = new dllnode();
            n.Data = "root";
            list.add(n);
            for (int i = 0; i < 10; i++)
            {
                dllnode node = new dllnode();
                node.Data = Convert.ToString(i);
                list.add(node);
            }

            Console.WriteLine("length of doubly linked list=" + list.getLengthOfList());
            Console.WriteLine("Traversing forward..");
            n = list.getRoot();
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = list.getNext();
            }


            Console.WriteLine("Traversing backwards..");
            n = list.getPrev();
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = list.getPrev();
            }

        }
    }
}


    

