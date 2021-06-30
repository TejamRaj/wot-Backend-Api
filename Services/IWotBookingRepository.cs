using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorkPlaceOnTour.BACKEND.Entities;

namespace WorkPlaceOnTour.BACKEND.Services
{
    public interface IWotBookingRepository
    {
        Task AddBooking(WokrplaceBooking booking);
        Task<IEnumerable<WokrplaceBooking>> GetBookingByUser(Guid userId);
    }
}