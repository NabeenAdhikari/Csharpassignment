﻿using System;
using MyApp;

class Program
{
    static void Main()
    {
        // --- Arithmetic Operations ---
        Console.WriteLine("=== Arithmetic Operations ===");
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition: " + Arithmetic.Add(a, b));
        Console.WriteLine("Subtraction: " + Arithmetic.Subtract(a, b));
        Console.WriteLine("Multiplication: " + Arithmetic.Multiply(a, b));
        Console.WriteLine("Division: " + Arithmetic.Divide(a, b));
        Console.WriteLine("Modulus: " + Arithmetic.Modulus(a, b));

        // --- Area of Rectangle ---
        Console.WriteLine("\n=== Area and Perimeter of Rectangle ===");
        Console.Write("Enter length: ");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter breadth: ");
        int breadth = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Area: " + Area.Areas(length, breadth));
        Console.WriteLine("Perimeter: " + Area.Perimeter(length, breadth));

        Vote xyz = new Vote();
        xyz.Vots();

        Comparison comparison = new Comparison();
        comparison.Com();
    }
}


