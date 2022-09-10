using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistedlabs
{
    internal class controlflow
    {
        static void Main(string[] args)
        {
            doApp();
        }
        static void doApp()
        {

            string p = "nani";
            if (p == "nani")
                Console.WriteLine("this is example of if condition");
            int x = 10;
            switch (x)
            {
                case 1:
                    Console.WriteLine("this is case 1");
                    break;
                case 2:
                    Console.WriteLine("this is case 2");
                    break;

            }
            while (x > 5)
            {
                x = +2;

                Console.WriteLine("value is incremented by 2");

                do
                {
                    x = -2;
                    Console.WriteLine("decremented by 2");
                    Console.WriteLine("present value of x is" + x);


                }
                while (x > 5);
                for (int i = 0; i <= x; i++)
                {
                    Console.WriteLine("For loop to assign a value: " + i);
                }

                string[] numbers = { "One", "Two", "Three", "Four", "Five" };
                foreach (string s in numbers)
                {
                    Console.WriteLine("Foreach loop to iterate through an array :" + s);
                }

            }





        }
    }
}
