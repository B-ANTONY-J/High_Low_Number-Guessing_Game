namespace High_Low_Number_Guessing_Game
{
    internal class Program
    {
        const int GUESS_MARGIN_BY_20 = 20;
        const int GUESS_MARGIN_BY_10 = 10;
        const int GUESS_MARGIN_BY_5 = 5;
        const int MAX_GUESSES = 10;

        static void Main(string[] args)
        {


            Console.WriteLine("This Game Will start by giving the User an opportunity " +
    "To Guess the Correct Number given by the Computer. You will only Win if you guess the correct number " +
    "that is not Too High(above) or Too Low(below) the computers selection.\n");


            Console.WriteLine("The Computer will enter a number guess.");
            Console.WriteLine("(The computers answer will be Displayed Once the User enters the correct guess.)");



            Random rnd = new Random();
            int computerGuess = rnd.Next(1, 101);
            Console.WriteLine($"Your have {MAX_GUESSES} attempts to guess the secret number.");



            for (int j = 1; j <= MAX_GUESSES; ++j)
            {

                Console.WriteLine($"\n\nPlease enter a number guess.");
                int userInput = Convert.ToInt32(Console.ReadLine());
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

                //calculates the diff between the User and CPU Guess
                int userMinusCpuGuess = Math.Abs(userInput - computerGuess);

                //confirms if the User input is Greater than the CPU guess
                bool userGreaterThanCpu = userInput > computerGuess;

                string hint;
                if (userGreaterThanCpu)
                    hint = "above";
                else
                    hint = "below";

                if (userMinusCpuGuess < GUESS_MARGIN_BY_5)
                {
                    Console.WriteLine($"SO CLOSE!!!! You're less than {GUESS_MARGIN_BY_5} numbers {hint} the Computers Guess! Focus if you want to win!");
                }
                else if (userMinusCpuGuess <= GUESS_MARGIN_BY_10)
                {
                    Console.WriteLine($"\nThis is just terrible! You're still {hint} the computers guess by {GUESS_MARGIN_BY_10} or less numbers!!!\nYou can do better than that - Try Again!!!");
                }
                else if (userMinusCpuGuess <= GUESS_MARGIN_BY_20)
                {
                    Console.WriteLine($"You're {hint} the computers Guess - Get in the Game and try harder!!!!");
                }
                // The remaining case will now show where the user is off by more than 20 numbers
                else
                {
                    Console.WriteLine($"You're not only {hint} the computers guess but you're just sooo far away by more than {GUESS_MARGIN_BY_20}!!!");
                }

            }
        }
    }
}



