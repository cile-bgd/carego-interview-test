using CareGo.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CareGo.Web.ViewModels
{
    public class CityViewModel
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        [Display(Name = "City")]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Description")]
        public string Details { get; set; }

        public List<string> Destinations { get; set; }

        internal void AddDestinations(List<Route> routes)
        {
            Destinations = new List<string>();
            foreach (var route in routes)
            {
                string destination = route.Destination.Name;
                //this.Destinations.Add(destination);
                Destinations.Add(destination);
            }
        }

        //public static implicit operator CityViewModel(City city)
        //{
        //    var vm = new CityViewModel();
        //    vm.CityId = city.CityId;
        //    vm.Name = city.Name;
        //    vm.Details = city.Details;
        //    vm.Destinations = null;

        //    return vm;
        //}

        //public static implicit operator City(CityViewModel vm)
        //{
        //    var city = new City();
        //    city.CityId = vm.CityId;
        //    city.Name = vm.Name;
        //    city.Details = vm.Details;

        //    return city;
        //}
    }
}