using Restaurant.Business.Abstract;
using Restaurant.DataAccess.Abstract;
using Restaurant.Entity.Entities;

namespace Restaurant.Business.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDAL _bookingDAL;

        public BookingManager(IBookingDAL bookingDAL)
        {
            _bookingDAL = bookingDAL;
        }

        public void TAdd(Booking entity)
        {
            _bookingDAL.Add(entity);
        }

        public void TDelete(Booking entity)
        {
            _bookingDAL.Delete(entity);
        }

        public Booking TGetByID(int id)
        {
            return _bookingDAL.GetByID(id);
        }

        public List<Booking> TGetListAll()
        {
            return _bookingDAL.GetListAll();
        }

        public void TUpdate(Booking entity)
        {
            _bookingDAL.Update(entity);
        }
    }
}