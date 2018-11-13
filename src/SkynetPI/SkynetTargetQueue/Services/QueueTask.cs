using System.Threading;
using Microsoft.Extensions.Configuration;

namespace SkynetTargetQueue.Services
{
    public class TargetService
    {
        public static void StartLoop(IConfigurationRoot configuration)
        {
            var queue = new QueueService(configuration);

            while (true)
            {
                var target = queue.GetMessage();

                if (target != null)
                {
                    Helper.Message($"Kill {target}!");
                }

                Thread.Sleep(1000);
            }
        }

    }
}
