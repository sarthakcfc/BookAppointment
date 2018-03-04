using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookAppointment.Models
{
    public class Appointment
    {
        public int ID { get; set; }

        [Required]
        public ServiceProvided Service { get; set; }

        [Required]
        public DateTime Time { get; set; }
    }
}