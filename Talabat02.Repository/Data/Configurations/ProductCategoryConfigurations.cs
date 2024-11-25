using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat02.Core.Entities;

namespace Talabat02.Repository.Data.Configurations
{
	public class ProductCategoryConfigurations : IEntityTypeConfiguration<ProductCategory>
	{
		public void Configure(EntityTypeBuilder<ProductCategory> builder)
		{
			builder.Property(C => C.Name).IsRequired();
		}
	}
}
