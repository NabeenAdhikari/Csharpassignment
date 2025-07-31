using System;
using System.Diagnostics;
public class Grade
{
    public void Grades()
    {
        Console.WriteLine("Enter marks of subject 1");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter marks of subject 2");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter marks of subject 3");
        double c = double.Parse(Console.ReadLine());
        double average = (a + b + c) / 3;
        string grade = average switch
        {
            >= 90 => "grade A+",
            >= 75 => "grade A",
            >= 50 => "grade B",
            _ => "Fail"
        };
        Console.WriteLine("Your grade is :" + grade);
        

    }
}