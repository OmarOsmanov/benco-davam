using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class ProductTagToProduct
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [ForeignKey("ProductTag")]
        public int ProductTagId { get; set; }
        public ProductTag ProductTag { get; set; }
    }
}
