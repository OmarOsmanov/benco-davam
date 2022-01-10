using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string About { get; set; }

        [MaxLength(10)]
        public string Description { get; set; }
        [ForeignKey("ProductCategory")]
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public List<ProductTagToProduct> ProductTagToProducts { get; set; }
        public List<ColorToProduct> ColorToProducts { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
