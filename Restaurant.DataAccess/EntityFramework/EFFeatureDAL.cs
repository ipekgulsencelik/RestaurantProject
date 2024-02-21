using Restaurant.DataAccess.Abstract;
using Restaurant.DataAccess.Concrete;
using Restaurant.DataAccess.Repository;
using Restaurant.Entity.Entities;

namespace Restaurant.DataAccess.EntityFramework
{
    public class EFFeatureDAL : GenericRepository<Feature>, IFeatureDAL
    {
        public EFFeatureDAL(RestaurantContext context) : base(context)
        {
        }
    }
}