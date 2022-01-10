using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }

        [MaxLength(1000)]
        public string Info { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(150)]
        public string WorkTime { get; set; }
    }
}
