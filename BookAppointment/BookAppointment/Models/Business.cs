using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookAppointment.Models
{
    public class Business
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public List<ServiceProvided> ServiceProvided { get; set; }

        [Required]
        public string Location { get; set; }
    }
}