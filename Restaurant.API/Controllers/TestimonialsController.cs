using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Business.Abstract;
using Restaurant.DTO.DTOs.TestimonialDTOs;
using Restaurant.Entity.Entities;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialsController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDTO>>(_testimonialService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDTO createTestimonialDTO)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                Comment = createTestimonialDTO.Comment,
                ImageURL = createTestimonialDTO.ImageURL,
                Name = createTestimonialDTO.Name,
                Status = createTestimonialDTO.Status,
                Title = createTestimonialDTO.Title
            });
            return Ok("Müşteri Yorum Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Müşteri Yorum Bilgisi Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDTO updateTestimonialDTO)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                Comment = updateTestimonialDTO.Comment,
                ImageURL = updateTestimonialDTO.ImageURL,
                Name = updateTestimonialDTO.Name,
                Status = updateTestimonialDTO.Status,
                Title = updateTestimonialDTO.Title,
                TestimonialID = updateTestimonialDTO.TestimonialID
            });
            return Ok("Müşteri Yorum Bilgisi Güncellendi");
        }
    }
}