using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkPlaceOnTour.BACKEND.Entities;
using WorkPlaceOnTour.BACKEND.Services;

namespace WorkPlaceOnTour.BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkplaceController : ControllerBase
    {
        private readonly IWorkplaceRepository workplaceRepository;

        public WorkplaceController(IWorkplaceRepository workplaceRepository)
        {
            this.workplaceRepository = workplaceRepository;
        }

        [HttpGet("{tourId}")]
        public async Task<IActionResult> GetWorkPlaces(Guid tourId)
        {

            if (String.IsNullOrEmpty(tourId.ToString()))
                this.NotFound();


            IEnumerable<Workplace> workplaces = new List<Workplace>();

            workplaces = await workplaceRepository.GetWorkPlacesByTourId(tourId);


            return Ok(workplaces);

        }
    }
}
