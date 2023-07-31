using System.ComponentModel.DataAnnotations;

namespace CreateWebformusingtaghelpers.Models
{
    public class Student
    {
        [Required(ErrorMessage = "StudentID is required")]
        public int? StudentID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(20,50)]
        public int?    Age { get; set; }

       
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Email is required")]
        //[RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$\r\n", ErrorMessage = "invalid email")]

        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "Must contain  6 charactors UpperCase, LowerCase and Number.")]
        public string? Password { get; set; }

        [Compare("Password",ErrorMessage ="Password must be same")]
        public string? ConfirmPassword { get; set; }

        //[Url(ErrorMessage ="Invalid Url")]
        //public string? Url { get; set; }




        //public string? MartialStautus { get; set

    }



    
    public enum Gender
    {
            Male,Female
    }
}
