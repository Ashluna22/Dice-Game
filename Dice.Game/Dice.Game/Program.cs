using System;


namespace Dice.Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            Random random = new Random();

            Console.WriteLine("Hello, please enter the number of sides for a pair of dice:");
            int sideDice = int.Parse(Console.ReadLine());

            while (continueProgram)
            {
                Console.WriteLine("Press Enter to roll the dice.");
                Console.ReadKey();

                int firstDice = random.Next(1, sideDice + 1);
                int secondDice = random.Next(1, sideDice + 1);
                int total = firstDice + secondDice;

                Console.WriteLine($"You rolled a {firstDice} and a {secondDice}. Total: {total}");

                if (sideDice == 6)
                {
                    if (firstDice == 1 && secondDice == 1)
                    {
                        Console.WriteLine("Woah, those be Snake Eyes!");
                    }
                    else if ((firstDice == 1 && secondDice == 2) || (firstDice == 2 && secondDice == 1))
                    {
                        Console.WriteLine("Ace Deuce!");
                    }
                    else if (firstDice == 6 && secondDice == 6)
                    {
                        Console.WriteLine("Box Cars!");
                    }
                    else if (total == 7 || total == 11)
                    {
                        Console.WriteLine("Win!");
                    }
                    else if (total == 2 || total == 3 || total == 12)
                    {
                        Console.WriteLine("Craps!");
                    }
                }

                Console.WriteLine("Would you like to roll the dice again? (y/n)");
                string response = Console.ReadLine().ToLower();

                if (response != "y")
                {
                    continueProgram = false;
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}
    

