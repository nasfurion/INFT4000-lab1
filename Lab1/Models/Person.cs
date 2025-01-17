using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Display (Name="First Name")]
        public string FirstName { get; set; } = string.Empty;
        [Display (Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

    }
}
