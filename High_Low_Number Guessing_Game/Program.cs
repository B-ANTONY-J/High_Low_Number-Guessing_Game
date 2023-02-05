namespace High_Low_Number_Guessing_Game
{
    internal class Program
    {
        const int MAX_GUESSES = 10;

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

            for (int j = 1; j <= MAX_GUESSES; ++j)
            {

                Console.WriteLine($"{Environment.NewLine} {Environment.NewLine}Please enter a number guess.");
                int userInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{Environment.NewLine}");

                if (userInput > computerGuess)
                {
                    Console.WriteLine("You're higher than the computers guess!!!");
                }
                else if (userInput < computerGuess)
                {
                    Console.WriteLine("You're lower than the computers guess!!!");
                }
                else if (userInput == computerGuess)
                {

                    Console.WriteLine("You've WON!!!! You guessed the correct number!!!");
                    Console.WriteLine();
                    Console.WriteLine($"Your correct guess of {userInput} WINS the Game!!!");
                    Console.WriteLine();
                    break;
                }
                if (j == MAX_GUESSES && computerGuess > userInput)
                {
                    Console.WriteLine($"{Environment.NewLine}Computers correct guess revealed below as...");
                    Console.WriteLine(computerGuess);
                    Console.WriteLine($"{Environment.NewLine}Your last guess of {userInput} was {computerGuess - userInput} numbers off from the correct guess of {computerGuess}, better luck Next Time!");
                    break;

                } if (j == MAX_GUESSES && userInput > computerGuess)
                {
                    Console.WriteLine($"{Environment.NewLine}Computers correct guess revealed below as...");
                    Console.WriteLine(computerGuess);
                    Console.WriteLine($"{Environment.NewLine}This time Your last guess of {userInput} was {userInput - computerGuess} numbers off from the correct guess of {computerGuess}, better luck Next Time!");
                    break;

                }

            }
            Console.WriteLine();

        }
    }
}