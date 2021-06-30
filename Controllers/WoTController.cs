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
    public class WoTController : ControllerBase
    {
        private readonly IWoTRepository wotRepository;
        private readonly IWorkplaceRepository workplaceRepository;
        private readonly IUserInfoService userInfoService;

        public WoTController(IWoTRepository wotRepository,
            IWorkplaceRepository workplaceRepository,
            IUserInfoService userInfoService)
        {
            this.wotRepository = wotRepository;
            this.workplaceRepository = workplaceRepository;
            this.userInfoService = userInfoService;

        }

        [HttpGet]
        public async Task<IActionResult> GetTourDestinations()
        {
            IEnumerable<Entities.TourDestination> toursDestinations = new List<Entities.TourDestination>();

            // if (userInfoService.Role == "user")
            // {
            toursDestinations = await wotRepository.GetAllTourDestinations();
            // }
            // else
            // {
            //   if (!Guid.TryParse(userInfoService.UserId, out Guid userIdAsGuid))
            // {
            //   return Forbid();
            // }


            //   }

            return Ok(toursDestinations);
        }


       

        [HttpPost]
        public async Task<IActionResult> AddTourDestination(TourDestination tourDestination)
        {
            if (tourDestination == null)
                return BadRequest();

            var newtourDestination = new TourDestination();


            await wotRepository.AddTourDestination(newtourDestination);

            return Ok();

        }

        
    }
}
