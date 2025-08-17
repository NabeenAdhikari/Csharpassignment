public class Guess
{
    public void Gu()
    {
        int guess=0;
        int attempt = 0;

        Random r = new Random();
        int num=r.Next(1,101);
        while (guess != num)
        {
            Console.WriteLine("Guess a number");
            guess = int.Parse(Console.ReadLine());
            if (guess < num)
            {
                Console.WriteLine("Low");
                attempt++;
            }
            else if (guess > num)
            {
                Console.WriteLine("High");
                attempt++;
            }
            else if (guess == num)
            {
                Console.WriteLine("Congrats you guess right in :" + attempt + "attempt");
            }
        }
    }
}