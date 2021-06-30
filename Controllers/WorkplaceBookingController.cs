using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkPlaceOnTour.BACKEND.Entities;
using WorkPlaceOnTour.BACKEND.Services;

namespace WorkPlaceOnTour.BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WorkplaceBookingController : ControllerBase
    {
        private readonly IWotBookingRepository wotBookingRepository;
        private readonly IUserInfoService userInfoService;

        public WorkplaceBookingController(IWotBookingRepository wotBookingRepository,
            IUserInfoService userInfoService)
        {
            this.wotBookingRepository = wotBookingRepository;
            this.userInfoService = userInfoService;
        }



        [HttpGet]

        public async Task<IActionResult> GetBookingByUser()
        {
            var userId = new Guid(userInfoService.UserId);

            var userBooking =  await wotBookingRepository.GetBookingByUser(userId);


            return Ok(userBooking);

        }
        [HttpPost]
        public async Task<IActionResult> AddWorkplaceBooking([FromBody] WokrplaceBooking wokrplaceBooking)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            await wotBookingRepository.AddBooking(wokrplaceBooking);


            return Ok();
        }

       
    }
}
