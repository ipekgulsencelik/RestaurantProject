using Restaurant.Entity.Entities;

namespace Restaurant.Business.Abstract
{
	public interface ICategoryService : IGenericService<Category>
	{
		void TUpdateStatus(int id);
	}
}