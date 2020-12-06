using Microsoft.EntityFrameworkCore;
using System;


namespace AuthMicroservice.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<User>()
                .HasData(
                new User { Id = Guid.NewGuid(), Username = "User1", Password = "Password1" },
                new User { Id = Guid.NewGuid(), Username = "User2", Password = "Password2" }
                );
        }
    }
}
