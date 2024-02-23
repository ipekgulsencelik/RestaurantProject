using Restaurant.Business.Abstract;
using Restaurant.DataAccess.Abstract;
using Restaurant.Entity.Entities;

namespace Restaurant.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void TAdd(Category entity)
        {
            _categoryDAL.Add(entity);
        }

        public void TDelete(Category entity)
        {
            _categoryDAL.Delete(entity);
        }

        public Category TGetByID(int id)
        {
            return _categoryDAL.GetByID(id);
        }

        public List<Category> TGetListAll()
        {
            return _categoryDAL.GetListAll();
        }

        public void TUpdate(Category entity)
        {
            _categoryDAL.Update(entity);
        }

		public void TUpdateStatus(int id)
		{
			_categoryDAL.UpdateStatus(id);
		}
	}
}