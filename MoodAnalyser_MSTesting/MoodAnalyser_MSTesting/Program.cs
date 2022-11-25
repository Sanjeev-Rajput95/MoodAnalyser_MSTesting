namespace MoodAnalyser_MSTesting
{
  public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("************* WELCOME TO MOODANALYSER MSTESTING  ********************");

            Console.WriteLine("Enter string to check Mood ");
           // string mood = Console.ReadLine();
            MoodAnayser moodAnayser = new MoodAnayser();

            MoodAnayser obj = new MoodAnayser();
            string res = obj.AnalyseMood("I am in Sad Mood");
            Console.WriteLine(res);
        }

    }
}