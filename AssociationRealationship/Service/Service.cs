
using AssociationRealationship.Repository;

namespace AssociationRealationship.Service
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _obj;
        public Service(IRepository<T> obj)
        {
            _obj = obj; 
        }
        public bool Add(T entity)
        {
           return _obj.Add(entity);
        }

        public bool Delete(T entity)
        {
            return (_obj.Delete(entity));
        }

        public List<T> GetAll()
        {
            return _obj.GetAll();
        }

        public T GetById(int id)
        {
            return _obj.GetById(id);
        }

        public bool Update(T entity)
        {
            return _obj.Update(entity);
        }
    }
}
