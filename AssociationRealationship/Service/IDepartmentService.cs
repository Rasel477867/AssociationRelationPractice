using AssociationRealationship.Models;

namespace AssociationRealationship.Service
{
    public interface IDepartmentService:IService<Department>
    {
        public Department EmployeeFind(int id);
    }
}
