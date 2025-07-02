using System;

class Area
{
    static void Main()
    {
        double length, breadth;

        Console.Write("Enter the length of the rectangle: ");
        length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the breadth of the rectangle: ");
        breadth = Convert.ToDouble(Console.ReadLine());

        double area = length * breadth;
        double perimeter = 2 * (length + breadth);

        Console.WriteLine("\nResults:");
        Console.WriteLine("Area of rectangle: " + area);
        Console.WriteLine("Perimeter of rectangle: " + perimeter);
    }
}
