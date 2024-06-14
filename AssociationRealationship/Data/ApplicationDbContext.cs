using AssociationRealationship.Models;
using Microsoft.EntityFrameworkCore;

namespace AssociationRealationship.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Duet> Duets { get; set; }
        
    }
}
