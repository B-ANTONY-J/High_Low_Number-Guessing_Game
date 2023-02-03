namespace High_Low_Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Game Will start by giving the User an opportunity " +
                "To Guess the Correct Number given by the Computer. You will only Win if you guess the correct number " +
                "that is not Too High or below(Too Low) the computers selection");
            Console.WriteLine();


            Random rnd = new Random();
            int computerGuess = rnd.Next(1, 100);
            Console.WriteLine("Computer please enter a number guess.");
            Console.WriteLine("(The computers answer will be Displayed Once the User enters the correct guess)");

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{Environment.NewLine} {Environment.NewLine}Player 1 please enter a number guess.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine($"{Environment.NewLine}");
                
                if (userInput > computerGuess)
                {
                    Console.WriteLine("Player 1 you're higher than the computers guess!!!");
                }
                else if (userInput < computerGuess)
                {
                    Console.WriteLine("Player 1 this time you're lower than the computers guess!!!");
                }
                else if (userInput == computerGuess)
                {

                    Console.WriteLine("Player 1 you WIN!!!! You guessed the correct number!!!");
                    Console.WriteLine();
                    Console.WriteLine("Player 1 reveal your Number...");
                    Console.WriteLine(userInput);
                    Console.WriteLine();
                    Console.WriteLine("Computer please reveal your number...");
                    Console.Write(computerGuess);
                    break;
                }
                else if (userInput != computerGuess)
                {
                    Console.WriteLine("Game Ends after the 4th Time!!!");
                }
            }

            Console.WriteLine();

        }
    }
}