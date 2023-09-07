// using System.Dynamic;
// using System.IO;
// using System;
// using System.Security.AccessControl;
// namespace NewApp.Models
// {
//     public class Employee
//     {
//         // Khai bao thuoc tinh

//         public int MaNhanVien { get; set; }
//         public string TenNhanVien { get; set; } 
//         public int Tuoi { get; set; }
//         public float Luong { get; set; }

//         // Ket thuc khai bao thuoc tinh

//     // Khai bao phuong thuc


//         // phuong thuc nhap thong tin
//     public void Input()
//     {
//         System.Console.WriteLine("Nhap Ma Nhan Vien : ");
//         MaNhanVien =  Convert.ToInt16(Console.ReadLine()); 

//         System.Console.WriteLine("Nhap Ten Nhan Vien : ");
//         TenNhanVien = Console.ReadLine();

//         System.Console.WriteLine("Nhap Tuoi : ");
//         Tuoi = Convert.ToInt16(Console.ReadLine()); 

//         System.Console.WriteLine("Nhap Luong : ");
//         Luong =  Convert.ToInt16(Console.ReadLine()); 
//     }   
//         // Ket thuc phuong thuc nhap thong tin

//         // Phuong thuc in ra man hinh
//     public void Output()
//     {
//         System.Console.WriteLine("Ma Nhan Vien: {0} - Ten: {1} - Tuoi: {2} - Luong: {3}", MaNhanVien, TenNhanVien, Tuoi, Luong);
//     }


//         // ket thuc phuong thuc in ra man hinh

//     // Ket thuc khai bao phuong thuc

//     // public static void main(string[] args)
//     // {
//     //     Employee nv1 = new Employee();

//     //     nv1.MaNhanVien = 2121050;
//     //     nv1.TenNhanVien = "Viet";
//     //     nv1.Tuoi = 20;


//     //     // nv1.Input();
//     //     nv1.Output();

//     // }
//     }
// }