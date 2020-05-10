using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_6_Model_Kavrami.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int sayi = 45;
            return View(sayi);
        }

        public ActionResult Index2()
        {
            string ad = "Negan";
            return View(model:ad);
        }

        public ActionResult KisiGoster()
        {
            Insan insan = new Insan();
            insan.ad = "Negan";
            insan.soyad = "Lucille";
            insan.yas = 52;
            return View(insan);
        }
    }
}