using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Admin
{
    public void Input()
    {
        Console.WriteLine("Enter a username:");
        String username = (Console.ReadLine());
        Console.WriteLine("Enter a password:");
        int password = int.Parse(Console.ReadLine());

        if (username == "admin" && password == 123)
        {
            Console.WriteLine("Welcome to admin panel;");
        }

        else
        {
            Console.WriteLine("welcome to userpanel");
        }
        {
        
    }
}
            }
