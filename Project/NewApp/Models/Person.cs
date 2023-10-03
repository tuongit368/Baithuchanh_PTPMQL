using System.Dynamic;
using System;
namespace NewApp.Models
{
    public class Person
    {

        // Thuoc tinh
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        // Ket thuc thuoc tinh 

        // Phuong Thuc 
    public void Input()
        {
            System.Console.Write("FullName = ");
            FullName = Console.ReadLine();

            System.Console.Write("Address = ");
            Address = Console.ReadLine();

            System.Console.Write("Age = ");
            try
            {
                Age = Convert.ToInt16(Console.ReadLine());
            }catch(Exception ex)
            {
                Age = 0;
            }
        }

    public void Output()
        {
            System.Console.WriteLine("FullName = {0} / Address = {1} / Age = {2} ", FullName, Address, Age);
        }

    // public void AddArray()
    // {
    //     int n;
    //     do {
    //         try{
    //             System.Console.Write("n = ");
    //             n = Convert.ToInt32(Console.ReadLine());

    //         }
    //         catch {
    //             n = 0;
    //         }
    //     }while (n<1);

    //     // // Khoi tao array
    //     // // KDL[] name = new KDL [KT];
    //     Person[] A = new Person[n];
    //     // Add cac phan tu vao array
    //     // gan gia tri cho phan tu thu 2
    //     for(int i = 0; i < A.Length; i++ )
    //     {
    //         System.Console.WriteLine("A[{0}]: ", i);
    //         Person ps = new Person();
    //         ps.Input();
    //         A[i] = ps;
    //     }

    //     // HIen thi cac phan tu trong array
    //     System.Console.WriteLine("------------------------------");
    //     for(int i = 0; i < A.Length; i++)
    //     {
    //         System.Console.WriteLine(i + " FullName: " + A[i].FullName + " Address: " + A[i].Address + " Age: " + A[i].Age );
    //     }
    // }

    // public void EditArray()
    // {
    //      // Sua Thong Tin 

        
    //     for(int i = 0; i < A.Length; i++)
    //     {   
            

    //         if ( A[i].FullName == fullname){
                
    //             System.Console.Write("FullName = ");
    //             A[i].FullName = Console.ReadLine();

    //             System.Console.Write("Address = ");
    //             A[i].Address = Console.ReadLine();

    //             System.Console.Write("Age = ");
    //             try
    //             {
    //                 A[i].Age = Convert.ToInt16(Console.ReadLine());
    //             }catch(Exception ex)
    //             {
    //                 A[i].Age = 0;
    //             }

    //         }
    //     }

    //     // Ket thuc sua thong tin
        

    //     // Hien thi thong tin vua sua 

    //      System.Console.WriteLine("------------------------------");
    //     for(int i = 0; i < A.Length; i++)
    //     {
    //         System.Console.WriteLine(i + " FullName: " + A[i].FullName + " Address: " + A[i].Address + " Age: " + A[i].Age );
    //     }

    //     return;
    //     // ket thuc 
    // }
        // Ket thuc phuong thuc
    }

   
}