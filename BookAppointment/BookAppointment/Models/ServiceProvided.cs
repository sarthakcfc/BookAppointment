using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookAppointment.Models
{
    public class ServiceProvided
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public TimeSpan ServiceTime { get; set; }
    }
}