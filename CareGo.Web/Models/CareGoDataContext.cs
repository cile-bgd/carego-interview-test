using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CareGo.Web.Models
{
    public class CareGoDataContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Route> Routes { get; set; }

        public IEnumerable<City> GetCities()
        {
            return Cities;
        }

        public City GetCityDetails(int id)
        {
            return Cities.FirstOrDefault(a => a.CityId == id);
            //return Cities.Find(id);
        }

        public int GetId(string name)
        {
            var city = Cities.FirstOrDefault(a => a.Name.ToUpper() == name.ToUpper());
            return city.CityId;
        }

        public void Add(City city)
        {
            Cities.Add(city);
        }

        public City Update(City city)
        {
            var updatedCity = GetCityDetails(city.CityId);
            updatedCity.Name = city.Name;
            updatedCity.Details = city.Details;
            //updatedCity.Location = city.Location;

            return updatedCity;
        }

        public void Delete(City city)
        {
            Cities.Remove(city);
        }

        public IEnumerable<Route> GetRoutes(City city)
        {
            return Routes.Where(a => a.DepartureId == city.CityId);
        }

        public IEnumerable<Route> GetAllRoutes()
        {
            return Routes;
        }

        public void Add(Route route)
        {
            Routes.Add(route);
        }

        public Route AddRoute(City Departure, City Destination)
        {
            var route = new Route();
            route.DepartureId = Departure.CityId;
            route.DestinationId = Destination.CityId;

            return route;
        }

        public void AddRoutesById(int departureId, int destinationId)
        {
            var route = new Route();
            route.DepartureId = departureId;
            route.DestinationId = destinationId;

            //return route;

            Routes.Add(route);
        }
    }
}