using System;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using SkynetEye.DTO;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Camera;

namespace SkynetEye.Services
{
    public class CaptureService
    {
        public static void StartLoop(Options options, IConfigurationRoot configuration)
        {
            var httpClient = new HttpClient();

            while (true)
            {
                var pictureBytes = Pi.Camera.CaptureImage(new CameraStillSettings()
                {
                    CaptureWidth = int.Parse(configuration["WebAPI:Capture:Width"]),
                    CaptureHeight = int.Parse(configuration["WebAPI:Capture:Heigth"])
                });

                var capture = new CreateCapture(options.Robot, pictureBytes);


                httpClient.PostAsync(configuration["WebAPI:Capture:Endpoint"], HttpService.SerializeContent(capture)).Wait();

                // Thread.Sleep(options.Sleep);
            }
        }
    }
}
