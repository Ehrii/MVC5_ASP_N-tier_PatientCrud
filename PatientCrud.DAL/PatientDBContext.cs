using System.Collections.Generic;
using System.Data.Entity;

using PatientCrud.DTO; 

namespace PatientCrud.DAL
{
    public class PatientDbContext : DbContext
    {
        public PatientDbContext() : base("DefaultConnection") 
        {
        }

        public DbSet<PatientDTO> Patients { get; set; } 
    }
}
