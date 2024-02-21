using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Business.Abstract;
using Restaurant.DTO.DTOs.ContactDTOs;
using Restaurant.Entity.Entities;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactsController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDTO>>(_contactService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDTO createContactDTO)
        {
            _contactService.TAdd(new Contact()
            {
                FooterDescription = createContactDTO.FooterDescription,
                Location = createContactDTO.Location,
                Mail = createContactDTO.Mail,
                Phone = createContactDTO.Phone
            });
            return Ok("İletişim Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("İletişim Bilgisi Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDTO updateContactDTO)
        {
            _contactService.TUpdate(new Contact()
            {
                ContactID = updateContactDTO.ContactID,
                FooterDescription = updateContactDTO.FooterDescription,
                Location = updateContactDTO.Location,
                Mail = updateContactDTO.Mail,
                Phone = updateContactDTO.Phone
            });
            return Ok("İletişim Bilgisi Güncellendi");
        }
    }
}