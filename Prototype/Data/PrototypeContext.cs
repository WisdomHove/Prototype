using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prototype.Models;

namespace Prototype.Data
{
    public class PrototypeContext : DbContext
    {
        public PrototypeContext (DbContextOptions<PrototypeContext> options)
            : base(options)
        {
        }

        public DbSet<Prototype.Models.Supplier> Supplier { get; set; } = default!;
    }
}
