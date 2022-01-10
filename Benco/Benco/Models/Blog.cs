using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [Column(TypeName = "ntext"), Required]
        public string Content { get; set; }
        [ForeignKey("CUser")]
        public string CUserId { get; set; }
        public CUser CUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<TagToBlog> TagToBlogs { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
