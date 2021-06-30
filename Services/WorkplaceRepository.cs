using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaceOnTour.BACKEND.Entities;

namespace WorkPlaceOnTour.BACKEND.Services
{
    public class WorkplaceRepository : IWorkplaceRepository
    {
        private readonly WotDbContext context;

        public WorkplaceRepository(WotDbContext context)
        {
            this.context = context;
        }


        public async Task<IEnumerable<Workplace>> GetWorkPlacesByTourId(Guid tourId)
        {
             var workplaces= await context.Workplaces.Where(t => t.TourId.Equals(tourId))
                                           .ToListAsync();
            return workplaces;
            //foreach (var workplace in workplaces)
            //{
            //    var newWorkplace = new Workplace();
            //    newWorkplace.WorkplaceId = workplace.WorkplaceId;
            //    newWorkplace.Address = workplace.Address;
            //    newWorkplace.WorkplacePhotoUrl = workplace.WorkplacePhotoUrl;
            //    newWorkplace.TourId = workplace.TourId;
            //    newWorkplace.activities = WotInMemoryData.GetActivities().Where(a => a.WorkplaceId == workplace.WorkplaceId).ToList();
            //    newWorkplace.Amenties = WotInMemoryData.GetAvailableAmenties().Where(a => a.WorkplaceId == workplace.WorkplaceId).ToList();
            //    newWorkplace.FamousSpots = WotInMemoryData.GetFamousSpots().Where(a => a.WorkplaceId == workplace.WorkplaceId).ToList();
            //}

            //return workplaces;
             
        }

        public async Task AddWorkplace(Workplace workplace)
        {
            await context.Workplaces.AddAsync(workplace);
        }
    }
}
