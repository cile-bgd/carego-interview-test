using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;

namespace CareGo.Web.Models
{
    public class City
    {
        public int CityId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Details { get; set; }

        //public DbGeography Location { get; set; }

        //public virtual IEnumerable<Route> Routes { get; set; }
    }
}