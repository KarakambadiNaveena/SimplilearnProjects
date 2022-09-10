using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistedlabs
{
    internal class Recursion
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            string[] students = new string[5];
            students[0] = "Kavya";
            students[1] = "Mouni";
            students[2] = "Anitha";
            students[3] = "sweety";
            students[4] = "Nani";
            
            int currElem = 0;
            printViaRecursion(students, currElem);
        }

        public static void printViaRecursion(string[] arr, int currElem)
        {
            Console.WriteLine(arr[currElem]);
            if (currElem < arr.Length - 1)
                printViaRecursion(arr, currElem + 1);
        }
    }
}


    

