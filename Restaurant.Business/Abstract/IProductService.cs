using Restaurant.Entity.Entities;

namespace Restaurant.Business.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
    }
}