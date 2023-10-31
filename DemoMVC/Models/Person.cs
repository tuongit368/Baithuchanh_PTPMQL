using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
// Ho Va Ten : Dang Ngoc Tuong  || Ma Sinh Vien : 2121050140
{
    [Table("Persons")]
    public class Person 
    {
        [Key]
        // Thuoc tinh
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}