﻿namespace High_Low_Number_Guessing_Game
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("This Game Will start by giving the User an opportunity " +
                "To Guess the Correct Number given by the Computer. You will only Win if you guess the correct number " +
                "that is not Too High(above) or Too Low(below) the computers selection.\n");

            const int MAX_GUESSES = 10;
            const int WITHIN_FIVE = 5;
            int equalsTwenty = Math.Abs(4 * WITHIN_FIVE);
            int equalsTen = Math.Abs(2 * WITHIN_FIVE);
            Random rnd = new Random();
            int computerGuess = rnd.Next(1, 101);
            Console.WriteLine("The Computer will enter a number guess.");
            Console.WriteLine("(The computers answer will be Displayed Once the User enters the correct guess.)");
            Console.WriteLine($"Your have {MAX_GUESSES} attempts to guess the secret number.");
            // test functionality of code guess with 
            Console.WriteLine(computerGuess);

            for (int j = 1; j <= MAX_GUESSES; ++j)
            {

                Console.WriteLine($"\n\nPlease enter a number guess.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                int userMinusCpuGuess = Math.Abs(userInput - computerGuess);
                bool userGreaterThanCpu = userInput > computerGuess;
                Console.WriteLine($"\n");


                if (userInput == computerGuess)
                {
                    Console.WriteLine("You've WON!!!! You guessed the correct number!!!");
                    Console.WriteLine($"\nYour correct guess of {userInput} WINS the Game!!!\n");
                    break;
                }
                if (j == MAX_GUESSES)
                {
                    Console.WriteLine($"\nMmm, Mmm, Better luck Next Game...\nYour guesses were above and below the computer guess of {computerGuess}.");
                    break;
                }
                if (userMinusCpuGuess >= equalsTwenty && userGreaterThanCpu)
                {
                    Console.WriteLine("You're not only above the computers guess but you're just sooo far away!!!");
                }
                else if (userMinusCpuGuess >= equalsTen && userGreaterThanCpu)
                {
                    Console.WriteLine($"\nThis is just terrible You're still above the computers guess by at least 10 or more numbers!!!\nYou can do better than that - Try Again!!!");

                }
                else if (userMinusCpuGuess >= WITHIN_FIVE && userGreaterThanCpu)
                {
                    Console.WriteLine($"You're getting closer just {WITHIN_FIVE} numbers or more above the CORRECT computer guess!");
                }
                else if (userMinusCpuGuess < WITHIN_FIVE)
                {
                    Console.WriteLine($"SO CLOSE!!!! You're Less then 4 numbers away but are you above or below the Computers Guess???  Focus if you want to win!");

                }
                else
                {
                    Console.WriteLine("You're below the computers Guess - Get in the Game and try harder!!!!");
                }


            }



        }
    }
}