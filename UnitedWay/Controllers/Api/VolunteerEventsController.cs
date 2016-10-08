using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnitedWay.Models;

namespace UnitedWay.Controllers.Api
{
    public class VolunteerEventsController : ApiController
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

        //GET api/volunteerevents
        public IHttpActionResult GetVolunteerEvents()
        {
            return Ok(_context.VolunteerEvents.ToList());
        }
        //GET api/volunteerevents/#
        public IHttpActionResult GetVolunteerEvents(int id)
        {
            var volunteerEvent = _context.VolunteerEvents.SingleOrDefault(v => v.Id == id);
            if (volunteerEvent == null)
            {
                return NotFound();
            }
            return Ok(volunteerEvent);
        }

        [HttpPut]
        public IHttpActionResult PutVolunteerEvent(int id, VolunteerEvent volunteerEvent)
        {
            var volunteerEventInDb = _context.VolunteerEvents.SingleOrDefault(v => v.Id == id);

            if (volunteerEventInDb == null)
            {
                return NotFound();
            }

                if (volunteerEventInDb.Id != id)
            {
                return BadRequest("The id's did not match.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Your incoming event was in the wrong format.");
            }

            //If you got this far, everything was fine!
            volunteerEventInDb.Name = volunteerEvent.Name;
            volunteerEventInDb.City = volunteerEvent.City;
            volunteerEventInDb.State = volunteerEvent.State;
            return Ok();
        }
    }
}
