using System;

namespace PigDiceGameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int totalScore = 0;
                int totalMove = 0;
                while (true)
                {
                    totalMove++;
                    int currentScore = RollDice();
                    Console.WriteLine("Current Score Will be : " + currentScore);
                    if (currentScore == 1)
                    {
                        Console.WriteLine("Total Score Will be : " + totalScore);
                        continue;
                    }
                    else if(currentScore>=2 && currentScore <= 6)
                    {
                        Console.Write("Please Enter 'r' for Roll Again or 'h' for Hold : ");
                        string playerChoice=Console.ReadLine();
                        if (playerChoice == "r")
                        {
                            Console.WriteLine("Total Score Will be : " + totalScore);
                            continue; 
                        }
                        else if (playerChoice == "h")
                        {
                            totalScore += currentScore;
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine("Total Score Will be : " + totalScore);
                    if(totalScore>=20)
                    {
                        Console.WriteLine("You are Win. On Total {0} Number of Move.",totalMove);
                        break;
                    }
                }
                Console.WriteLine("|-----------------------------------------------------------------------------------------|");
                Console.Write("Please Enter Your Choice if Play Again (Yes) or for Not Playing (No) : ");
                string choice = Console.ReadLine();
                if (choice == "No")
                {
                    break;
                }
            }
        }


        private static int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
