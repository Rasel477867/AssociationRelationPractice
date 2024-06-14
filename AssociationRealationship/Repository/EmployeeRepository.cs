using AssociationRealationship.Data;
using AssociationRealationship.Models;
using System.Linq;
namespace AssociationRealationship.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _db;
        public EmployeeRepository(ApplicationDbContext db) : base(db)
        {
            _db=db;
        }

        public List<Employee> GetEmployee(int id)
        {
            return _db.Employees.Where(c=>c.DepartmentId==id).ToList();
        }
    }
}
