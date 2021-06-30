//using AutoMapper;
//using WorkPlaceOnTour.BACKEND.Services;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using WorkPlaceOnTour.BACKEND.Model;
//using WorkPlaceOnTour.BACKEND.Entities;

//namespace WorkPlaceOnTour.BACKEND.Controllers
//{
//    [Route("api/applicationuserprofiles")]
//    [ApiController]
//    [Authorize]
//    public class ApplicationUserProfilesController : ControllerBase
//    {
        
//        private readonly IWoTRepository woTRepository;
//        private readonly IMapper _mapper;

//        public ApplicationUserProfilesController(
//            IWoTRepository woTRepository, 
//            IMapper mapper)
//        {
          
//            this.woTRepository = woTRepository ??
//                throw new ArgumentNullException(nameof(woTRepository)); ;
//            _mapper = mapper ??
//                throw new ArgumentNullException(nameof(mapper));
//        }

//        [Authorize(Policy = "SubjectMustMatchUser")]
//        [HttpGet("{subject}", Name = "GetApplicationUserProfile")]
//        public IActionResult GetApplicationUserProfile(string subject)
//        {
//            var applicationUserProfileFromRepo = woTRepository
//                .GetApplicationUserProfile(subject);

//            if (applicationUserProfileFromRepo == null)
//            {
//                // subject must come from token
//                var subjectFromToken = User.Claims.FirstOrDefault(c => c.Type == "sub").Value;

//                applicationUserProfileFromRepo = new Entities.ApplicationUserProfile()
//                {
//                    Subject = subject,
//                    SubscriptionLevel = "User"
//                };

//                woTRepository.AddApplicationUserProfile(applicationUserProfileFromRepo);
//                woTRepository.Save();
//            }

//            return Ok(_mapper.Map<Model.ApplicationUserProfile>(applicationUserProfileFromRepo));
//        }

//        [HttpPost()]
//        public IActionResult CreateApplicationUserProfile(
//            [FromBody] ApplicationUserProfileForCreation applicationUserProfileForCreation)
//        {
//            // currently the ApplicationUserProfileForCreation object doesn't have any properties,
//            // as only the subscriptionlevel can be set and that's set to FreeUser for all
//            // new users.  ApplicationUserProfileForCreation is accepted as an example
//            // for when you would create a client-level screen where the user must input
//            // field values before the profile can be created.  
                        
//            var subject = User.Claims.FirstOrDefault(c => c.Type == "sub").Value;

//            if (woTRepository.ApplicationUserProfileExists(subject))
//            {
//                return BadRequest();
//            }

//            var applicationUserProfileEntity = 
//                _mapper.Map<Entities.ApplicationUserProfile>(applicationUserProfileForCreation);

//            // subject must come from the token 
//            applicationUserProfileEntity.Subject = subject;

//            // subscriptionlevel = FreeUser
//            applicationUserProfileEntity.SubscriptionLevel = "User";
             
//            woTRepository.AddApplicationUserProfile(applicationUserProfileEntity);

//            woTRepository.Save();

//            var applicationUserProfileToReturn = _mapper.Map<TourDestination>(applicationUserProfileEntity);

//            return CreatedAtRoute("GetApplicationUserProfile",
//                new { 
//                    id = applicationUserProfileToReturn.TourId
//                },
//                applicationUserProfileToReturn);
//        }
//    }
//}
