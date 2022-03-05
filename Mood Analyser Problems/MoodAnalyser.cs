using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyser_Problems
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string moodMessage)
        {
            if (moodMessage.ToLower().Contains("sad"))
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
