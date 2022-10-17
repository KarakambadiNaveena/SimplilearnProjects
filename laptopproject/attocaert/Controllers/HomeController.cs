using attocaert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace attocaert.Controllers
{
    public class HomeController : Controller
    {
        db_ecommerceEntities db = new db_ecommerceEntities();
        public ActionResult Index()
        {
            if (TempData["cart"] != null)
            {
                float x = 0;
                List<cart> li2 = TempData["cart"] as List<cart>;
                foreach (var item in li2)
                {
                    x += item.bill;

                }

                TempData["total"] = x;
            }
            TempData.Keep();
            return View(db.tbl_product.OrderByDescending(x=>x.pro_id).ToList());
        }

        public ActionResult Adtocart(int ?Id)
        {

            tbl_product p = db.tbl_product.Where(x => x.pro_id == Id).SingleOrDefault();
            return View(p);
        }

        List<cart> li = new List<cart>();
        [HttpPost]
        public ActionResult Adtocart(tbl_product pi, string qty,int Id)
        {
            tbl_product p = db.tbl_product.Where(x => x.pro_id == Id).SingleOrDefault();

            cart c = new cart();
            c.productid = p.pro_id;
            c.price = (float)p.pro_price;
            c.qty =Convert.ToInt32(qty);
            c.bill = c.price * c.qty;
            c.productname = p.pro_name;
            if (TempData["cart"] ==null)
            {
                li.Add(c);
                TempData["cart"] = li;
    
            }
            else
            {
                List<cart> li2 = TempData["cart"] as List<cart>;
                li2.Add(c);
                TempData["cart"] = li2;
            }
            
            TempData.Keep();




            return RedirectToAction("Index");
        }

        public ActionResult checkout()
        {
            TempData.Keep();
           

            return View();
        }
    }
}