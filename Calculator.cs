public class Calculator
{
    public void Calc()
    {
        Console.WriteLine("Enter first number");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second number");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the operation to be perform'+", '-', '*', '/');
        Char opr = Char.Parse(Console.ReadLine());
        double result = 0;
        switch (opr)
        {
            case '+':
                result = a + b;
                break;
            case '-':
                result = a - b;
                break;
            case '*':
                result = a * b;
                break;
            case '/':
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by Zero");
                    break;
                }
                result = a / b;
                break;
            default:
                Console.WriteLine("invalid");
                break;
        }
        Console.WriteLine(result);
    }
}