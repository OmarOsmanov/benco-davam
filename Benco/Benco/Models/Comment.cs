using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(2000)]
        public string Text { get; set; }
        [ForeignKey("CUser")]
        public string CUserId { get; set; }
        public CUser CUser { get; set; }
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        [ForeignKey("ParentComment")]
        public int ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
