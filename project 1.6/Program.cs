using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PP1._6
{
    internal class Program
    {
      
            static void Main(string[] args)
            {
                string myfile = @"D:\C#\Projects\studentdata.txt";
                if (File.Exists(myfile))
                {
                    string r = File.ReadAllText(myfile);
                    Console.WriteLine(r);
                    Console.ReadLine();

                }
            }
        }
    }


    

