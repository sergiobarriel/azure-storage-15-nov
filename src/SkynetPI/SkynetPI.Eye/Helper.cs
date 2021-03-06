﻿using System;

namespace SkynetPI.Eye
{
    public static class Helper
    {   
        /// <summary>
        /// Convert bytes to kilobytes
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static double ConvertBytesToKb(long bytes) => (bytes / 1024f);

        /// <summary>
        /// Print message on terminal
        /// </summary>
        /// <param name="message"></param>
        public static void Message(string message) => Console.WriteLine($"{DateTime.Now.Hour:D2}:{DateTime.Now.Minute:D2}:{DateTime.Now.Second:D2} - {message}");

    }
}