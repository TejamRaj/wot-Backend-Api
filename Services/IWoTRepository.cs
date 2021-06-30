using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaceOnTour.BACKEND.Entities;

namespace WorkPlaceOnTour.BACKEND.Services
{
    public interface IWoTRepository
    {
        Task AddTourDestination(TourDestination tourDestination);

        Task<IEnumerable<TourDestination>> GetAllTourDestinations( );


        //   Task GetTourByUserId(int userid);


         Task<bool> TourDestinationExists(Guid TourId);

    }
}
