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
    }
}