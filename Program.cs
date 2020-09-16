using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace rock_paper_scissors_0912020
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            bool playAgain = true;
            bool isValid = false;
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 10);
            {


                Console.WriteLine("you can play 1 - 10 rounds how many do you want to play");
                var input = Console.ReadLine();
                isValid = int.TryParse(input, out int rounds);
                if (!isValid || rounds < 1 || rounds > 10)
                    Console.WriteLine("Please try a number within range of 1 - 10");
                while (playAgain)
                {
                    int scorePlayer = 0;
                    int scoreCPU = 0;
                    int scoreTie = 0;
                    while (scorePlayer < 1 && scoreCPU < 1 && scoreTie < 1)
                    {
                        Console.Write("Please pick between Rock, Paper or Scissors: ");
                        inputPlayer = Console.ReadLine();
                        Random rnd = new Random();
                        randomInt = rnd.Next(1, 4);
                        switch (randomInt)
                        {
                            case 1:
                                inputCPU = "Rock";
                                Console.WriteLine("Computer took Rock");
                                if (inputPlayer == "Rock")
                                {
                                    Console.WriteLine("Tied\n\n");
                                    scoreTie++;
                                }
                                else if (inputPlayer == "Paper")
                                {
                                    Console.WriteLine("Player wins!!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "Scissors")
                                {
                                    Console.WriteLine("CPU crushed player!!\n\n");
                                    scoreCPU++;
                                }
                                break;
                            case 2:
                                inputCPU = "Paper";
                                Console.WriteLine("Computer chose Paper");
                                if (inputPlayer == "Paper")
                                {
                                    Console.WriteLine("This sucks we have a Draw!!\n\n");
                                    scoreTie++;
                                }
                                else if (inputPlayer == "Rock")
                                {
                                    Console.WriteLine("CPU won that round\n\n");
                                    scoreCPU++;
                                }
                                else if (inputPlayer == "Scissors")
                                {
                                    Console.WriteLine("player cut CPU!!\n\n");
                                    scorePlayer++;
                                }
                                break;
                            case 3:
                                inputCPU = "Scissors";
                                Console.WriteLine("Computer took the scissors");
                                if (inputPlayer == "Scissors")
                                {
                                    Console.WriteLine("Stupid DRAW!!!\n\n");
                                    scoreTie++;
                                }
                                else if (inputPlayer == "Rock")
                                {
                                    Console.WriteLine("Player wins!!\n\n");
                                    scorePlayer++;
                                }
                                if (inputPlayer == "Paper")
                                {
                                    Console.WriteLine("Computer Wins!!\n\n");
                                    scoreCPU++;
                                }
                                break;
                            default:
                                Console.WriteLine("I do not understand that command");
                                break;
                        }
                        Console.WriteLine("\n\nSCORES: \tPLAYER:\t{0}\tCPU:\t{1}\tTie:{0}", scorePlayer, scoreCPU, scoreTie);
                    }
                    if (scorePlayer == 1)
                    {
                        Console.WriteLine("Player Won!\n\n");
                    }
                    else if (scoreCPU == 1)
                    {
                        Console.WriteLine("CPU won");
                    }
                    else if (scoreTie == 1)
                    {
                        Console.WriteLine("Tied in a knot do you want to play again?");
                    }
                    Console.WriteLine("Do you want to play again???(y/n)");
                    string loop = Console.ReadLine();
                    playAgain = (loop == "y");
                    if (!playAgain)
                    {
                        Console.WriteLine("Thank you for Playing!");
                    }
                }
            }
        }
    }
}