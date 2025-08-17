public class Patterns
{
    public void Patt()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 5; j >= i; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}