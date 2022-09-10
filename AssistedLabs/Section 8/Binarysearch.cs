using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistedlabs
{
    public class Binarysearch
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            int[] marks = new int[10] { 55, 58, 60, 63, 64, 67, 72, 74, 89, 98 };

            Console.WriteLine("Enter marks to search and press Enter:");
            string input = Console.ReadLine();
            int search = Int32.Parse(input);

            int minNum = 0;
            int maxNum = marks.Length - 1;

            int foundElem = -1;

            while (minNum <= maxNum && foundElem == -1)
            {
                int mid = (minNum + maxNum) / 2;
                if (search == marks[mid])
                {
                    foundElem = ++mid;
                    break;
                }
                else if (search < marks[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }

            if (foundElem > -1)
            {
                Console.WriteLine("Found " + search + " at " + foundElem);
            }
        }
    }
}


    

