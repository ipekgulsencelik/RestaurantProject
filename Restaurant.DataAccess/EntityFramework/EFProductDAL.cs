using Microsoft.EntityFrameworkCore;
using Restaurant.DataAccess.Abstract;
using Restaurant.DataAccess.Concrete;
using Restaurant.DataAccess.Repository;
using Restaurant.Entity.Entities;

namespace Restaurant.DataAccess.EntityFramework
{
    public class EFProductDAL : GenericRepository<Product>, IProductDAL
    {
        public EFProductDAL(RestaurantContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new RestaurantContext();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }
    }
}