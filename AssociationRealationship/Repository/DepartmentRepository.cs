using AssociationRealationship.Data;
using AssociationRealationship.Models;
using Microsoft.EntityFrameworkCore;

namespace AssociationRealationship.Repository
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        private readonly ApplicationDbContext _db;
        public DepartmentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Department EmployeeFind(int id)
        {
            return _db.Departments.Include(c => c.Employees).FirstOrDefault(c => c.Id == id);
        }

        public override List<Department> GetAll()
        {
            return _db.Departments.ToList();
        }
    
       
    }
}
