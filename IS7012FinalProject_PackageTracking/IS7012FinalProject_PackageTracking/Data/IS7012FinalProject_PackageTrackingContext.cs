using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IS7012FinalProject_PackageTracking.Models;

namespace IS7012FinalProject_PackageTracking.Data
{
    public class IS7012FinalProject_PackageTrackingContext : DbContext
    {
        public IS7012FinalProject_PackageTrackingContext (DbContextOptions<IS7012FinalProject_PackageTrackingContext> options)
            : base(options)
        {
        }

        public DbSet<IS7012FinalProject_PackageTracking.Models.User> User { get; set; }

        public DbSet<IS7012FinalProject_PackageTracking.Models.Package> Package { get; set; }

        public DbSet<IS7012FinalProject_PackageTracking.Models.Deliverer> Deliverer { get; set; }

        public DbSet<IS7012FinalProject_PackageTracking.Models.TrackingNumber> TrackingNumber { get; set; }
    }
}
