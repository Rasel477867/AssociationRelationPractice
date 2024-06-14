
using AssociationRealationship.Data;
using Microsoft.EntityFrameworkCore;

namespace AssociationRealationship.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
        }
        public DbSet<T> Table
        {
            get { return _db.Set<T>(); }
        }
        public bool Add(T entity)
        {
           Table.Add(entity);
           return  _db.SaveChanges()>0;
        }

        public bool Delete(T entity)
        {
            Table.Remove(entity);
            return _db.SaveChanges()>0;
        }

        public virtual List<T> GetAll()
        {
            return Table.ToList();
        }

        public T GetById(int id)
        {
            return Table.Find(id);
        }

        public bool Update(T entity)
        {
            Table.Update(entity);
            return _db.SaveChanges()>0;
        }
    }
}
