using Restaurant.DataAccess.Abstract;
using Restaurant.DataAccess.Concrete;
using Restaurant.DataAccess.Repository;
using Restaurant.Entity.Entities;

namespace Restaurant.DataAccess.EntityFramework
{
    public class EFTestimonialDAL : GenericRepository<Testimonial>, ITestimonialDAL
    {
        public EFTestimonialDAL(RestaurantContext context) : base(context)
        {
        }
    }
}