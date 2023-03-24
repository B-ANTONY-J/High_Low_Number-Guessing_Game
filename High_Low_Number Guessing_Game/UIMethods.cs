using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace High_Low_Number_Guessing_Game
{
    public static class UIMethods
    {
        const int MAX_GUESSES = 10;
        const int MAGIC_NUM = 5;
        public static void UserInput()
        {
            Console.WriteLine("This Game Will start by giving the User an opportunity " +
    "To Guess the Correct Number given by the Computer. You will only Win if you guess the correct number " +
    "that is not Too High(above) or Too Low(below) the computers selection.\n");


            Console.WriteLine("The Computer will enter a number guess.");
            Console.WriteLine("(The computers answer will be Displayed Once the User enters the correct guess.)");
        }
        public static void MaxGuessLoop()
        {
            int equalsTwenty = 4 * MAGIC_NUM;
            int equalsTen = 2 * MAGIC_NUM;
            Random rnd = new Random();
            int computerGuess = rnd.Next(1, 101);
            Console.WriteLine($"Your have {MAX_GUESSES} attempts to guess the secret number.");
            // test functionality of code guess with 
            //Console.WriteLine(computerGuess);



            for (int j = 1; j <= MAX_GUESSES; ++j)
            {

                Console.WriteLine($"\n\nPlease enter a number guess.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\n");

                //calculates the diff between the User and CPU Guess
                int userMinusCpuGuess = Math.Abs(userInput - computerGuess);

                //confirms if the User input is Greater than the CPU guess
                bool userGreaterThanCpu = userInput > computerGuess;

                string hint = "below";
                if (userGreaterThanCpu) hint = "above";

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

                              
                if (userMinusCpuGuess < MAGIC_NUM)
                {
                    Console.WriteLine($"SO CLOSE!!!! You're less than {MAGIC_NUM} numbers {hint} the Computers Guess! Focus if you want to win!");
                }
                else if (userMinusCpuGuess <= equalsTen)
                {
                    Console.WriteLine($"\nThis is just terrible! You're still {hint} the computers guess by {equalsTen} or less numbers!!!\nYou can do better than that - Try Again!!!");
                }
                else if (userMinusCpuGuess <= equalsTwenty)
                {
                    Console.WriteLine($"You're {hint} the computers Guess - Get in the Game and try harder!!!!");
                }
                // this is now the remaining case where the user is more off than 20 numbers
                else
                {
                    Console.WriteLine($"You're not only {hint} the computers guess but you're just sooo far away by more than {equalsTwenty}!!!");
                }
            }
        }
    }
}
