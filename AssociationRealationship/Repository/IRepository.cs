namespace AssociationRealationship.Repository
{
    public interface IRepository<T>where T : class
    {
        public List<T> GetAll();
        public bool Add(T entity);
        public bool Delete(T entity);
        public bool Update(T entity);
        public T GetById(int id);
    }
}
