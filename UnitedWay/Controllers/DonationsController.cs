using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using UnitedWay.Models;

namespace UnitedWay.Controllers
{
    public class DonationsController : Controller
    {
        ApplicationDbContext _context;

        public DonationsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Donations
        public ActionResult Index()
        {
            Donation donation = new Donation()
                                {
                                    UserId = System.Web.HttpContext.Current.User.Identity.GetUserId()
                                };
            return View(donation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Donation donation)
        {
            if(!ModelState.IsValid)
                return View("Index", donation);
            _context.Donations.Add(donation);
            _context.SaveChanges();
            return View("Confirmation");
        }

        public ActionResult Confirmation()
        {
            return View();
        }
    }
}