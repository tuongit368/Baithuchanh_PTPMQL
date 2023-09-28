namespace  NewApp.Models
{
    public class Student_kethua : Person
    {
        public string StudentCode { get; set; }
    public void Input()
    {
        base.Input();

        System.Console.Write("StudentCode: ");
        StudentCode = Console.ReadLine();
            
    }

    public void Output()
    {
        base.Output();

        System.Console.Write("/"+" StudentCode: "+StudentCode);
    }
    }

    
}