namespace Restaurant.DTO.DTOs.DiscountDTOs
{
    public class UpdateDiscountDTO
    {
        public int DiscountID { get; set; }
        public string? Title { get; set; }
        public string? Amount { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }
        public bool IsActive { get; set; }
        public DateTime ValidDate { get; set; }
    }
}