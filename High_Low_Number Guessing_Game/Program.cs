namespace High_Low_Number_Guessing_Game
{
    internal class Program
    {
        const int MAX_GUESSES = 10;
        const int MAGIC_NUMBER = 5;

        static void Main(string[] args)
        {
            Console.WriteLine("This Game Will start by giving the User an opportunity " +
                "To Guess the Correct Number given by the Computer. You will only Win if you guess the correct number " +
                "that is not Too High or below(Too Low) the computers selection");
            Console.WriteLine();


            Random rnd = new Random();
            int computerGuess = rnd.Next(1, 101);
            Console.WriteLine("The Computer will enter a number guess.");
            Console.WriteLine("(The computers answer will be Displayed Once the User enters the correct guess)");
            Console.WriteLine($"Your have {MAX_GUESSES} attempts to guess the secret number");
            //test functionality of code guess with Console.WriteLine(computerGuess);

            for (int j = 1; j <= MAX_GUESSES; ++j)
            {

                Console.WriteLine($"{Environment.NewLine} {Environment.NewLine}Please enter a number guess.");
                int userInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{Environment.NewLine}");


                if (userInput == computerGuess)
                {
                    Console.WriteLine("You've WON!!!! You guessed the correct number!!!");
                    Console.WriteLine($"\nYour correct guess of {userInput} WINS the Game!!!\n");
                    break;
                }
                if (j == MAX_GUESSES && userInput < computerGuess)
                {
                    Console.WriteLine($"{Environment.NewLine}Mmm, Mmm, Better luck Next Game...\nYour guess of {userInput} was {computerGuess - userInput} off from the Computer Guess of {computerGuess}.");
                    break;
                }
                if (j == MAX_GUESSES && userInput > computerGuess)
                {
                    Console.WriteLine($"{Environment.NewLine}Mmm, Mmm, Better luck Next Game...\nYour guess of {userInput} was {userInput - computerGuess} off from the Computer Guess of {computerGuess}.");
                    break;
                }
                if ((userInput > computerGuess) && (userInput - computerGuess) >= (2 * MAGIC_NUMBER))
                {
                    Console.WriteLine($"{Environment.NewLine}This is just terrible You're 10 or more numbers ABOVE than the computers guess!!!\nYou can do better than that - Try Again!!!");
                    continue;
                }
                if (userInput > computerGuess && (userInput - computerGuess) >= MAGIC_NUMBER)
                {
                    Console.WriteLine($"{Environment.NewLine}Oook, now You're more than 5 numbers ABOVE than the computers guess!!!\nYou're Almost good at this Game - keep trying!!!!!!");
                    continue;
                }
                if (userInput > computerGuess && (userInput - computerGuess) < MAGIC_NUMBER)
                {
                    Console.WriteLine($"SO CLOSE!!!! You're Less then 4 numbers above the Computers Guess");
                    continue;
                }
                if (computerGuess > userInput && (computerGuess - userInput) >= (2 * MAGIC_NUMBER))
                {
                    Console.WriteLine("Well this is embarising you're more than the 10 points below the computers guess!!!\nKeep trying.\n");
                    continue;
                }
                if (computerGuess > userInput && (computerGuess - userInput) >= MAGIC_NUMBER)
                {
                    Console.WriteLine("Oh no, You're more than the 5 points below the computers guess!!!\nYou're getting better at this Game - keep trying!!!!!!\n");
                    continue;
                }
                if ((computerGuess - userInput) < MAGIC_NUMBER)
                {
                    Console.WriteLine($"{Environment.NewLine}Wow, You're less than 4 numbers BELOW the computers guess so just focus and try to guess higher!!!");
                    continue;
                }


            }



        }
    }
}