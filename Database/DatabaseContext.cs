
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapacityPlanApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CapacityPlanApp.Database
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CapacityPlan> CapacityPlan { get; set; }
        public DbSet<CapacityPlanDetails> CapacityPlanDetails { get; set; }
        public DbSet<Project> Project { get; set; }

    }
}
