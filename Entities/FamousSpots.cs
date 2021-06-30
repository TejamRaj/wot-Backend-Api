using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkPlaceOnTour.BACKEND.Entities
{
    public class FamousSpots
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public Guid WorkplaceId { get; set; }

        [ForeignKey("WorkplaceId")]
      public Workplace Workplace { get; set; }
    }
}