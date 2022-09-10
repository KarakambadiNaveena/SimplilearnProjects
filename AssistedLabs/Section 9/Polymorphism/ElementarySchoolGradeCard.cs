using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyproject
{
    public class ElementarySchoolGradeCard : BasicGradeCard
    {
        private int maths = 0;
        private int english = 0;
        private int secondLanguage = 0;
        private int socialScience = 0;

        public int Maths
        {
            get { return maths; }
            set { maths = value; }
        }

        public int English
        {
            get { return english; }
            set { english = value; }
        }

        public int SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }

        public int SocialScience
        {
            get { return socialScience; }
            set { socialScience = value; }
        }

        public virtual int getTotalMarks()
        {
            this.totalMarks = maths + english + socialScience + secondLanguage;
            return totalMarks;
        }
    }
}

