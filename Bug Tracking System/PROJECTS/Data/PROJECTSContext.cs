using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PROJECTS.Models;

namespace PROJECTS.Data
{
    public class PROJECTSContext : DbContext
    {
        public PROJECTSContext (DbContextOptions<PROJECTSContext> options)
            : base(options)
        {
        }

        public DbSet<PROJECTS.Models.Bug> Bug { get; set; } = default!;
    }
}
