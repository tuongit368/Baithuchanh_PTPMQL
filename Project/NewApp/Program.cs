using System.Runtime.ConstrainedExecution;
using System.Dynamic;
using System;
using NewApp.Models;
// khai bao kich thuoc cua array
int n;
do {
    try{
        System.Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());

    }
    catch {
        n = 0;
    }
}while (n<1);

// Khoi tao array
// KDL[] name = new KDL [KT];
Person[] A = new Person[n];
// Add cac phan tu vao array
// gan gia tri cho phan tu thu 2
for(int i = 0; i < A.Length; i++ )
{
    System.Console.WriteLine("A[{0}]: ", i);
    Person ps = new Person();
    ps.Input();
    A[i] = ps;
}

// HIen thi cac phan tu trong array
System.Console.WriteLine("------------------------------");
for(int i = 0; i < A.Length; i++)
{
    System.Console.WriteLine(i + " FullName: " + A[i].FullName + " Address: " + A[i].Address + " Age: " + A[i].Age );
}