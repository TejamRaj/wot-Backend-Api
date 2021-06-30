using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaceOnTour.BACKEND.Entities;

namespace WorkPlaceOnTour.BACKEND.Services
{
    public class WoTRepository:IWoTRepository
    {

        private WotDbContext _context;

        public WoTRepository(WotDbContext context)
        {
            _context = context;
        }

       

        public async Task<IEnumerable<TourDestination>> GetAllTourDestinations()
        {

            return await _context.TourDestinations.ToListAsync();

        }


        public async Task AddTourDestination(TourDestination tourDestination)
        {
            await _context.TourDestinations.AddAsync(tourDestination);
        }

        public async Task<bool> TourDestinationExists(Guid tourId)
        {
            return await _context.TourDestinations.AnyAsync(t => t.TourId == tourId);
        }
    }
}
