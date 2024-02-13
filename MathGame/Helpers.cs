namespace MathGame;
using Models;
public class Helpers
{
    public static List<Game> Games = 
    [

    ];
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

    public static string ValidateResult(string? result)
    {
        while (string.IsNullOrWhiteSpace(result) || !Int32.TryParse(result, out _))
        {
            Console.WriteLine("Your answer needs to be an integer, please try again");
            result = Console.ReadLine();
        }

        return result;
    }

    public static int[] GetDivisionNumbers()
    {
        var random = new Random();
        var firstNumber = random.Next(1, 99);
        var secondNumber = random.Next(1, 99);
        var result = new int [2];

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1, 99);
            secondNumber = random.Next(1, 99);
        }

        result[0] = firstNumber;
        result[1] = secondNumber;
        return result;
    }

    public static void AddToHistory(int gameScore, GameType gameType)
    {
        Games.Add(new Game
        {
            Date = DateTime.Now,
            Score = gameScore,
            Type = gameType
        });
    }

    public static void PrintGames()
    {

    }
}