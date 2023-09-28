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

            // Xử lý ngoại lệ
            try
            {
            Luong = Convert.ToInt32(Console.ReadLine());
            }catch(Exception ex)
            {
                Luong = 0;
            }
            // Kết thúc xử lý ngoại lệ
        }
        
        public void Output()
        {
            base.Output();
            System.Console.Write("/"+" Luong: "+Luong+" USD");
        }
    }
}