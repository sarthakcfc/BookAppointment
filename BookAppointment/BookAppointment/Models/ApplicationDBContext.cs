using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace BookAppointment.Models
{
    public class ApplicationDbContext : DbContext //IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Business> Business { get; set; }
    
        public DbSet<ServiceProvided> Services { get; set; }

        public DbSet<Appointment> Appointment { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<ServiceProvided>().ToTable("ServicesProvided");
            builder.Entity<Business>().ToTable("Businesses");
            builder.Entity<Appointment>().ToTable("Appointments");
            builder.Entity<Appointment>().HasKey<int>(obj => obj.ID);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}