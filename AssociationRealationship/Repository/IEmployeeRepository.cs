using AssociationRealationship.Models;

namespace AssociationRealationship.Repository
{
    public interface IEmployeeRepository:IRepository<Employee>
    {
        public List<Employee>GetEmployee(int id);
    }
}
