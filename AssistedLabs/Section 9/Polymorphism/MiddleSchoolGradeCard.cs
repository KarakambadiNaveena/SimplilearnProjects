using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyproject
{
    public class MiddleSchoolGradeCard : BasicGradeCard
    {
        private int maths = 0;
        private int english = 0;
        private int secondLanguage = 0;
        private int geography = 0;
        private int history = 0;

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

        public int Geography
        {
            get { return geography; }
            set { geography = value; }
        }

        public int History
        {
            get { return history; }
            set { history = value; }
        }

        public virtual int getTotalMarks()
        {
            this.totalMarks = maths + english + geography + history;
            return totalMarks;
        }
    }
}


