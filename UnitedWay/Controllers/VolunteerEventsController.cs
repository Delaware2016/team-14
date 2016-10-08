using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitedWay.Models;

namespace UnitedWay.Controllers
{
    public class VolunteerEventsController : Controller
    {
        // GET: VolunteerEvents
        public ActionResult Index()
        {
            List<VolunteerEvent> volunteerEvents;
            return View();
        }
    }
}