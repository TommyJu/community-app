using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CommunityApp.Models;

namespace CommunityApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {    }
    
    public DbSet<City>? Cities {get; set;}
    public DbSet<Province>? Provinces {get; set;}

    protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Uses our model classes/entities to create the table
            builder.Entity<City>().ToTable("City");
            builder.Entity<Province>().ToTable("Province");
            builder.Seed();
        }
}
