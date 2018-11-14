using System;
using Newtonsoft.Json;

namespace Skynet.WebAPI.Viewmodels.Capture
{
    public class Capture
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("robot_id")]
        public Guid RobotId { get; set; }

        [JsonProperty("blob_id")]
        public string BlobId { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }
    }
}
