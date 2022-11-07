using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_lib
{
    
        public class AdminInfo
        {
            [Required()]
            [EmailAddress]
        [Key]
            public string EmailId { get; set; }
            [Required()]
            public string Password { get; set; }

        }
        /// <summary>
        /// ///////////
        /// </summary>
        public class EmpInfo
        {
            [Required()]
            [EmailAddress]
        [Key]
        public string EmailId { get; set; }
            [Required()]
            [MaxLength(50, ErrorMessage = "Maximum 50 Characters only")]
            public string Name { get; set; }
            [Required()]
            public DateTime DateOfJoining { get; set; }
            [Required()]
            public int PassCode { get; set; }

        }
        /// <summary>
        /// ////////
        /// </summary>
        public class BlogInfo
        {
            [Required()]
        [Key]
        public int BlogId { get; set; }
            [Required()]

            [MaxLength(20, ErrorMessage = "Maximum 50 Characters only")]
            public string Title { get; set; }
            [Required()]
            [MaxLength(50, ErrorMessage = "Maximum 50 Characters only")]
            public string Subject { get; set; }
            [Required()]

            public DateTime DateOfCreation { get; set; }
            [Required()]

            public string BlogUrl { get; set; }
            [Required()]
           
            public string EmpEmailId { get; set; }
        }
        /// <summary>
        /// /////////
        /// </summary>
        public class MyContext : DbContext
        {
            public MyContext() : base("MyContext")
            {
                Database.SetInitializer(new Init());
                //  Database.SetInitializer<MyContext>(new DropCreateDatabaseIfModelChanges<MyContext>());
            }
            public virtual DbSet<AdminInfo> AdminInfos { get; set; }
            public virtual DbSet<EmpInfo> EmpInfos { get; set; }
            public virtual DbSet<BlogInfo> BlogInfos { get; set; }
        }
        /// <summary>
        /// /////////
        /// </summary>
        public class Init : DropCreateDatabaseIfModelChanges<MyContext>
        {
            protected override void Seed(MyContext context)
            {
                List<AdminInfo> adminlist = new List<AdminInfo>();
                adminlist.Add(new AdminInfo() { EmailId = "naveena@gmail.com", Password = "naveena123" });
                context.AdminInfos.AddRange(adminlist);
                context.SaveChanges();
                base.Seed(context);
            }
        }
        /// <summary>
        /// ////////////////////
        /// </summary>
        public class operation
        {

            MyContext context = null;

            public operation()
            {
                context = new MyContext();
            }
            public List<EmpInfo> GetAllEmp()
            {
                var ans = context.EmpInfos.ToList();
                return ans;
            }
            public void AddEmp(EmpInfo emp)
            {
                context.EmpInfos.Add(emp);
                context.SaveChanges();
            }
        public EmpInfo Getempbyid(int id)
        {
            List<EmpInfo> s = context.EmpInfos.ToList();
            EmpInfo r = s.Find(pr => pr.PassCode == id);
            return r;
        }
        public bool DeleteEmployeeDetails(int id)
        {
            try
            {

                List<EmpInfo> s = context.EmpInfos.ToList();
                EmpInfo r = s.Find(pr => pr.PassCode == id);

                context.EmpInfos.Remove(r);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateEmployeeDetails(int id, EmpInfo p)
        {
            try
            {

                List<EmpInfo> s = context.EmpInfos.ToList();
                EmpInfo k = s.Find(pr => pr.PassCode == id);
                k.PassCode = p.PassCode;
                k.EmailId = p.EmailId;
                k.Name = p.Name;
                k.DateOfJoining = p.DateOfJoining;
               
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;


            }
        }
        /// <summary>
        /// ///////////////////
        /// </summary>
        /// <returns></returns>
        public List<BlogInfo> GetAllblog()
            {
                return context.BlogInfos.ToList();
            }
            public void Addblog(BlogInfo m)
            {
                context.BlogInfos.Add(m);
                context.SaveChanges();
            }
        public BlogInfo Getblogbyid(int id)
        {
            List<BlogInfo> s = context.BlogInfos.ToList();
            BlogInfo r = s.Find(pr => pr.BlogId == id);
            return r;
        }
        public bool UpdateBlogDetails(int id, BlogInfo p)
        {
            try
            {

                List<BlogInfo> s = context.BlogInfos.ToList();
                BlogInfo k = s.Find(pr => pr.BlogId == id);

                k.BlogId = p.BlogId;
                k.Title = p.Title;
                k.Subject = p.Subject;
                k.DateOfCreation = p.DateOfCreation;
                k.BlogUrl = p.BlogUrl;
                k.EmpEmailId = p.EmpEmailId;
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;


            }
        }
        public bool DeleteBlogDetails(int id)
        {
            try
            {

                List<BlogInfo> s = context.BlogInfos.ToList();
                BlogInfo r = s.Find(pr => pr.BlogId == id);

                context.BlogInfos.Remove(r);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
    }





