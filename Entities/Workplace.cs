using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkPlaceOnTour.BACKEND.Entities
{
    public class Workplace: AuditableEntity
    {

        public Workplace()
        {
            activities = new List<Activity>();
            Amenties = new List<Amenties>();
            FamousSpots = new List<FamousSpots>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid WorkplaceId { get; set; }

       


        public Guid TourId { get; set; }
       
        [ForeignKey("TourId")]
        public TourDestination TourDestination { get; set; }

        public string Address { get; set; }

        public int rate { get; set; }

    
        public List<Activity> activities { get; set; }

        public List<Amenties> Amenties { get; set; }

        public List<FamousSpots> FamousSpots { get; set; }
        public string WorkplacePhotoUrl { get; set; }
    }
}