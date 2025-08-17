public class Factorial
{
    public void Face()
    {
        Console.WriteLine("Enter a number for the factorial");
        int num = int.Parse(Console.ReadLine());
        int result = 1;
        int fact = 1;
        for (int i = num; i <= 1; i--)
        {
            result = num * i;
            
            }
            Console.WriteLine(result);
        
    }
}