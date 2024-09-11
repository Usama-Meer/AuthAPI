using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthAPI.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public int SchoolId { get; set; }
        [ForeignKey("SchoolId")]
        public School School { get; set; }
        public ICollection<Course>? Course { get; set; }


        
    }
}
