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
        // GET: Donations
        public ActionResult Index()
        {
            Donation donation = new Donation()
                                {
                                    UserId = System.Web.HttpContext.Current.User.Identity.GetUserId()
                                };
            return View(donation);
        }

        public ActionResult Save(Donation donation)
        {
            return View("Index", donation);
        }
    }
}