using System;

namespace SkynetTargetQueue
{
    public static class Helper
    {   
        /// <summary>
        /// Print message on terminal
        /// </summary>
        /// <param name="message"></param>
        public static void Message(string message) => Console.WriteLine($"{DateTime.Now.Hour:D2}:{DateTime.Now.Minute:D2}:{DateTime.Now.Second:D2} - {message}");

    }
}