using Restaurant.DataAccess.Abstract;
using Restaurant.DataAccess.Concrete;
using Restaurant.DataAccess.Repository;
using Restaurant.Entity.Entities;

namespace Restaurant.DataAccess.EntityFramework
{
    public class EFCategoryDAL : GenericRepository<Category>, ICategoryDAL
    {
        public EFCategoryDAL(RestaurantContext context) : base(context)
        {
        }

		public void UpdateStatus(int id)
		{
			var context = new RestaurantContext();
			var category = context.Categories.Where(x => x.CategoryID == id).FirstOrDefault();
			if (category.Status == true)
			{
				category.Status = false;
			}
			else
			{
				category.Status = true;
			}
			context.Update(category);
			context.SaveChanges();
		}
	}
}