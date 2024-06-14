using AssociationRealationship.Data;
using AssociationRealationship.Models;

namespace AssociationRealationship.Repository
{
    public class DuetRepository : Repository<Duet>, IDuetRepository
    {
        public DuetRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
