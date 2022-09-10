using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assistedlabs
{
    public class Stackprogram
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            Stack stack = new Stack();

            Console.WriteLine("length of stack=" + stack.getLengthOfStack());
            if (stack.peek() == null)
                Console.WriteLine("Stack contains nothing");
            for (int i = 0; i < 10; i++)
            {
                StackNode n = new StackNode();
                n.Data = i.ToString();
                stack.push(n);
                Console.WriteLine("Length of stack=" + stack.getLengthOfStack());
            }

            StackNode node = stack.pop();
            Console.WriteLine("Popped " + node.Data);

            node = stack.pop();
            Console.WriteLine("Popped " + node.Data);

            Console.WriteLine(stack.listContents());
        }
    }
}


    

