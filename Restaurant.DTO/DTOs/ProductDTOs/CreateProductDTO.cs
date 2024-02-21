namespace Restaurant.DTO.DTOs.ProductDTOs
{
    public class CreateProductDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageURL { get; set; }
        public bool Status { get; set; }
    }
}