namespace Restaurant.DataAccess.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetByID(int id);
        List<T> GetListAll();
    }
}