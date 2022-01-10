using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Benco.Models
{
    public class CUser:IdentityUser
    {
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
