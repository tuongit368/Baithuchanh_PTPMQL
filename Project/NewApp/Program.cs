using System.Security.Cryptography;
using System.Collections.Specialized;
using System;
// using System.IO.Pipes;
// using System;

// class Student
// {
//     public int StudentId { get; set; }
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public Student(int studentId, string name, int age)
//     {
//         StudentId = studentId;
//         Name = name;
//         Age = age;
//     }

//     public void DisplayInfo()
//     {
//         Console.WriteLine($"Mã SV: {StudentId}, Tên: {Name}, Tuổi: {Age}");
//     }

//     public static Student[] AddStudent(Student[] students, Student newStudent)
//     {
//         if (students == null)
//         {
//             students = new Student[1];
//             students[0] = newStudent;
//         }
//         else
//         {
//             Array.Resize(ref students, students.Length + 1);
//             students[students.Length - 1] = newStudent;
//         }
//         return students;
//     }

//     public static void EditStudentInfo(Student[] students, int studentId)
//     {
//         for (int i = 0; i < students.Length; i++)
//         {
//             if (students[i].StudentId == studentId)
//             {
//                 Console.WriteLine($"Nhập thông tin mới cho sinh viên có mã {studentId}:");
//                 Console.Write("Tên: ");
//                 students[i].Name = Console.ReadLine();
//                 Console.Write("Tuổi: ");
//                 students[i].Age = int.Parse(Console.ReadLine());
//                 return;
//             }
//         }
//         Console.WriteLine($"Không tìm thấy sinh viên có mã {studentId}.");
//     }

//     public static Student[] RemoveStudent(Student[] students, int studentId)
//     {
//         for (int i = 0; i < students.Length; i++)
//         {
//             if (students[i].StudentId == studentId)
//             {
//                 for (int j = i; j < students.Length - 1; j++)
//                 {
//                     students[j] = students[j + 1];
//                 }
//                 Array.Resize(ref students, students.Length - 1);
//                 Console.WriteLine($"Sinh viên có mã {studentId} đã được xoá.");
//                 return students;
//             }
//         }
//         Console.WriteLine($"Không tìm thấy sinh viên có mã {studentId} để xoá.");
//         return students;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Student[] students = null;

//         while (true)
//         {
//             Console.WriteLine("Chọn tác vụ (1: Thêm mới, 2: Hiển thị, 3: Sửa thông tin, 4: Xoá, 0: Kết thúc):");
//             int choice = int.Parse(Console.ReadLine());

//             switch (choice)
//             {
//                 case 0:
//                     Environment.Exit(0);
//                     break;

//                 case 1:
//                     Console.Write("Mã SV: ");
//                     int studentId = int.Parse(Console.ReadLine());
//                     Console.Write("Tên: ");
//                     string name = Console.ReadLine();
//                     Console.Write("Tuổi: ");
//                     int age = int.Parse(Console.ReadLine());

//                     Student newStudent = new Student(studentId, name, age);
//                     students = Student.AddStudent(students, newStudent);
//                     Console.WriteLine($"Đã thêm mới sinh viên có mã {studentId}.");
//                     break;

//                 case 2:
//                     Console.WriteLine("Danh sách sinh viên:");
//                     if (students != null)
//                     {
//                         foreach (Student student in students)
//                         {
//                             student.DisplayInfo();
//                         }
//                     }
//                     else
//                     {
//                         Console.WriteLine("Danh sách trống.");
//                     }
//                     break;

//                 case 3:
//                     Console.Write("Nhập mã SV cần sửa: ");
//                     int editStudentId = int.Parse(Console.ReadLine());
//                     Student.EditStudentInfo(students, editStudentId);
//                     break;

//                 case 4:
//                     Console.Write("Nhập mã SV cần xoá: ");
//                     int deleteStudentId = int.Parse(Console.ReadLine());
//                     students = Student.RemoveStudent(students, deleteStudentId);
//                     break;
//             }
//         }
//     }
// }
using System.Collections;
using NewApp.Models;
internal class Program
{
    private static void Main(string[] args)
    {
    //     ArrayList personList = new ArrayList();
    //     int n;
    //     do
    //     {
    //         try
    //         {
    //             System.Console.Write("n = ");
    //             n = Convert.ToInt32(Console.ReadLine());

    //         }
    //         catch
    //         {
    //             n = 0;
    //         }
    //     } while (n < 1);

    //     // Them n phan tu vao list

    //     for (int i = 0; i < n; i++)
    //     {
    //         System.Console.WriteLine($"[{i}]");
    //         Person ps = new Person();
    //         ps.Input();
    //         personList.Add(ps);
    //     }

    //     // ket thuc

    //     // hien thi danh sach  --- -- cach 1 - -- - 

    //     // for(int i = 0; i<n; i++)
    //     // {
    //     //     // lay ra phan tu thu i trong arrlist va ep kieu person
    //     //     Person ps = (Person) personList[i];

    //     //     // goi toi phuong thuc hien thi
    //     //     ps.Output();

    //     // }


    //     System.Console.WriteLine("----------------------------------");
    //     // Hien thi danh sach -- - -- - Cach 2 - - -- -- -
    //     foreach(Person ps in personList)
    //     {
    //         // goi toi phuong thuc hien thi
    //         ps.Output();
    //     }


    //     System.Console.WriteLine("------------------------------------");

    //     // Sua thong tin trong phan tu cua list

    //     string fullname = null;
    //     System.Console.WriteLine($"Nhap ten nguoi hoc sinh can thay doi: {fullname}");
    //     fullname = Console.ReadLine();

    //     for(int i = 0; i < personList.Count; i++)
    //     {   
    //         Person ps = (Person) personList[i];

    //         if ( ps.FullName == fullname){

    //             ps.Input();
    //             break;

    //         }else
    //         {
    //             System.Console.WriteLine("Khong co thong tin!");
    //             break;
    //         }

    //     }

    //     System.Console.WriteLine("---------------------------");

    //     foreach(Person ps in personList)
    //     {
    //         // goi toi phuong thuc hien thi
    //         ps.Output();
    //     }

    //     System.Console.WriteLine("----------------------------");

    //     // Xoa 1 phan tu trong list

    //     System.Console.WriteLine("Nhap ten nguoi can xoa: ");
    //     fullname = Console.ReadLine();
        
    //     for(int i=0; i < personList.Count; i++ )
    //     {
    //         Person ps = (Person) personList[i];
    //         if(ps.FullName == fullname)
    //         {
    //             personList.RemoveAt(i);
    //             System.Console.WriteLine($"da xoa nguoi co ten la: {fullname}");
    //             break;
    //         }
    //     }


    //     System.Console.WriteLine("----------------------------");
    //     // hien thi danh sach list

    //      foreach(Person ps in personList)
    //     {
    //         // goi toi phuong thuc hien thi
    //         ps.Output();
    //     }







        // khai bao mang StudentList
        ArrayList StudentList = new ArrayList();
        
        int n;

        do {
            try{
                System.Console.WriteLine("Nhap so hoc sinh: ");
                n = Int16.Parse(Console.ReadLine());
            }catch
            {
                n = 0;
            }
            
        }while ( n < 1);

       // Nhap Thong Tin Hoc sinh

        for ( int i = 0; i < n; i++)
        {
            System.Console.WriteLine($"--------------{i}--------------");
            Student std = new Student();
            std.Input();
            StudentList.Add(std);

        }

        // Hien thi danh sach hoc sinh
        System.Console.WriteLine("---------------THONG TIN HOC SINH---------------");

        foreach(Student std in StudentList)
        {   
            std.Output();
        }

        // Sua thong tin hoc sinh = Id

        System.Console.WriteLine("------------------SUA THONG TIN HOC SINH------------------");

        string id = null;
        System.Console.WriteLine("Nhap StudentID can sua: ");
        id = Console.ReadLine();
        
        for(int i = 0; i < StudentList.Count; i++)
        { 
            Student std = (Student) StudentList[i];

            if(std.StudentID == id)
            {
                std.Input();
                break;
            }else{
                System.Console.WriteLine(">> Student ID khong ton tai! <<");
                break;

            }

        }

        // Hien thi danh sach hoc sinh
        System.Console.WriteLine("---------------THONG TIN HOC SINH---------------");

        foreach(Student std in StudentList)
        {   
            std.Output();
        }

        // Xoa hoc sinh theo ID 

        System.Console.WriteLine("-------------------XOA HOC SINH--------------------");

        System.Console.WriteLine("Nhap StudentID can xoa: ");
        id = Console.ReadLine();

        for(int i = 0; i < StudentList.Count; i++)
        {
            Student std = (Student) StudentList[i];
            if(std.StudentID == id)
            {
                StudentList.RemoveAt(i);
                System.Console.WriteLine($">> Xoa Thanh Cong StudentID: {id} !");
                break;

            }
        }

        // Hien thi danh sach hoc sinh
        System.Console.WriteLine("---------------THONG TIN HOC SINH----------a------");

        foreach(Student std in StudentList)
        {   
            std.Output();
        }

    }
}