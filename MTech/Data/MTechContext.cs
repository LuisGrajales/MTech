using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MTech.Models;

namespace MTech.Data
{
    public class MTechContext : DbContext
    {
        public MTechContext (DbContextOptions<MTechContext> options)
            : base(options)
        {
        }

        public DbSet<MTech.Models.Employee> Employee { get; set; } = default!;
    }
}
