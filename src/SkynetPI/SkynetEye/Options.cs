using System;
using CommandLine;

namespace SkynetEye
{
    public class Options
    {
        [Option('r', "robot", Required = true, HelpText = "Robot to which we will associate the captures.")]
        public Guid Robot { get; set; }
    }
}
