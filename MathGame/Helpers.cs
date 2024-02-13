namespace MathGame;
using Models;
public class Helpers
{
    public static List<Game> Games = 
    [
        //new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
        //new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
        //new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
        //new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
        //new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
        //new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
        //new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
        //new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
        //new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
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
        var historyRunning = true;

        do
        {
            Console.Clear();
            Console.WriteLine(@"What game history would you like to view? Please choose from the options below: 
A - Addition
S - Subtraction
M - Multiplication
D - Division
E - Show Everything
Q - Quit to Main Menu");
            Console.WriteLine("-------------------------------------------------------");
            var historySelection = Console.ReadLine()?.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(historySelection))
            {
                Console.WriteLine("Invalid selection, press any key to try again");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            switch (historySelection)
            {
                case "A":
                    var additionHistory = Games.Where(g => g.Type == GameType.Addition).OrderByDescending(g => g.Score);
                    foreach (var game in additionHistory)
                    {
                        Console.WriteLine($"{game.Date} - {game.Type} - {game.Score}pts");
                    }
                    Console.WriteLine("Press any key to return to the history menu");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "S":
                    var subtractionHistory = Games.Where(g => g.Type == GameType.Subtraction).OrderByDescending(g => g.Score);
                    foreach (var game in subtractionHistory)
                    {
                        Console.WriteLine($"{game.Date} - {game.Type} - {game.Score}pts");
                    }
                    Console.WriteLine("Press any key to return to the history menu");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "M":
                    var multiplicationHistory = Games.Where(g => g.Type == GameType.Multiplication).OrderByDescending(g => g.Score);
                    foreach (var game in multiplicationHistory)
                    {
                        Console.WriteLine($"{game.Date} - {game.Type} - {game.Score}pts");
                    }
                    Console.WriteLine("Press any key to return to the history menu");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "D":
                    var divisionHistory = Games.Where(g => g.Type == GameType.Division).OrderByDescending(g => g.Score);
                    foreach (var game in divisionHistory)
                    {
                        Console.WriteLine($"{game.Date} - {game.Type} - {game.Score}pts");
                    }
                    Console.WriteLine("Press any key to return to the history menu");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "E":
                    var allGameHistory = Games.OrderBy(g => g.Type).ThenByDescending(g => g.Score);
                    foreach (var game in allGameHistory)
                    {
                        Console.WriteLine($"{game.Date} - {game.Type} - {game.Score}pts");
                    }

                    Console.WriteLine("Press any key to return to the history menu");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "Q":
                    historyRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid Selection, press any key to return to the history menu");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (historyRunning);
    }
}