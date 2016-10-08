using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedWay.Models
{
    public class UWUser
    {
        [StringLength(255)]
        public string Name { get; set; }

        public int Id { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Phone_Number { get; set; }

        public DateTime Birthdate { get; set; }


    }
}
