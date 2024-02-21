using Restaurant.DataAccess.Abstract;
using Restaurant.DataAccess.Concrete;
using Restaurant.DataAccess.Repository;
using Restaurant.Entity.Entities;

namespace Restaurant.DataAccess.EntityFramework
{
    public class EFAboutDAL : GenericRepository<About>, IAboutDAL
    {
        public EFAboutDAL(RestaurantContext context) : base(context)
        {
        }
    }
}