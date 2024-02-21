using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Business.Abstract;
using Restaurant.DTO.DTOs.SocialMediaDTOs;
using Restaurant.Entity.Entities;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var value = _mapper.Map<List<ResultSocialMediaDTO>>(_socialMediaService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDTO createSocialMediaDTO)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {
                Icon = createSocialMediaDTO.Icon,
                Title = createSocialMediaDTO.Title,
                URL = createSocialMediaDTO.URL
            });
            return Ok("Sosyal Medya Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok("Sosyal Medya Bilgisi Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDTO updateSocialMediaDTO)
        {
            _socialMediaService.TUpdate(new SocialMedia()
            {
                Icon = updateSocialMediaDTO.Icon,
                Title = updateSocialMediaDTO.Title,
                URL = updateSocialMediaDTO.URL,
                SocialMediaID = updateSocialMediaDTO.SocialMediaID
            });
            return Ok("Sosyal Medya Bilgisi Güncellendi");
        }
    }
}