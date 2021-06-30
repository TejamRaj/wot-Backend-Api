using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorkPlaceOnTour.BACKEND.Entities;

namespace WorkPlaceOnTour.BACKEND.Services
{
    public interface IWorkplaceRepository
    {
        Task AddWorkplace(Workplace workplace);
        Task<IEnumerable<Workplace>> GetWorkPlacesByTourId(Guid tourId);
    }
}