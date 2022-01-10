using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(2500)]
        public string Text { get; set; }
        [ForeignKey("CUser")]
        public string CUserId { get; set; }
        public CUser CUser { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public byte Rating { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
