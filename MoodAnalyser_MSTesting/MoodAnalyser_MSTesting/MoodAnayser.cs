﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser_MSTesting
{
    public class MoodAnayser
    {
        public string AnalyseMood(string message)
        {
            bool result = message.Contains("SAD");
            if (result)
            {
                return "SAD";
            }
            else
            {
                return "";
            }
        } 
    }
}
