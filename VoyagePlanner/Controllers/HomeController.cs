using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VoyagePlanner;

namespace VoyagePlanner.Controllers
{
    public class HomeController : Controller
    {
        ConnectionClass connection = new ConnectionClass();
        VoyagePlannerService services = new VoyagePlannerService();

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View(connection.EF.Location);
        }
        [HttpPost]
        [Route("/GenerateVoyagePlan")]
        public IActionResult Index(DateTime start, DateTime end)
        {
            services.GenerateVoyagePlan(start, end);
            return RedirectToAction("VoyagePlans");
        }
        [HttpGet]
        [Route("/VoyagePlans")]
        public IActionResult VoyagePlans()
        {
            ViewData["Location"] = services.GetLocationModel();
            ViewData["VoyagePlan"] = services.GetVoyagePlanModel();

            return View();
        }
        [HttpGet]
        [Route("/ListLocation")]
        public IActionResult ListLocation()
        {
            return PartialView(connection.EF.Location);
        }
        [HttpGet]
        [Route("/ListLocation/{id?}")]
        public IActionResult ListLocation(int ID)
        {
            var locationQuery = connection.EF.Location.Where(x => x.ID == ID).ToList();

            return PartialView(locationQuery);
        }
        [HttpPost]
        [Route("/CreateVoyagePlanTemplate")]
        public IActionResult CreateVoyagePlanTemplate(int voyagePlanNumber, DateTime dayOfWeekArrival, DateTime dayOfWeekDeparture, string departureTime, string arrivalTime, long locationID)
        {
            services.CreateVoyagePlanTemplate(voyagePlanNumber, dayOfWeekArrival, dayOfWeekDeparture, departureTime, arrivalTime, locationID);

            return View(connection.EF.Location);
        }
        [HttpGet]
        [Route("/CreateLocation")]
        public IActionResult CreateLocation()
        {
            return View();
        }
        [HttpGet]
        [Route("/CreateVoyagePlanTemplate")]
        public IActionResult CreateVoyagePlanTemplate()
        {
            return View(connection.EF.Location);
        }
        [HttpPost]
        [Route("/CreateLocation")]
        public IActionResult CreateLocation(string locationName, int locationCode, string country, string city, int postalCode, string companyName)
        {
            services.CreateLocation(locationCode, locationName, country, city, postalCode, companyName);

            return RedirectToAction("ListLocation");
        }
    }
}
