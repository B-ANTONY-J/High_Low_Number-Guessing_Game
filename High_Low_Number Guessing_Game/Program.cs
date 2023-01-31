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
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //int uaerInputThird = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please Enter a Number Guess.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                //int num = rnd.Next(100);
                int computerGuess = rnd.Next(1, 10);
                Console.WriteLine();
                Console.WriteLine("Computer Please Enter a Number Guess.");
                Console.WriteLine(computerGuess);
                Console.WriteLine();
                //Console.WriteLine(userInputSecond);
                if (userInput > computerGuess)
                {
                    Console.WriteLine("Player 1 You're Higher than The Computers Guess!!!");
                }
                else if (userInput < computerGuess)
                {
                    Console.WriteLine("player 1 this time You're Lower than the Computers Guess!!!");
                }
                else if (userInput == computerGuess)
                {
                    Console.WriteLine("Player 1 you tied but in this game You Win!!!");
                }
                else 
                {
                    Console.WriteLine("Game Ends after the 4th Time!!!");
                }
            }
        }
    }
}