using System;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Two glitches, You can override Your oponents placement with yours, and O can go one more time if x wins.
            
            bool play = false;
            Console.WriteLine("Would you like you play a TicTacToe? y/n");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                play = true;
            }
            while (play == true)
            {
                bool gameover = false;

                string topleft = "1";
                string topmiddle = "2";
                string topright = "3";

                string midleft = "4";
                string midmiddle = "5";
                string midright = "6";

                string botleft = "7";
                string botmiddle = "8";
                string botright = "9";

                while (gameover == false)
                {
                    Console.WriteLine($"{topleft}|{topmiddle}|{topright}");
                    Console.WriteLine($"{midleft}|{midmiddle}|{midright}");
                    Console.WriteLine($"{botleft}|{botmiddle}|{botright}");
                    Console.WriteLine();
                    Console.WriteLine("You are X");
                    Console.WriteLine("Where would you like to go? Choose a number");
                    answer = Console.ReadLine();
                    Console.WriteLine();
                    if (answer == "1")
                    {
                        topleft = "X";
                    }
                    else if (answer == "2")
                    {
                        topmiddle = "X";
                    }
                    else if (answer == "3")
                    {
                        topright = "X";
                    }
                    else if (answer == "4")
                    {
                        midleft = "X";
                    }
                    else if (answer == "5")
                    {
                        midmiddle = "X";
                    }
                    else if (answer == "6")
                    {
                        midright = "X";
                    }
                    else if (answer == "7")
                    {
                        botleft = "X";
                    }
                    else if (answer == "8")
                    {
                        botmiddle = "X";
                    }
                    else if (answer == "9")
                    {
                        botright = "X";
                    }
                    else
                    {
                        Console.WriteLine("Input Error, Skipping Turn...");
                    }
                    answer= "The cake is answer lie";

                    Console.WriteLine($"{topleft}|{topmiddle}|{topright}");
                    Console.WriteLine($"{midleft}|{midmiddle}|{midright}");
                    Console.WriteLine($"{botleft}|{botmiddle}|{botright}");
                    Console.WriteLine();
                    Console.WriteLine("You are O");
                    Console.WriteLine("Where would you like to go? Choose a number");
                    answer = Console.ReadLine();

                    if (answer == "1")
                    {
                        topleft = "O";
                    }
                    else if (answer == "2")
                    {
                        topmiddle = "O";
                    }
                    else if (answer == "3")
                    {
                        topright = "O";
                    }
                    else if (answer == "4")
                    {
                        midleft = "O";
                    }
                    else if (answer == "5")
                    {
                        midmiddle = "O";
                    }
                    else if (answer == "6")
                    {
                        midright = "O";
                    }
                    else if (answer == "7")
                    {
                        botleft = "O";
                    }
                    else if (answer == "8")
                    {
                        botmiddle = "O";
                    }
                    else if (answer == "9")
                    {
                        botright = "O";
                    }
                    else
                    {
                        Console.WriteLine("Input Error, Skipping Turn...");
                    }
                    answer= "The cake is answer lie";

                    if (topleft == "X" &&topmiddle == "X" &&topright == "X" || midleft == "X" &&midmiddle == "X" &&midright == "X" || botleft == "X" &&botmiddle == "X" &&botright == "X"  || topleft == "X" &&midleft == "X" &&botleft == "X"  || topmiddle == "X" &&midmiddle == "X" &&botmiddle == "X"  || topright == "X" &&midright == "X" &&botright == "X"  || topleft == "X" &&midmiddle == "X" &&botright == "X"  || topright == "X" &&midmiddle == "X" &&botright == "X" )
                    {
                        gameover = true;
                        Console.WriteLine("Good Job X, You Win");
                    } 
                    if (topleft == "O" &&topmiddle == "O" &&topright == "O" || midleft == "O" &&midmiddle == "O" &&midright == "O" || botleft == "O" &&botmiddle == "O" &&botright == "O"  || topleft == "O" &&midleft == "O" &&botleft == "O"  || topmiddle == "O" &&midmiddle == "O" &&botmiddle == "O"  || topright == "O" &&midright == "O" &&botright == "O"  || topleft == "O" &&midmiddle == "O" &&botright == "O"  || topright == "O" &&midmiddle == "O" &&botright == "O" )
                    {
                        gameover = true;
                        Console.WriteLine("Good Job O, You Win");
                    } 


                }
                Console.WriteLine("Would you like to play again? y/n");
                answer = Console.ReadLine();
                if (answer == "n")
                {
                    play = false;
                }
                else
                {
                    Console.WriteLine("Restarting...");
                    Console.WriteLine();
                }
            }  
        }
    }
}