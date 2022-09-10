using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistedlabs
{
    internal class text
    {
        static void Main(string[] args)
        {
            string mary = "this is nani.";
            Console.WriteLine("Original string=" + mary);
            Console.WriteLine("Clone of a string =" + mary.Clone());
            Console.WriteLine("Compare two strings =" + mary.CompareTo("this is nav---"));
            Console.WriteLine("Characters in a string =" + mary.Contains("r"));
            Console.WriteLine("String ending with =" + mary.EndsWith("lamb."));
            Console.WriteLine("All lowercase =" + mary.ToLower());
            Console.WriteLine("All uppercase =" + mary.ToUpper());
            Console.WriteLine("Insert string within a string =" + mary.Insert(4, " and Jack "));
            Console.WriteLine("Splitting string into words:");
           

            string[] parts = mary.Split( 'h');

            foreach (string p in parts)
            {
                Console.WriteLine($"Substring: {p}");
            }

            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString() + " ");
            }
            Console.WriteLine(sb.ToString());

        }
    }
}


        
    

