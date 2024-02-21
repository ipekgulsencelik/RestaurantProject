namespace Restaurant.DTO.DTOs.ContactDTOs
{
    public class UpdateContactDTO
    {
        public int ContactID { get; set; }
        public string? Location { get; set; }
        public string? Phone { get; set; }
        public string? Mail { get; set; }
        public string? FooterDescription { get; set; }
    }
}