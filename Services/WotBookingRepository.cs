using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaceOnTour.BACKEND.Entities;

namespace WorkPlaceOnTour.BACKEND.Services
{
    public class WotBookingRepository : IWotBookingRepository
    {
        private readonly WotDbContext context;

        public WotBookingRepository(WotDbContext Context)
        {
            this.context = Context;
        }
        public async Task AddBooking(WokrplaceBooking booking)
        {
            await context.WokrplaceBookings.AddAsync(booking);
        }


        public async Task<IEnumerable<WokrplaceBooking>> GetBookingByUser(Guid userId)
        {

            return await context.WokrplaceBookings.Where(wb => wb.UserId.Equals(userId)).ToListAsync();
        }
    }
}
