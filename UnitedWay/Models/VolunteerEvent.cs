using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace UnitedWay.Models
{
    [Authorize]
    public class VolunteerEvent
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public int Id { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }
    }
}
