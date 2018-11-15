using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SkynetPI.Eye.DTO;
using Unosquare.RaspberryIO;

namespace SkynetPI.Eye.Services
{
    public class CaptureService
    {
        public static async Task StartLoop(Options options, IConfigurationRoot configuration)
        {
            var httpClient = new HttpClient();

            while (true)
            {
                var width = int.Parse(configuration["WebAPI:Capture:Width"]);
                var heigth = int.Parse(configuration["WebAPI:Capture:Heigth"]);

                var pictureBytes = await Pi.Camera.CaptureImageJpegAsync(width, heigth);

                var capture = new CreateCapture(options.Robot, pictureBytes);

                httpClient.PostAsync(configuration["WebAPI:Capture:Endpoint"], HttpService.SerializeContent(capture));
            }
        }
    }
}
