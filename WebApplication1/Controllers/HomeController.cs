using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        Random gen = new Random(Guid.NewGuid().GetHashCode());
        
        public ActionResult Index()
        {
            var item = new List<MyClassViewModels>();
            var type = "";
            ConnectDatabase db = new ConnectDatabase();
            foreach(var i in db.AccountBook.ToList())
            {

                if (i.Categoryyy == 0) { type = "支出"; } else { type = "收入"; }
                item.Add(new MyClassViewModels
                {
                    ID = i.Id.ToString(),
                    類別 = type,
                    日期 = i.Dateee,
                    金額 =i.Amounttt,
                    備註=i.Remarkkk
                });
            }
            return View(item);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       
           

    }
}