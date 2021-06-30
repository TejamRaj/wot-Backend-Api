
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaceOnTour.BACKEND.Entities;

namespace WorkPlaceOnTour.BACKEND.Services
{
    public static class WotDbContextExtentions
    {

        public static void EnsureSeedDataForContext(this WotDbContext context)
        {

            // first, clear the database.  This ensures we can always start 
            // fresh with each demo.  Not advised for production environments, obviously :-)


           context.TourDestinations.RemoveRange(context.TourDestinations);
           // context.Workplaces.RemoveRange(context.Workplaces);
            context.WokrplaceBookings.RemoveRange(context.WokrplaceBookings);
        

            context.SaveChanges();


            var tourDestinations = WotInMemoryData.GetTourDestinations();

            var workplaces = WotInMemoryData.GetWorkplaces();

            var activities = WotInMemoryData.GetActivities();

            var amenties = WotInMemoryData.GetAvailableAmenties();

            var famousSpots = WotInMemoryData.GetFamousSpots();

           context.AddRange(tourDestinations);
           context.AddRange(workplaces);
            //context.AddRange(activities);
            //context.AddRange(amenties);
            //context.AddRange(famousSpots);


            context.SaveChanges();



        }

        
    }
}
