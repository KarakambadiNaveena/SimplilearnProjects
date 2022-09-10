using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistedlabs
{
    public class Linearsearch
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            int[] marks = new int[10] { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };

            Console.WriteLine("Enter marks to search and press Enter:");
            string input = Console.ReadLine();
            int search = Int32.Parse(input);

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] == search)
                {
                    Console.WriteLine(marks[i] + " was found at location " + i);
                    break;
                }
            }
        }
    }
}



    

