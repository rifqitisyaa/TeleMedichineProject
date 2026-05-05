using Microsoft.AspNetCore.Components.Routing;
using Microsoft.EntityFrameworkCore;
using TeleMedichineProject.Models.TeleClass;

namespace TeleMedichineProject.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Ignore<ImportMCUCorporate>();
            modelBuilder.Ignore<Item>();

            modelBuilder.Entity<Appointment>().ToTable("Appointment");
        }
    }
}