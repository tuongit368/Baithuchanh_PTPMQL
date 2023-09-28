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
int [] A = new int[n];
// Add cac phan tu vao array
// gan gia tri cho phan tu thu 2
for(int i = 0; i < A.Length; i++ )
{
    System.Console.Write("A[{0}] = ", i);
    A[i] = Convert.ToInt32(Console.ReadLine());
}

// HIen thi cac phan tu trong array
System.Console.WriteLine("------------------------------");
for(int i = 0; i < A.Length; i++)
{
    System.Console.Write("{0}\t",A[i]);
}