using Restaurant.Business.Abstract;
using Restaurant.DataAccess.Abstract;
using Restaurant.Entity.Entities;

namespace Restaurant.Business.Concrete
{
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDAL _discountDAL;

        public DiscountManager(IDiscountDAL discountDAL)
        {
            _discountDAL = discountDAL;
        }

        public void TAdd(Discount entity)
        {
            _discountDAL.Add(entity);
        }

        public void TDelete(Discount entity)
        {
            _discountDAL.Delete(entity);
        }

        public Discount TGetByID(int id)
        {
            return _discountDAL.GetByID(id);
        }

        public List<Discount> TGetListAll()
        {
            return _discountDAL.GetListAll();
        }

        public void TUpdate(Discount entity)
        {
            _discountDAL.Update(entity);
        }
    }
}