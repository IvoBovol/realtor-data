
///Hussein Abed Work

using BlazorServerCRUD.Pages;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerCRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<House>().HasData(
                    new House
                    {
                        Id = 1,
                        City = "Toronto",
                        Status = "Available",
                        Year = new DateTime(2004, 11, 16)
                    },
                    new House
                    {
                        Id = 2,
                        City = "Mississauga",
                        Status = "sold",
                        Year = new DateTime(2011, 12, 10)
                    },
                     new House
                     {
                         Id = 3,
                         City = "Montreal",
                         Status = "Available",
                         Year = new DateTime(2004, 11, 16)
                     },
                    new House
                    {
                        Id = 4,
                        City = "brampton",
                        Status = "sold",
                        Year = new DateTime(2011, 12, 10)
                    }
                );

            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Request>().HasKey(r => r.Id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyInMemoryDatabase");
        }

        public DbSet<House> Houses => Set<House>();
        public DbSet<Request> Requests { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
