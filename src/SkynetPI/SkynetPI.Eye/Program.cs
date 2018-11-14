using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommandLine;
using Microsoft.Extensions.Configuration;
using SkynetPI.Eye.Services;

namespace SkynetPI.Eye
{
    public class Program
    {
        private static IConfigurationRoot _configuration;
        private static Options _options;

        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            _options = new Options();

            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(opt => _options = opt)
                .WithNotParsed(ExitWithErrors);

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();

            Start().Wait();
        }

        /// <summary>
        /// Loop: start tasks
        /// </summary>
        private static async Task Start()
        {
            Helper.Message("Starting...\r\n");

            await CaptureService.StartLoop(_options, _configuration);

            Console.ReadKey();
        }

        /// <summary>
        /// Force application exit and print parameter errors
        /// </summary>
        /// <param name="errors"></param>
        private static void ExitWithErrors(IEnumerable<Error> errors)
        {
            Helper.Message($"{errors.Count()} errors have been found in the parameters of the application.");
            Environment.Exit(-1);
        }

    }
}
