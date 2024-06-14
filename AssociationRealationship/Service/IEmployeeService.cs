using AssociationRealationship.Models;

namespace AssociationRealationship.Service
{
    public interface IEmployeeService:IService<Employee>
    {
        public List<Employee> GetEmployee(int id);
    }
}
