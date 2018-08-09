using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VoyagePlanner
{
    public class VoyagePlannerService
    {
        ConnectionClass connection = new ConnectionClass();
        public void CreateVoyagePlanTemplate(int voyagePlanNumber, DateTime dayOfWeekArrival, DateTime dayOfWeekDeparture, string departureTime, string arrivalTime, long locationID)
        {
            VoyagePlanTemplateDetail voyagePlanTemplateDetail = new VoyagePlanTemplateDetail();
            voyagePlanTemplateDetail.DayofWeekArrival = dayOfWeekArrival.DayOfWeek;
            voyagePlanTemplateDetail.DayofWeekDeparture = dayOfWeekDeparture.DayOfWeek;
            voyagePlanTemplateDetail.VoyagePlanNumber = voyagePlanNumber;
            voyagePlanTemplateDetail.DepartureTime = departureTime;
            voyagePlanTemplateDetail.ArrivalTime = arrivalTime;
            voyagePlanTemplateDetail.LocationID = locationID;
            voyagePlanTemplateDetail.CreatedBy = 12;
            voyagePlanTemplateDetail.CreatedOn = DateTime.Now;
            voyagePlanTemplateDetail.ModifiedBy = 12;
            voyagePlanTemplateDetail.ModifiedOn = DateTime.Now;
            connection.EF.VoyagePlanTemplateDetails.Add(voyagePlanTemplateDetail);
            connection.EF.SaveChanges();
        }
        public void GenerateVoyagePlan(DateTime minDate, DateTime maxDate)
        {
          ConnectionClass connection = new ConnectionClass();
            var voyagePlanDays = new List<DateTime>();
            var voyagePlanStarts = connection.EF.VoyagePlanTemplateDetails.Where(x => x.ArrivalTime == null);
            var voyagePlanStartDays = voyagePlanStarts.Select(x => x.DayOfWeek);
            for (DateTime i = minDate; i <= maxDate; i = i.AddDays(1))
            {
                if (voyagePlanStartDays.Contains(i.DayOfWeek)) { voyagePlanDays.Add(i); }
            }

            voyagePlanDays.ForEach(d =>
            {
                var voyagePlanStart = voyagePlanStarts.Where(x => x.DayOfWeek == d.DayOfWeek).ToList();
                voyagePlanStart.ToList().ForEach(ts =>
                {
                    // Edited
                    var startTime = SetTime(d, ts.DepartureTime.ToString()).Value;
                    var dgr = connection.EF.VoyagePlan.Any(x => x.DepartureTime == startTime);

                    var isExist = connection.EF.VoyagePlan.Any(x => x.DepartureTime == startTime);
                    if (!dgr)
                    {
                        var day = d;
                        var voyagePlan = new VoyagePlan();
                        voyagePlan.CreatedBy = 12;
                        voyagePlan.CreatedOn = DateTime.Now;
                        voyagePlan.ModifiedBy = 12;
                        voyagePlan.ModifiedOn = DateTime.Now;
                        voyagePlan.LocationID = ts.LocationID;
                        voyagePlan.DepartureTime = SetTime(d, ts.DepartureTime.ToString()).Value;
                        connection.EF.VoyagePlan.Add(voyagePlan);
                        connection.EF.SaveChanges();
                    }
                });
            });
        }
        private static DateTime? SetTime(DateTime day, string time)
        {
            if (!string.IsNullOrWhiteSpace(time))
            {
                var dateTime = day.SetTime(Int16.Parse(time.Substring(0, 2)), Int16.Parse(time.Substring(3, 2)));

                return dateTime;
            }

            return null;
        }
        public void CreateLocation(int locationCode, string loacationName, string Country, string City, int PostalCode, string CompanyName)
        {
            Location location = new Location();

            location.LocationCode = locationCode;
            location.LocationName = loacationName;
            location.Country = Country;
            location.City = City;
            location.PostalCode = PostalCode;
            location.CompanyName = CompanyName;
            location.ModifiedBy = 12;
            location.ModifiedOn = DateTime.Now;
            location.CreatedBy = 12;
            location.CreatedOn = DateTime.Now;
            connection.EF.Location.Add(location);
            connection.EF.SaveChanges();

            
        }
        public List<Location> GetLocationModel()
        {
            List<Location> location = new List<Location>();

            location = connection.EF.Location.ToList();

            return location;
        }
        public List<VoyagePlan> GetVoyagePlanModel()
        {
            List<VoyagePlan> voyagePlan = new List<VoyagePlan>();

            voyagePlan = connection.EF.VoyagePlan.ToList();

            return voyagePlan;
        }
    }
}
