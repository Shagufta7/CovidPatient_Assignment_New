using CovidPatient_Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace CovidPatient_Assignment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; }

    }
}
