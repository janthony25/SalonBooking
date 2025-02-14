using Microsoft.EntityFrameworkCore;
using SalonBooking.Models;
using System.Data.Common;

namespace SalonBooking.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<BusinessDay> BusinessDays { get; set; }
        public DbSet<SpecialClosure> SpecialClosures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var businessDays = new List<BusinessDay>
            {
                new BusinessDay { DayId = 1, DayName = "Monday", IsOpen = true },
                new BusinessDay { DayId = 2, DayName = "Tuesday", IsOpen = true },
                new BusinessDay { DayId = 3, DayName = "Wednesday", IsOpen = true },
                new BusinessDay { DayId = 4, DayName = "Thursday", IsOpen = true },
                new BusinessDay { DayId = 5, DayName = "Friday", IsOpen = true },
                new BusinessDay { DayId = 6, DayName = "Saturday", IsOpen = true },
                new BusinessDay { DayId = 7, DayName = "Sunday", IsOpen = true }
            };

            modelBuilder.Entity<BusinessDay>().HasData(businessDays);
        }
    }
}
