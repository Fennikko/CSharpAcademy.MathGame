using System.Numerics;

namespace MathGame;
using Models;

public class Menu
{
    public void ShowMenu(string name, DateTime date)
    {
        Console.WriteLine($"Hello {name}, it is {date}. Welcome to the Math Game!");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Press any key to show the menu");
        Console.ReadKey();
        Console.Clear();

        var gameRunning = true;

        do
        {
            Console.WriteLine(@"What game would you like to play? Please choose from the options below: 
V - View game history
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit");
            Console.WriteLine("-------------------------------------------------------");
            var gameSelection = Console.ReadLine().Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(gameSelection))
            {
                Console.WriteLine("Invalid selection, press any key to try again");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            switch (gameSelection)
            {
                case "V":
                    Console.WriteLine("Game history");
                    Console.Clear();
                    break;
                case "A":
                    Console.WriteLine("AdditionGame");
                    Console.Clear();
                    break;
                case "S":
                    Console.WriteLine("Subtraction Game");
                    Console.Clear();
                    break;
                case "M":
                    Console.WriteLine("Multiplication Game");
                    Console.Clear();
                    break;
                case "D":
                    Console.WriteLine("Division Game");
                    Console.Clear();
                    break;
                case "Q":
                    Console.WriteLine("Thank you for playing!");
                    gameRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid Selection, press any key to return to the main menu");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (gameRunning);
    }
}