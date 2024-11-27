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
        public class ProductBrandConfig : IEntityTypeConfiguration<ProductBrand>
		{
			public void Configure(EntityTypeBuilder<ProductBrand> builder)
			{
				builder.Property(B => B.Name).IsRequired();
			}
		}
	
}
