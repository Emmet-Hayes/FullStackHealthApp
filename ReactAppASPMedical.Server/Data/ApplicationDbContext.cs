using Microsoft.EntityFrameworkCore;
using ReactAppASPMedical.Server.Models;


namespace ReactAppASPMedical.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :   base(options) { }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
