using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyser_Problems
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string moodMessage)
        {
            try
            {
                if (moodMessage == null)
                {
                    throw new NullReferenceException();
                }
                if (moodMessage.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }

            }
            catch(NullReferenceException ex)
            {
                return "HAPPY";
            }
            
        }
    }
}
