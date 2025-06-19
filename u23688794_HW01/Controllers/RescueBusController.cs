using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23688794_HW01.Models;

namespace u23688794_HW01.Controllers
{
    public class RescueBusController : Controller
    {
        // GET: RescueBus
        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult SelectService()
        {
            return View();
        }

        public ActionResult EmergencyBooking()
        {
            return RedirectToAction("BookingConfirmed");
        }


        public ActionResult BookingPage(string service)
        {
            ViewBag.ServiceType = service;
            return View();
        }





        public ActionResult Manage()
        {

            return View(RescueBusModel.GetSampleData());
        }

        [HttpPost]

        public ActionResult Manage(RescueBusModel model)
        {
            var filteredDrivers = model.SearchDrivers();

            return View(filteredDrivers);
        }



        public ActionResult RideHistory()
        {
            return View();
        }


    }
}