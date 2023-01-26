namespace High_Low_Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next();
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(rnd.Next(10));
            }
        }
    }
}