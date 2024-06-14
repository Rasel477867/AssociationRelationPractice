using AssociationRealationship.Models;
using AssociationRealationship.Repository;

namespace AssociationRealationship.Service
{
    public class DuetService : Service<Duet>, IDuetService
    {
        public DuetService(IDuetRepository obj) : base(obj)
        {
        }
    }
}
