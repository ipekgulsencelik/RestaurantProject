namespace Restaurant.DTO.DTOs.AboutDTOs
{
    public class UpdateAboutDTO
    {
        public int AboutID { get; set; }
        public string? ImageURL { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}