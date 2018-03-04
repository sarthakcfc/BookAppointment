using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookAppointment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Models.Business lovelyThreading = new Models.Business()
            {
                Name = "Lovely Threading",
                Location = "554 Washington St, Canton, MA, 02021",
                ServiceProvided = new List<Models.ServiceProvided>()
                {
                    new Models.ServiceProvided()
                    {
                        ID = 1,
                        Name = "Threading",
                        Price = 8,
                        ServiceTime = new TimeSpan(0,10,0),
                        Description = "Eyebrows threading"
                    }
                }
            };

            return View(lovelyThreading);
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