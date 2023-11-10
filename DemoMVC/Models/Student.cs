using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DemoMVC.Models
{
    public class Student : Person
    {
        // [Required(ErrorMessage = "Vui long nhap Student id")]
        public string StudentID { get; set; }
        public string PersonId { get; set; }

        [ForeignKey("PersonId")]
        public Person? Person { get; set; }

    }
}