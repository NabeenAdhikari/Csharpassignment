public class Comparison
{
    public void Com()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("A is greater");
        }
        else if (b > a)
        {
            Console.WriteLine("B is greater");
        }
        else
        {
            Console.WriteLine("Both are equal");
        }
    }
}