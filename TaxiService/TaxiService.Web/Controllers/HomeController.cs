using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaxiService.Entities.Models;
using TaxiService.MSSQLRepository.UnitOfWork;

namespace TaxiService.Web.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork uof = new UnitOfWork(new MSSQLRepository.DatabaseContext());

        Customer customer = new Customer()
        {
            Username = "Pera"
        };

        public ActionResult Index()
        {
            uof.UserRepository.Add(customer);

            return View();
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