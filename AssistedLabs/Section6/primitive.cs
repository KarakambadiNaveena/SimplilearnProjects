using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistedlabs
{
    internal class primitive
    {
        
            public static void Main(string[] args)
            {
                doApp();
            }

            static public void doApp()
            {

                bool xbool = true;
                byte xbyte = 250;
                sbyte xsbyte = -100;
                char xchar = 'a';
                decimal xdecimal = 87.9M;
                double xdouble = 651.09;
                float xfloat = 465.1f;
                int xint = -8909;
                uint xuint = 91881;
                long xlong = -1313131312;
                ulong xulong = 01919181;
                object xobject = new object();
                short xshort = -19;
                ushort xushort = 19;
                string xstring = "name";

                if (xchar== 'a' && xbyte < 300)
                    Console.WriteLine("This expression is true");
                if (xshort > 6 || xint > -9000)
                    Console.WriteLine("This expression is false");
               Console.ReadLine();
            }
    }
}


    

