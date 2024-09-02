using System;
using System.IO;
using System.Threading;

namespace OfdRuErrorParser
{
    public static class Logger
    {
        private static void Append(string status, string text, int countTry = 1)
        {
            try
            {
                File.AppendAllText(".log", $"{status} {DateTime.Now:HH:mm:ss} {text}\n");
            }
            catch (Exception)
            {
                if (countTry < 3)
                {
                    Thread.Sleep(1000);
                    Append(status, text, ++countTry);
                }
            }
        }

        public static void Error(string text) => Append("ERROR", text);
        public static void Debug(string text) => Append("DEBUG", text);
        public static void Warning(string text) => Append("WARN ", text);
        public static void Info(string text) => Append("INFO ", text);
    }

    public class LoggingException : Exception
    {
        public LoggingException(string text) : base(text) => Logger.Error(text);
    }
}
