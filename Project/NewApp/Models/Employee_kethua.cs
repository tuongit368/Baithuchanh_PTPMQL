using System;
namespace NewApp.Models
{
    public class Employee_kethua : Person
    {
        public int Luong { get; set; }

        public void Input()
        {
            base.Input();
            System.Console.Write("Luong: ");
            Luong = Convert.ToInt32(Console.ReadLine());
            
        }
        
        public void Output()
        {
            base.Output();
            System.Console.Write("/"+" Luong: "+Luong+"USD");
        }
    }
}