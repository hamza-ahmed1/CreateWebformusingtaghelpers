using System.ComponentModel.DataAnnotations;

namespace CreateWebformusingtaghelpers.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Rollnum is required")]
        public int? Rollnum{ get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is required")]
        [Range(20,50)]
        public int?    Age { get; set; }
       public Gender Gender { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]

        public string? Email { get; set; }
        
        //public string? MartialStautus { get; set

    }



    
    public enum Gender
    {
            Male,Female
    }
}
