using System;
using Newtonsoft.Json;

namespace Skynet.WebAPI.Viewmodels.Capture
{
    public class CreateCapture
    {
        [JsonProperty("robot_id")]
        public Guid RobotId { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("base64")]
        public string Base64File { get; set; }
    }
}
