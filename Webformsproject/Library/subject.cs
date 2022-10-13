using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class subject
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection sql = null;
        public subject()
        {
            sql = new SqlConnection("Data Source=LAPTOP-1HSGU7I4\\SQLEXPRESS;Initial Catalog=RainbowSchool;Integrated Security=True");
            ds = new DataSet();
        }
        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from Subject", sql);



            da.Fill(ds, "Subject");
            DataTable dt_empdata = ds.Tables["Subject"];
            return dt_empdata;
        }
        public string Findsubject(int subid)
        {
            DataTable student = Connect();
            DataColumn[] keycolumns = new DataColumn[1];
            keycolumns[0] = student.Columns["subid"];
            student.PrimaryKey = keycolumns;
            DataRow dr = student.Rows.Find(subid);
            string ans = dr[0].ToString() + " " + dr[1].ToString() ;
            return ans;
        }
    }
}
