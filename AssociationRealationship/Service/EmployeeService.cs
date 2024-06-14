using AssociationRealationship.Models;
using AssociationRealationship.Repository;

namespace AssociationRealationship.Service
{
    public class EmployeeService : Service<Employee>, IEmployeeService
    {
        private readonly IEmployeeRepository _obj;
        public EmployeeService(IEmployeeRepository obj) : base(obj)
        {
            _obj = obj;
        }

        public List<Employee> GetEmployee(int id)
        {
            return _obj.GetEmployee(id);
        }
    }
}
