using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [ForeignKey("ColorToProduct")]
        public int ColorToProductId { get; set; }
        public ColorToProduct ColorToProduct { get; set; }
    }
}
