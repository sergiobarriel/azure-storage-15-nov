using System;
using Newtonsoft.Json;

namespace Skynet.WebAPI.Viewmodels.Model
{
    public class Model
    {
        [JsonProperty("id")]
        public Domain.CrossModels.Enums.Model Id { get; set; }

        [JsonProperty("name")]
        public string Name => Enum.GetName(typeof(Domain.CrossModels.Enums.Model), Id);
    }
}
