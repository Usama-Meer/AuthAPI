using System.ComponentModel.DataAnnotations;

namespace AuthAPI.Models
{
    public class School
    {
        [Key]
        public int SchoolId { get; set; }
        [Required]
        public  string SchoolName { get;
            set; }




        public string? SchoolDescription { get; set; }


        public  string? SchoolAddress { get; set; }   







    }
}
