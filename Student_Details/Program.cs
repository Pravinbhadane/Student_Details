// See https://aka.ms/new-console-template for more information
using Student_Details;

class Program
{
    static void Main()
    {
      
        Student student = new Student
        {
            RollNo = 15,
            Name = "Pravin Bhadane",
            Percentage = 85.5f
        };

        Console.WriteLine("Student Details:");
        Console.WriteLine($"Roll No: {student.RollNo}");
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Percentage: {student.Percentage}%");
    }
}