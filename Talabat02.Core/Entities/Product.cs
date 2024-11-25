using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat02.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }
        //  [ForeignKey(nameof(Product.Brand))] , we will make with fluent 
        // if the name of this column is ProductBrandId , there is no need to foreignkey att , he make it by convention
        // we make this with data annotation or fluent to know the EF that this column represent the fk here 
        // if we dont do that , EF will ignore it and he will make column called name of the class+ID 
        public int BrandId { get; set; }
        public ProductBrand Brand { get; set; }

        public int CategoryId { get; set; }
        public ProductCategory Category { get; set; }


    }
}
