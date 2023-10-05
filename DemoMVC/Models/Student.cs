using System.Collections;
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
            try{
                System.Console.Write("Student ID : ");
                StudentID = Console.ReadLine();
            }catch(Exception ex)
            {
                System.Console.WriteLine("Co ngoai le xay ra!");
            }
            
            System.Console.Write("FullName : ");
            FullName = Console.ReadLine();
            
            System.Console.Write("Address : ");
            Address = Console.ReadLine();
            
            try{
                System.Console.Write("Age : ");
                Age = Convert.ToInt32(Console.ReadLine());
            }catch(Exception ex)
            {
                System.Console.WriteLine("co ngoai le xay ra !");
            }
            
        }

        public void Output()
        {
            System.Console.WriteLine("StudentID: "+ StudentID +" - "+"FullName: "+ FullName +" - "+"Address: "+ Address +" - "+"Age: "+ Age +"Tuoi");
        }

        
    }
}