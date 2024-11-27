using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Talabat02.Core.Entities;

namespace Talabat02.Repository.Data
{
	public static class StoreContextSeed
	{
		public async static Task SeedAsync(StoreContext _dbContext)
		{
			if (_dbContext.productBrands.Count() == 0)
			{
				var brandsData = File.ReadAllText("../Talabat02.Repository/Data/DataSeeding/brands.json");
				var Brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
				if (Brands is not null && Brands.Count() > 0)
				{
					foreach (var brand in Brands)
					{
						_dbContext.Set<ProductBrand>().Add(brand);

					}
					await _dbContext.SaveChangesAsync();
				} 
			}

			if (_dbContext.productCategories.Count() == 0)
			{
				var categoriesData = File.ReadAllText("../Talabat02.Repository/Data/DataSeeding/categories.json");
				var Categories = JsonSerializer.Deserialize<List<ProductCategory>>(categoriesData);
				if (Categories is not null && Categories.Count() > 0)
				{
					foreach (var Category in Categories)
					{
						_dbContext.Set<ProductCategory>().Add(Category);

					}
					await _dbContext.SaveChangesAsync();
				}
			}

			if (_dbContext.Products.Count() == 0)
			{
				var ProductsData = File.ReadAllText("../Talabat02.Repository/Data/DataSeeding/products.json");
				var Products = JsonSerializer.Deserialize<List<Product>>(ProductsData);
				if (Products is not null && Products.Count() > 0)
				{
					foreach (var Product in Products)
					{
						_dbContext.Set<Product>().Add(Product);

					}
					await _dbContext.SaveChangesAsync();
				}
			}

		}
	}
}
