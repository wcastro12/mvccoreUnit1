using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace WebApliCountries.Models
{
    public class AplicationContext:IdentityDbContext<AplicationUser>
    {
        public AplicationContext(DbContextOptions<AplicationContext> options) :base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
    }
}
