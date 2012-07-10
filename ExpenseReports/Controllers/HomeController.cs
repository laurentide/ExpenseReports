using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpenseReports.Models;

namespace ExpenseReports.Controllers
{
    public class HomeController : Controller
    {
        //private Expensereports db = new ExpenseReportEntities();

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to kick-start your ASP.NET MVC application.";

            //return View(db.tblEmployees.ToList());
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
