using Restaurant.Entity.Entities;

namespace Restaurant.DataAccess.Abstract
{
	public interface ICategoryDAL : IGenericDAL<Category>
	{
		void UpdateStatus(int id);
	}
}