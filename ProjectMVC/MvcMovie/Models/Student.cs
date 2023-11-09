using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{   
    [Table("Students")]
    public class Student
    {
        [Key]
        public String StudentID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public int FacultyID { get; set; }
        [ForeignKey("FacultyID")]
        public Faculty? Faculty { get; set; }


    }
}