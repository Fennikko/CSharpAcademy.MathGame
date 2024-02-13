namespace MathGame;
using Models;
public class Helpers
{
    public static string GetName()
    {
        Console.Write("Please Enter your name: ");
        var name = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cannot be blank, please enter your name");
            name = Console.ReadLine();
        }
        return name;
    }
}