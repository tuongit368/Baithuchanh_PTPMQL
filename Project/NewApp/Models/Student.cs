
using System;
namespace NewApp.Models
{
    public class Student
    {
        public string StudentID { get; set; }   
        public string FullName  { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public void Input()
        {
            System.Console.Write("Student ID : ");
            StudentID = Console.ReadLine();
            
            System.Console.Write("FullNam : ");
            FullName = Console.ReadLine();
            
            System.Console.Write("Address : ");
            Address = Console.ReadLine();
            
            System.Console.Write("Age : ");
            Age = Convert.ToInt32(Console.ReadLine());
            
        }

        public void Output()
        {
            System.Console.WriteLine(StudentID +"-"+ FullName +"-"+ Address +"-"+ Age +"Tuoi");
        }
    }
}