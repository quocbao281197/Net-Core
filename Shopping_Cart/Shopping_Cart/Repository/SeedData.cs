using Microsoft.EntityFrameworkCore;
using Shopping_Cart.Models;

namespace Shopping_Cart.Repository
{
	public class SeedData
	{
		public static void SeedingData(DataContext _context)
		{
			_context.Database.Migrate();
			if (!_context.Products.Any())
			{
				CategoryModel phone = new CategoryModel() 
				{
					Name = "Phone",
					Slug = "Phone",
					Description = "Phone is the best",
					Status = 1
				};

				BrandModel apple = new BrandModel()
				{
					Name = "Apple",
					Slug = "Apple",
					Description = "Apple is the best",
					Status = 1
				};

				ProductModel product = new ProductModel()
				{
					Name = "IphoneX",
					Slug = "IphoneX",
					Description = "Apple is the best",
					Image = "1.jpg",
					Category = phone,
					Brand = apple
				};

				_context.Products.AddRange(product);
				_context.SaveChanges();
			}
		}
	}
}
