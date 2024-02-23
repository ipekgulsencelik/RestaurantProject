namespace Restaurant.WebUI.DTOs.CategoryDTOs
{
	public class UpdateCategoryDTO
	{
		public int CategoryID { get; set; }
		public string? Name { get; set; }
		public bool Status { get; set; }
	}
}