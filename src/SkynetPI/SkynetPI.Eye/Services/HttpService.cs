using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SkynetPI.Eye.Services
{
    public static class HttpService
    {
        /// <summary>
        /// Create Http Request
        /// </summary>
        /// <param name="object"></param>
        /// <returns></returns>
        public static ByteArrayContent SerializeContent(object @object)
        {
            var serializeObject = JsonConvert.SerializeObject(@object, JsonSettings);
            var buffer = Encoding.UTF8.GetBytes(serializeObject);
            var content = new ByteArrayContent(buffer);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return content;
        }

        /// <summary>
        /// Configure Json Serializer
        /// </summary>
        private static readonly JsonSerializerSettings JsonSettings = new JsonSerializerSettings()
        {
            ContractResolver = new DefaultContractResolver()
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            }
        };
    }
}
