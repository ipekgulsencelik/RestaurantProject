using Restaurant.DataAccess.Abstract;
using Restaurant.DataAccess.Concrete;
using Restaurant.DataAccess.Repository;
using Restaurant.Entity.Entities;

namespace Restaurant.DataAccess.EntityFramework
{
    public class EFSocialMediaDAL : GenericRepository<SocialMedia>, ISocialMediaDAL
    {
        public EFSocialMediaDAL(RestaurantContext context) : base(context)
        {
        }
    }
}