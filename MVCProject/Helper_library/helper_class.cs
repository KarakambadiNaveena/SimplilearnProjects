using BLL_library;
using DAL_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper_library
{
    public class helper_class
    {
        DAL_class dal = null;
        public helper_class()
        {
            dal = new DAL_class();
        }
        public List <BLL_class> ShowStudentList()
        {
            return dal.StudentList();
        }
        public bool AddStudent(BLL_class student)
        {
            return dal.InsertStudent(student);

        }
        public bool EditStudent(BLL_class studid)
        {
            return dal.UpdateStudent(studid);
        }
        public BLL_class SearchStudent(int studid)
        {
            return dal.FindStudent(studid);
        }

        public void SearchStudent(int studid, out BLL_class empdata)
        {

            dal.FindStudent(studid, out empdata);


        }
        public bool RemoveStudent(int studid)
        {
            return dal.DeleteStudent(studid);
        }
        public List<BLL_class> ShowClassList()
        {
            return dal.ClassList();
        }
        public List<BLL_class> ShowSubjectList()
        {
            return dal.SubjectList();
        }
    }
}
