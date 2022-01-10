using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string Title { get; set; }

        [Column(TypeName ="ntext")]
        public string Content { get; set; }

        [MaxLength(250)]
        public string Image1 { get; set; }
        [NotMapped]
        public IFormFile Imag1File { get; set; }

        [MaxLength(250)]
        public string Image2 { get; set; }
        [NotMapped]
        public IFormFile Image2File { get; set; }
    }
}
