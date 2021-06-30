using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkPlaceOnTour.BACKEND.Entities
{
    public class WokrplaceBooking: AuditableEntity
    {

        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int TourWorkplacesId { get; set; }

        public ICollection<TourDestination> TourDestinations { get; set; }

        
        public Guid WorkplaceId { get; set; }

        public Workplace workplace { get; set; }

        [Required]
         public DateTimeOffset StartDate { get; set; }

        [Required]
        public DateTimeOffset EndDate { get; set; }


        public int BillAmount { get; set; }
    }
}
