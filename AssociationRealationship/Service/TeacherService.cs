using AssociationRealationship.Models;
using AssociationRealationship.Repository;

namespace AssociationRealationship.Service
{
    public class TeacherService : Service<Teacher>, ITeacherService
    {
        public TeacherService(ITeacherRepository obj) : base(obj)
        {
        }
    }
}
