using BookAppointment.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAppointment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=taskmvc;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
