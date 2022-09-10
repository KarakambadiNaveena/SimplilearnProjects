using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistedlabs
{
    public class Bubblesort
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

            bool flag = true;
            string temp;
            int numLength = students.Length;
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (students[j + 1].CompareTo(students[j]) < 0)
                    {
                        temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                        flag = true;
                    }
                }
            }


            foreach (string s in students)
            {
                Console.WriteLine(s);
            }
        }
    }
}


    

