
namespace NewApp.Models
{
    public class Employee
    {
        public string MaNhanVien { get; set; } 
        public string TenNhanVien { get; set; } 
        public int Tuoi { get; set; }   
        public int Luong { get; set; }  
        public int HeSoLuong { get; set; }
        public int TroCap { get; set; }

        public void Input()
        {
            try{
                System.Console.Write("Ma Nhan Vien : ");
                MaNhanVien = Console.ReadLine();
            }catch(Exception ex)
            {
                System.Console.WriteLine("Co ngoai le xay ra");
            }
            
            System.Console.Write("Ten Nhan Vien : ");
            TenNhanVien = Console.ReadLine();
            
        try{
            System.Console.Write("Tuoi : ");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            
            System.Console.Write("Luong : ");
            Luong = Convert.ToInt32(Console.ReadLine());
        }catch(Exception ex)
        {
            System.Console.WriteLine("Co ngoai le xay ra");
        }
            
        }

        public void Output()
        {
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine(MaNhanVien + "-" + TenNhanVien + "-" + Tuoi + "-" + Luong + "USD");

        }
    }
}