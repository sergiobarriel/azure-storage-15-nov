using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using SkynetTargetQueue.Services;

namespace SkynetTargetQueue
{
    public class Program
    {
        private static IConfigurationRoot _configuration;

        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();

            Start();
        }

        /// <summary>
        /// Start
        /// </summary>
        private static void Start()
        {
            Helper.Message("Starting...\r\n");

            TargetService.StartLoop(_configuration);

            Console.ReadKey();
        }

    }
}
