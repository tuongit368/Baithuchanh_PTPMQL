namespace DemoMVC.Models
{
    public class Employee : Person 
    {
        // bo sung them thuoc tinh
        public string EmployeeId { get; set; }
        public int Age { get; set; }
    }
}