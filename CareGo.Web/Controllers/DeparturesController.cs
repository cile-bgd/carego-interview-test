using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CareGo.Web.Models;
using CareGo.Web.ViewModels;

namespace CareGo.Web.Controllers
{
    public class DeparturesController : Controller
    {
        private CareGoDataContext db = new CareGoDataContext();

        // GET: Departures
        public ActionResult Index()
        {
            var cities = db.GetCities().ToList();
            var cityVM = new CityViewModel();
            var citiesVM = new List<CityViewModel>();

            foreach (var city in cities)
            {
                cityVM = MapDmToVm(city);
                citiesVM.Add(cityVM);
            }

            return View(citiesVM);
        }

        // GET: Departures/Destinations/5
        public ActionResult Destinations(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var city = db.GetCityDetails(id.Value);

            var routes = db.GetRoutes(city).ToList();

            var cityViewModel = MapDmToVm(city);
            if (cityViewModel == null)
            {
                return HttpNotFound();
            }

            cityViewModel.AddDestinations(routes);

            return View(cityViewModel);
        }

        // GET: Departures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            var city = db.GetCityDetails(id.Value);

            var cityViewModel = MapDmToVm(city);
            if (cityViewModel == null)
            {
                return HttpNotFound();
            }
            return View(cityViewModel);
        }

        // GET: Departures/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CityId,Name,Details")] CityViewModel cityViewModel)
        {
            if (ModelState.IsValid)
            {
                var city = MapVmToDm(cityViewModel);
                db.Add(city);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cityViewModel);
        }

        // GET: Departures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var city = db.GetCityDetails(id.Value);
            var cityViewModel = MapDmToVm(city);
            if (cityViewModel == null)
            {
                return HttpNotFound();
            }
            return View(cityViewModel);
        }

        // POST: Departures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CityId,Name,Details")] CityViewModel cityViewModel)
        {
            if (ModelState.IsValid)
            {
                var city = new City();
                city = MapVmToDm(cityViewModel);
                db.Update(city);
                //db.Entry(city).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cityViewModel);
        }

        // GET: Departures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var city = db.GetCityDetails(id.Value);
            var cityViewModel = MapDmToVm(city);

            if (cityViewModel == null)
            {
                return HttpNotFound();
            }
            return View(cityViewModel);
        }

        // POST: Departures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var city = db.GetCityDetails(id);
            db.Delete(city);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private static CityViewModel MapDmToVm(City city)
        {
            var vm = new CityViewModel();
            vm.CityId = city.CityId;
            vm.Name = city.Name;
            vm.Details = city.Details;
            vm.Destinations = null;

            return vm;
        }

        private static City MapVmToDm(CityViewModel vm)
        {
            var city = new City();
            city.CityId = vm.CityId;
            city.Name = vm.Name;
            city.Details = vm.Details;

            return city;
        }
    }
}
