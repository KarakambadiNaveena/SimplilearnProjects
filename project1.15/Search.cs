using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.Remoting.Contexts;

namespace PP1._6
{
    internal class Search
    {
        static void Main(string[] args)
        {
            string myfile = @"D:\C#\Projects\search.txt";
            bool found = false;

            List<string> lines = new List<string>(File.ReadAllLines(myfile));
            Console.WriteLine("Sorting my name");
            lines.Sort();
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            FileStream inFile = new FileStream(@"D:\C#\Projects\search.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string record;
            string input;
            Console.Write("Enter Name >> ");
            input = Console.ReadLine();
            



            record = reader.ReadLine();
            try
            {

                record = reader.ReadLine();
                while (record != null)
                {

                    if (record.Contains(input))
                    {
                        Console.WriteLine(record);
                        found = true;

                    }


                    record = reader.ReadLine();

                }
                if(!found)
                {
                    Console.WriteLine("Student does not exists");
                }

            }
            finally
            {

                inFile.Close();
            }
            Console.ReadLine();
        }
    }
}
