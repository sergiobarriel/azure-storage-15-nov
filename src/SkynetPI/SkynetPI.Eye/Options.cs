using System;
using CommandLine;

namespace SkynetPI.Eye
{
    public class Options
    {
        [Option('r', "robot", Required = true, HelpText = "Robot to which we will associate the captures.")]
        public Guid Robot { get; set; }
    }
}
