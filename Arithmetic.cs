using System;

class Arithmetic
{
    static void Main()
    {
        int num1, num2;

        Console.Write("Enter first integer: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second integer: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Results:");
        Console.WriteLine("Addition: " + (num1 + num2));
        Console.WriteLine("Subtraction: " + (num1 - num2));
        Console.WriteLine("Multiplication: " + (num1 * num2));

        if (num2 != 0)
        {
            Console.WriteLine("Division: " + ((float)num1 / num2));
            Console.WriteLine("Modulus: " + (num1 % num2));
        }
        else
        {
            Console.WriteLine("Division and modulus by zero are not allowed.");
        }
    }
}
