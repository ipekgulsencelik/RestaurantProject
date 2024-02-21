namespace Restaurant.DTO.DTOs.ProductDTOs
{
    public class ResultProductWithCategory
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageURL { get; set; }
        public bool ProductStatus { get; set; }
        public string? CategoryName { get; set; }
    }
}