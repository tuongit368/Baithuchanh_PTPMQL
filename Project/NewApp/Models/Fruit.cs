using System.Dynamic;
using System;
namespace NewApp.Models
{
    public class Fruit
    {
        public string HangQua { get; set; } 
        public string NameFruit { get; set; }   
        public float CanNang { get; set; }  

        public void Input()
        {
            System.Console.WriteLine("Nhap Hang Qua: ");
            HangQua = Console.ReadLine();
            
            System.Console.WriteLine("Nhap Ten Qua: ");
            NameFruit = Console.ReadLine();
            
            try{
                System.Console.WriteLine("Nhap Can Nang: ");
                CanNang = Convert.ToSingle(Console.ReadLine());
            }catch(Exception ex)
            {
                System.Console.WriteLine("co ngoai le xay ra!");
            }
            
        }

        public void Output()
        {
            System.Console.WriteLine("Hang Qua: " + HangQua +" - "+ "Ten Qua: " + NameFruit +" - "+ "Can Nang: "  + CanNang + "Kg" );
        }

    }
}