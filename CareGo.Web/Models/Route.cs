using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CareGo.Web.Models
{
    public class Route
    {
        public int RouteId { get; set; }

        [Required]
        [ForeignKey("Departure")]
        public int DepartureId { get; set; }
        public virtual City Departure { get; set; }

        [Required]
        [ForeignKey("Destination")]
        public int DestinationId { get; set; }
        public virtual City Destination { get; set; }
    }
}