namespace IfStatementHighScoreUpdater
{
    internal class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "Random";
        static void Main(string[] args)
        {
            CheckHighscore(250, "Maria");
            CheckHighscore(315, "Elon");
            CheckHighscore(314, "Elonkukka");
            CheckHighscore(350, "Random");
        }
        public static void CheckHighscore(int score, string playerName) 
        {
            if (score > highscore) 
            {
            highscore = score;
            highscorePlayer = playerName;

            Console.WriteLine("New highscore is {0}", score);
            Console.WriteLine("It is now held by {0}", playerName);
            }
            else
            {
                Console.WriteLine("The old highscore could not be broken. It is still {0} and held by {1}", highscore, highscorePlayer);
            }
        }
    }
}
