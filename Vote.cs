public class Vote
{
    public void Vots()
    {
        Console.WriteLine("enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age >= 18)
        {
            Console.WriteLine("you are eligible to vote");

        }
        else
        {
            Console.WriteLine("You arenot eligible to vote");
        }
    }
}