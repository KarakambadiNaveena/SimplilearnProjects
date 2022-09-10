using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistedlabs
{
    internal class file
    {
      
            static void Main(string[] args)
            {
                doApp();
            }

            public static void doApp()
            {
                string dir = Directory.GetCurrentDirectory();
                string filename = dir + "data.txt";

               if (File.Exists(filename))
                    Console.WriteLine(filename + " exists");
                else
                    Console.WriteLine(filename + " does not exist");

                using (StreamWriter wrt = File.CreateText(filename))
                {
                    wrt.WriteLine("This is line one");
                    wrt.WriteLine("This is line two");
                    wrt.WriteLine("This is line three");
                    wrt.WriteLine("This is line four");
                }
                Console.WriteLine(filename + " created");

                string[] lines = File.ReadAllLines(filename);
                foreach (string s in lines)
                {
                    Console.WriteLine(s);
                }

                string text = File.ReadAllText(filename);
                Console.WriteLine(text);

                File.Delete(filename);
                Console.WriteLine(filename + " was deleted");
            }
        }
    }



    

