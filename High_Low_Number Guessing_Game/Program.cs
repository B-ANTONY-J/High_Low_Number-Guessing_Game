namespace High_Low_Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Game Will start by giving the Computer 10 opportunities " +
                "To Guess the Correct Number. You only Win when you can avoid being Greater " +
                "than 80(Too High) or Avoid being 25 or below(Too Low)");

            Random rnd = new Random();
            for (int j = 1; j < 10; j++)
            {
                int num = rnd.Next(100);
                //int num = rnd.Next(1, 100);
                //Console.WriteLine(rnd.Next(100));
                Console.WriteLine(num);
                if (num >= 80)
                {
                    Console.WriteLine("Computer You're too High!!  You Lose!");
                }
                if (num > 26) 
                {
                    Console.WriteLine("Computer you Figured it out! You WIN!!!");
                }
                if (num <= 25) 
                {
                    Console.WriteLine("Computer You're too Low! You Lose!!!");
                }
            }
        }
    }
}