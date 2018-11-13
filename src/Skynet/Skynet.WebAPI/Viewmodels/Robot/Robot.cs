using System;
using Newtonsoft.Json;

namespace Skynet.WebAPI.Viewmodels.Robot
{
    public class Robot
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("model")]
        public Model.Model Model { get; set; }

        [JsonProperty("captures")]
        public int Captures { get; set; }

    }
}
