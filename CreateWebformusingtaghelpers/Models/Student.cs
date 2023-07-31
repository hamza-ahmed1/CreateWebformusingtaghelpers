namespace CreateWebformusingtaghelpers.Models
{
    public class Student
    {
        public int Rollnum { get; set; }
        public string? Name { get; set; }
        public int    Age { get; set; }
        public Gender Gender { get; set; }
        public string? Email { get; set; }
        public string? MartialStautus { get; set; }



    }
    public enum Gender
    {
            Male,Female
    }
}
