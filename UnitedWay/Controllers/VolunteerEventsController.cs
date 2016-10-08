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
        private ApplicationDbContext _context;

        public VolunteerEventsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: VolunteerEvents
        public ActionResult Index()
        {
            List<VolunteerEvent> volunteerEvents = _context.VolunteerEvents.ToList();
            return View(volunteerEvents);
        }
    }
}