using AssociationRealationship.Data;
using AssociationRealationship.Models;

namespace AssociationRealationship.Repository
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
