using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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












        public ActionResult Manage()
        {

            return View();
        }

        public ActionResult RideHistory()
        {
            return View();
        }


    }
}