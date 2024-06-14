using AssociationRealationship.Models;

namespace AssociationRealationship.Repository
{
    public interface IDepartmentRepository:IRepository<Department>
    {
        public Department EmployeeFind(int id);
    }
}
