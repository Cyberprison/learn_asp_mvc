using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using learn_asp_mvc.Models;

namespace learn_asp_mvc.Controllers
{
    public class HomeController : Controller
    {
        PhoneContext phoneContext = new PhoneContext();

        public ActionResult Index()
        {
            //извлекаем данные из таблицы Phones
            IEnumerable<Phone> phones = phoneContext.Phones;

            //записываем phones в динамическое свойство ViewBag
            ViewBag.Phones = phones;

            return View();

        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;

            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.DateTime = DateTime.Now;

            phoneContext.Purchases.Add(purchase);

            phoneContext.SaveChanges();

            return $"Уважаемый {purchase.FIO}, с вами скоро свяжутся!";
        }
    }
}