using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<User> Users => Set<User>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    User testUser1 = new User
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "TestUser1",
        //        Password = "TestUser1",
        //        PasswordHash = BCrypt.Net.BCrypt.HashPassword("test")

        //    };
        //    modelBuilder.Entity<User>().HasData(new User[] { testUser1 });
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
