public class Binary
{
    public void Bin()
    {
        int a = 0;
        int basee;
        double result = 0;
        Console.WriteLine("Enter the binary number");
        int bin = int.Parse(Console.ReadLine());
        while (bin > 0)
        {
            basee = bin % 10;
            result = basee * Math.Pow(2, a) + result;
            a++;
            bin = bin / 10;
        }
        
        Console.WriteLine(result);

    }
}