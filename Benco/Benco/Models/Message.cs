using System;
using System.ComponentModel.DataAnnotations;

namespace Benco.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Fullname { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(2000)]
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
