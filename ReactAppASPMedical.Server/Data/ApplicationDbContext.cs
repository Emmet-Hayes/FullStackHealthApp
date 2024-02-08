using Microsoft.EntityFrameworkCore;
using FullStackApp.Server.Models;
using System.Collections.Generic;


namespace FullStackApp.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :   base(options) { }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
