using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApplicationMVC.Models;

namespace ApplicationMVC.Data
{
    public class ApplicationMVCContext : DbContext
    {
        public ApplicationMVCContext (DbContextOptions<ApplicationMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationMVC.Models.Movie> Movie { get; set; } = default!;
    }
}
