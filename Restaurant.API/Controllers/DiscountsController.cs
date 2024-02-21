using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Business.Abstract;
using Restaurant.DTO.DTOs.DiscountDTOs;
using Restaurant.Entity.Entities;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountsController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var value = _mapper.Map<List<ResultDiscountDTO>>(_discountService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDTO createDiscountDTO)
        {
            _discountService.TAdd(new Discount()
            {
                Amount = createDiscountDTO.Amount,
                Description = createDiscountDTO.Description,
                ImageURL = createDiscountDTO.ImageURL,
                Title = createDiscountDTO.Title,
                IsActive = createDiscountDTO.IsActive,
                ValidDate = createDiscountDTO.ValidDate
            });
            return Ok("İndirim Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            _discountService.TDelete(value);
            return Ok("İndirim Bilgisi Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDTO updateDiscountDTO)
        {
            _discountService.TUpdate(new Discount()
            {
                Amount = updateDiscountDTO.Amount,
                Description = updateDiscountDTO.Description,
                ImageURL = updateDiscountDTO.ImageURL,
                Title = updateDiscountDTO.Title,
                IsActive = updateDiscountDTO.IsActive,
                ValidDate = updateDiscountDTO.ValidDate,
                DiscountID = updateDiscountDTO.DiscountID
            });
            return Ok("İndirim Bilgisi Güncellendi");
        }
    }
}