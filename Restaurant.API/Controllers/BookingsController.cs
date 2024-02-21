using Microsoft.AspNetCore.Mvc;
using Restaurant.Business.Abstract;
using Restaurant.DTO.DTOs.BookingDTOs;
using Restaurant.Entity.Entities;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDTO createBookingDTO)
        {
            Booking booking = new Booking()
            {
                Mail = createBookingDTO.Mail,
                BookingDate = createBookingDTO.BookingDate,
                Name = createBookingDTO.Name,
                PersonCount = createBookingDTO.PersonCount,
                Phone = createBookingDTO.Phone
            };
            _bookingService.TAdd(booking);
            return Ok("Rezervasyon Yapıldı");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon Silindi");
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDTO updateBookingDTO)
        {
            Booking booking = new Booking()
            {
                Mail = updateBookingDTO.Mail,
                BookingID = updateBookingDTO.BookingID,
                Name = updateBookingDTO.Name,
                PersonCount = updateBookingDTO.PersonCount,
                Phone = updateBookingDTO.Phone,
                BookingDate = updateBookingDTO.BookingDate
            };
            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            return Ok(value);
        }
    }
}