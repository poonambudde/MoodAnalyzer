using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyser_Problems
{
    public class MoodAnalyserCustomException : Exception
    {
        //Enum for Exception Type
        public enum ExceptionType
        {
            NULL_MESSAGE_EXCEPTION, EMPTY_MESSAGE_EXCEPTION
        }
        
        private readonly ExceptionType exceptionType;

        public MoodAnalyserCustomException(ExceptionType exceptionType, string exceptionMessage) : base(exceptionMessage)
        {
            this.exceptionType = exceptionType;
        }

    }
}
