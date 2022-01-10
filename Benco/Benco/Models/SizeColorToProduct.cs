using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class SizeColorToProduct
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Size")]
        public int SizeId { get; set; }
        public Size Size { get; set; }

        [ForeignKey("ColorToProduct")]
        public int ColorToProductId { get; set; }
        public ColorToProduct ColorToProduct { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
