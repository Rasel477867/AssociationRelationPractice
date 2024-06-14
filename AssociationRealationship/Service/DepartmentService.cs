using AssociationRealationship.Models;
using AssociationRealationship.Repository;

namespace AssociationRealationship.Service
{
    public class DepartmentService : Service<Department>, IDepartmentService
    {
        private readonly IDepartmentRepository _obj;
        public DepartmentService(IDepartmentRepository obj) : base(obj)
        {
            _obj = obj;
        }

        public Department EmployeeFind(int id)
        {
           return _obj.EmployeeFind(id);
        }
    }
}
