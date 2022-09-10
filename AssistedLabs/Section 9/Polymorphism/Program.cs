using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyproject
{
    internal class Program
    {
       

            static void Main(string[] args)
            {
                runApp();
            }

            public static void runApp()
            {
                ElementarySchoolGradeCard elementary = new ElementarySchoolGradeCard();
                elementary.Maths = 90;
                elementary.English = 78;
                elementary.SecondLanguage = 80;
                elementary.SocialScience = 67;
                Console.WriteLine("total marks =" +
                                  elementary.getTotalMarks());

                MiddleSchoolGradeCard middle = new MiddleSchoolGradeCard();
                middle.Maths = 90;
                middle.English = 78;
                middle.SecondLanguage = 80;
                middle.Geography = 87;
                middle.History = 76;
                Console.WriteLine("total marks =" + middle.getTotalMarks());

                HighSchoolGradeCard high = new HighSchoolGradeCard();
                high.Maths = 90;
                high.English = 78;
                high.SecondLanguage = 80;
                high.Geography = 87;
                high.History = 76;
                high.Physics = 90;
                high.Chemistry = 76;
                high.Biology = 70;
                Console.WriteLine("total marks =" + high.getTotalMarks());
            }
        }
 }


