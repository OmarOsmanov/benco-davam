using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class FAQ
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(500)]
        public string Title { get; set; }

        [Column(TypeName ="ntext")]
        public string Content { get; set; }

        [MaxLength(500)]
        public string Question { get; set; }

        [Column(TypeName = "ntext")]
        public string QuestionContent { get; set; }
    }
}
