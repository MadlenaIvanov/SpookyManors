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
        public DbSet<Review> Reviews { get; init; }
        public DbSet<Service> Services { get; init; }
        public DbSet<Product> Products { get; init; }
        public DbSet<Guide> Guides { get; init; }
        public DbSet<Guest> Guests { get; init; }
        public DbSet<Employee> Employees { get; init; }
        public DbSet<Schedule> Schedules { get; init; }
        public DbSet<Archive> Archives { get; init; }
        public DbSet<Owner> Owner { get; init; }
        public DbSet<Case> Cases { get; init; }
        public DbSet<History> Histories { get; init; }
        public DbSet<Condition> Conditions { get; init; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<House>()
                .HasOne(c => c.Category)
                .WithMany(h => h.Houses)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(builder);
        }
    }
}