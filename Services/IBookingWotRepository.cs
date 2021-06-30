using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkPlaceOnTour.BACKEND.Services
{
   public interface IBookingWotRepository
    {

        Task AddTourWorkplaceBooking();

        Task GetBookingsByUserId(int userId);
    }
}
