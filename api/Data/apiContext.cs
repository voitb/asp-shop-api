using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Data
{
    public class apiContext : DbContext
    {
        public apiContext (DbContextOptions<apiContext> options)
            : base(options)
        {
        }

        public DbSet<api.Models.Item> Item { get; set; } = default!;
        public DbSet<api.Models.Category> Category { get; set; } = default!;
        public DbSet<api.Models.User> User { get; set; } = default!;
        public DbSet<api.Models.Purchase> Purchase { get; set; } = default!;
    }
}
