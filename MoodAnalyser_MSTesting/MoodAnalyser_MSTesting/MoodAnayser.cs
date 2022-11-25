using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser_MSTesting
{
    public class MoodAnayser
    {
        public string message;
        public MoodAnayser()
        {

        }
        public MoodAnayser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            bool result = this.message.Contains("Sad");
            
            if (result)
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        } 
    }
}
