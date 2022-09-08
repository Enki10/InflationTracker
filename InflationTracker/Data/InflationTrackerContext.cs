#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InflationTracker.Models;

namespace InflationTracker.Data
{
    public class InflationTrackerContext : DbContext
    {
        public InflationTrackerContext (DbContextOptions<InflationTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<InflationTracker.Models.Grocery> Grocery { get; set; }
    }
}
