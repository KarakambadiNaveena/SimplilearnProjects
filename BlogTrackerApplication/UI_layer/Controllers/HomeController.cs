using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using UI_layer.Models;
namespace UI_layer.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            List<blogmodel> emplist = new List<blogmodel>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44378//api/");

                var responseTask = client.GetAsync("blog");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readData = result.Content.ReadAsAsync<blogmodel[]>();
                    readData.Wait();
                    var empdata = readData.Result;
                    foreach (var item in empdata)
                    {
                        emplist.Add(new blogmodel
                        {
                            BlogId = item.BlogId,
                            Title = item.Title,
                            Subject = item.Subject,
                            DateOfCreation = item.DateOfCreation,
                            BlogUrl = item.BlogUrl,
                            EmpEmailId = item.EmpEmailId
                        });

                    }
                }
            }
            return View(emplist);

        }
       
    }
}