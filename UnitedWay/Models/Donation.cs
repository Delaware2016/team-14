using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedWay.Models
{
    public class Donation
    {
        [Required]
        public double Amount { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
    }
}
