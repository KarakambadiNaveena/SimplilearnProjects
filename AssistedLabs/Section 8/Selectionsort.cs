using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistedlabs
{
    internal class Selectionsort
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            string[] students = new string[10];
            students[0] = "Kavya";
            students[1] = "Mouni";
            students[2] = "Anitha";
            students[3] = "sweety";
            students[4] = "Nani";
            students[5] = "Fanta";
            students[6] = "Tanu";
            students[7] = "Giri";
            students[8] = "Chandu";
            students[9] = "Kamleshwari";

            int n = 10;
            string temp;
            int smallest;

            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (students[j].CompareTo(students[smallest]) < 0)
                    {
                        smallest = j;
                    }
                }
                temp = students[smallest];
                students[smallest] = students[i];
                students[i] = temp;
            }

            foreach (string s in students)
            {
                Console.WriteLine(s);
            }
        }
    }
}


    

