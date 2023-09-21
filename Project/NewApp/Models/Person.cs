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
            Age = Convert.ToInt16(Console.ReadLine());
        }

    public void Output()
        {
            System.Console.WriteLine("FullName = {0} / Address = {1} / Age = {2}", FullName, Address, Age);
        }


        // Ket thuc phuong thuc
    }

   
}