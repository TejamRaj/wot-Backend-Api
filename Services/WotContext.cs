using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorkPlaceOnTour.BACKEND.Entities;

namespace WorkPlaceOnTour.BACKEND.Services
{
    //public class WotDbContext:DbContext
    //{
    //    public DbSet<TourDestination> TourDestinations { get; set; }
      
    //    public DbSet<Workplace> Workplaces { get; set; }
        
    //   public DbSet<WokrplaceBooking> WokrplaceBookings { get; set; }

       

    //    private readonly IUserInfoService _userInfoService;


    //    public WotDbContext(DbContextOptions<WotDbContext> options,
    //       IUserInfoService userInfoService)
    //      : base(options)
    //    {
    //        // userInfoService is a required argument
    //        _userInfoService = userInfoService ?? throw new ArgumentNullException(nameof(userInfoService));
    //    }


    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<TourDestination>().HasMany(w => w.WorkPlaces)
    //                                              .WithOne(t=>t.TourDestination)
    //                                              .HasForeignKey(w=>w.TourId);

    //    }

    //    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    //    {
    //        // get added or updated entries
    //        var addedOrUpdatedEntries = ChangeTracker.Entries()
    //                .Where(x => (x.State == EntityState.Added || x.State == EntityState.Modified));

    //        // fill out the audit fields
    //        foreach (var entry in addedOrUpdatedEntries)
    //        {
    //            var entity = entry.Entity as AuditableEntity;

    //            if (entry.State == EntityState.Added)
    //            {
    //                entity.CreatedBy = _userInfoService.UserId;
    //                entity.CreatedOn = DateTime.UtcNow;
    //            }

    //            entity.UpdatedBy = _userInfoService.UserId;
    //            entity.UpdatedOn = DateTime.UtcNow;
    //        }

    //        return base.SaveChangesAsync(cancellationToken);
    //    }
    //}
}
