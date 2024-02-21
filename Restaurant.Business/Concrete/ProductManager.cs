using Restaurant.Business.Abstract;
using Restaurant.DataAccess.Abstract;
using Restaurant.Entity.Entities;

namespace Restaurant.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void TAdd(Product entity)
        {
            _productDAL.Add(entity);
        }

        public void TDelete(Product entity)
        {
            _productDAL.Delete(entity);
        }

        public Product TGetByID(int id)
        {
            return _productDAL.GetByID(id);
        }

        public List<Product> TGetListAll()
        {
            return _productDAL.GetListAll();
        }

        public void TUpdate(Product entity)
        {
            _productDAL.Update(entity);
        }
    }
}