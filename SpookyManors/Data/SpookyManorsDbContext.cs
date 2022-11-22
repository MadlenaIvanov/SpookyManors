using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpookyManors.Data.Models;

namespace SpookyManors.Data
{
    public class SpookyManorsDbContext : IdentityDbContext
    {
        public SpookyManorsDbContext(DbContextOptions<SpookyManorsDbContext> options)
            : base(options)
        {
        }

        public DbSet<House> Houses { get; init; }
        public DbSet<Category> Categories { get; init; }
    }
}