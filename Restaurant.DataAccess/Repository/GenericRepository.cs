using Restaurant.DataAccess.Abstract;
using Restaurant.DataAccess.Concrete;

namespace Restaurant.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        private readonly RestaurantContext _context;

        public GenericRepository(RestaurantContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}