using Restaurant.DataAccess.Abstract;
using Restaurant.DataAccess.Concrete;
using Restaurant.DataAccess.Repository;
using Restaurant.Entity.Entities;

namespace Restaurant.DataAccess.EntityFramework
{
    public class EFDiscountDAL : GenericRepository<Discount>, IDiscountDAL
    {
        public EFDiscountDAL(RestaurantContext context) : base(context)
        {
        }
    }
}