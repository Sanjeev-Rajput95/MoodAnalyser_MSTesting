namespace MoodAnalyser_MSTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("************* WELCOME TO MOODANALYSER MSTESTING  ********************");

            //Console.WriteLine("Enter string to check Mood ");
            // string mood = Console.ReadLine();

           // MoodAnayser obj = new MoodAnayser("I am in SAD Mood");
            MoodAnayser obj = new MoodAnayser(null);

            string res = obj.AnalyseMood();
            Console.WriteLine(res);


        }

    }
}