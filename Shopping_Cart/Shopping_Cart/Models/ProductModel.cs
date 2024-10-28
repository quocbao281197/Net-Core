using System.ComponentModel.DataAnnotations;

namespace Shopping_Cart.Models
{
	public class ProductModel
	{
		[Key]
		public int Id { get; set; }
		[Required, MinLength(4, ErrorMessage = "Name is required and more than 4 characters")]
		public string Name { get; set; }
		[Required, MinLength(4, ErrorMessage = "Description is required and more than 4 characters")]
		public string Description { get; set; }
		public string Slug { get; set; }
		public decimal Price { get; set; }
		public int BrandId { get; set; }
		public int CategoryId { get; set; }

		public CategoryModel Category { get; set; }
		public BrandModel Brand { get; set; }
		public string Image { get; set; }
	}
}
