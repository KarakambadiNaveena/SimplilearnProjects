using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistedlabs
{
    internal class Insertionsort
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            string[] students = new string[10];
            students[0] = "Karuna";
            students[1] = "Mark";
            students[2] = "Advaith";
            students[3] = "Sangeeta";
            students[4] = "Nazia";
            students[5] = "Faisal";
            students[6] = "Tania";
            students[7] = "Guru";
            students[8] = "Chandni";
            students[9] = "Kamleshwar";

            int n = 10, i, j, flag;
            string val;
            for (i = 1; i < n; i++)
            {
                val = students[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val.CompareTo(students[j]) < 0)
                    {
                        students[j + 1] = students[j];
                        j--;
                        students[j + 1] = val;
                    }
                    else flag = 1;
                }


            }

            foreach (string s in students)
            {
                Console.WriteLine(s);
            }
        }
    }
}

      
    

