﻿namespace MathGame;
using Models;
public class GameEngine
{
    public static void AdditionGame(string message)
    {
        var random = new Random();
        var score = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var firstNumber = random.Next(1, 9);
            var secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} + {secondNumber}");
            var result = Console.ReadLine();


                result = Helpers.ValidateResult(result);
                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("That is correct! Press any key to continue");
                    Console.ReadKey();
                    score++;
                }
                else
                {
                    Console.WriteLine("That is incorrect... Press any key to continue");
                    Console.ReadKey();
                }
            if(i != 4) continue;
            Console.WriteLine($"Game Over! Your score was: {score}pts. Press any key to return to the main menu.");
            Console.ReadKey();
        }
        Helpers.AddToHistory(score, GameType.Addition);
    }

    public static void SubtractionGame(string message)
    {
        var random = new Random();
        var score = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var firstNumber = random.Next(1, 9);
            var secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} - {secondNumber}");
            var result = Console.ReadLine();


                result = Helpers.ValidateResult(result);
                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("That is correct! Press any key to continue");
                    Console.ReadKey();
                    score++;
                }
                else
                {
                    Console.WriteLine("That is incorrect... Press any key to continue");
                    Console.ReadKey();
                }
            
            if (i != 4) continue;
            Console.WriteLine($"Game Over! Your score was: {score}pts. Press any key to return to the main menu.");
            Console.ReadKey();
        }
        Helpers.AddToHistory(score, GameType.Subtraction);
    }

    public static void MultiplicationGame(string message)
    {
        var random = new Random();
        var score = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var firstNumber = random.Next(1, 9);
            var secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} * {secondNumber}");
            var result = Console.ReadLine();


                result = Helpers.ValidateResult(result);
                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("That is correct! Press any key to continue");
                    Console.ReadKey();
                    score++;
                }
                else
                {
                    Console.WriteLine("That is incorrect... Press any key to continue");
                    Console.ReadKey();
                }
            
            if (i != 4) continue;
            Console.WriteLine($"Game Over! Your score was: {score}pts. Press any key to return to the main menu.");
            Console.ReadKey();
        }
        Helpers.AddToHistory(score,GameType.Multiplication);
    }

    public static void DivisionGame(string message)
    {
        var score = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var divisionNumbers = Helpers.GetDivisionNumbers();
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == firstNumber / secondNumber)
            {
                Console.WriteLine("That is correct! Press any key to continue.");
                Console.ReadKey();
                score++;
            }
            else
            {
                Console.WriteLine("That is incorrect... Press any key to continue.");
                Console.ReadKey();
            }
            if (i != 4) continue;
            Console.WriteLine($"Game Over! Your score was: {score}pts. Press any key to return to the Main Menu");
            Console.ReadKey();
        }
        Helpers.AddToHistory(score, GameType.Division);
    }
    
}