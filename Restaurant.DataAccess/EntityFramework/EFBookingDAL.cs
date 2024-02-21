using Restaurant.DataAccess.Abstract;
using Restaurant.DataAccess.Concrete;
using Restaurant.DataAccess.Repository;
using Restaurant.Entity.Entities;

namespace Restaurant.DataAccess.EntityFramework
{
    public class EFBookingDAL : GenericRepository<Booking>, IBookingDAL
    {
        public EFBookingDAL(RestaurantContext context) : base(context)
        {
        }
    }
}