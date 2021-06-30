using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkPlaceOnTour.BACKEND.Entities
{
    public class TourDestination: AuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TourId { get; set; }

        [Required]
        [MaxLength(400)]
        public string Name { get; set; }


        [MaxLength(2000)]
        public string Details { get; set; }


        [Required]
        public ICollection<Workplace> WorkPlaces { get; set; } = new List<Workplace>();


        public String PopularityRating { get; set; }

        public string CoverPhotoUrl { get; set; }


    }
}
