
using System;
using System.Security.AccessControl;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Vidu 5_c# 
// Console.WriteLine(6);
// int a = 9;
// Console.WriteLine("a = " + a);

// int a = 7;
// int b = 8;
// int c = a + b;

// Console.WriteLine("a = {0} ",a);
// Console.WriteLine("b = {0} ",b);
// Console.WriteLine("a + b = {0}  ",c);

// internal class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Nhap du lieu tu ban phim : ");
//         string str = Console.ReadLine();
//         Console.WriteLine("Du lieu vua moi nhap vao la : " + str);
//     }
// }

// internal class Program
// {
//     public static void Main (string[] args)
//     {
//        string name ="Dang Ngoc Tuong";
//        int age = 20;

//        Console.WriteLine ("Ten : {0}, Tuoi : {1}",name, age);
//     }
// }


public class Program
{       
    private static void Main(string[] args)
    {   

//      <- Nhập 2 số a, b ->

        //khai báo a, b (int)
        int a, b; 

        // Hiện thị ra màn hình 
        System.Console.Write("Nhap a : ");

        // Nhập a từ bàn phím
        a = Convert.ToInt32(Console.ReadLine());

        // Hiển thị ra màn hình 
        System.Console.Write("Nhap b : ");

        //Nhập b từ bàn phím

        b = Convert.ToInt32(Console.ReadLine());

//      <- Kết thúc nhập 2 số a, b ->

//      <- tính hiệu 2 số và in ra màn hình ->
        System.Console.WriteLine("-----------------------------");
        System.Console.WriteLine("{0} - {1} = {2}", a, b, a-b );

//      <- Kết thúc tính hiệu  2 số ->

//      <- Tính tích 2 số và in ra màn hình ->    

        System.Console.WriteLine("---------------------------------");
        System.Console.WriteLine("{0} * {1} = {2}", a, b, a*b);

//      <- Kết thúc tính tích 2 số ->

//      <- Tính chia lấy nguyên 2 số và in ra màn hình ->    

        System.Console.WriteLine("---------------------------------");
        System.Console.WriteLine("{0} / {1} = {2}", a, b, a/b);

//      <- Kết thúc tính chia lấy nguyên 2 số ->

//      <- Tính chia lấy dư 2 số và in ra màn hình ->    

        System.Console.WriteLine("---------------------------------");
        System.Console.WriteLine("{0} % {1} = {2}", a, b, a%b);

//      <- Kết thúc tính chia lấy dư 2 số ->
    }
}