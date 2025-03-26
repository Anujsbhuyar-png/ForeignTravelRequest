using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FTR.DL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        public DbSet<PersonalDetails> PersonalDetails { get; set; }
        public DbSet<Status> Status { get; set; }

        public DbSet<ForeignTravelRequest> ForeignTravelRequest { get; set; }

    }
}
