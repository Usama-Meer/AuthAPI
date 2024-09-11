using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthAPI.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        
        [Required]
        public  string Name { get; set; }

        [Required]
        public  int CreditHours { get; set; }
        
        [Required]
        public  string Description { get; set; }



        [Required]
        public int SchoolId {  get; set; }
        [ForeignKey("SchoolId")]

        public School School { get; set; }
    }
}
