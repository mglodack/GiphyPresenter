using Newtonsoft.Json;

namespace GiphyPresenter.GiphyApi.Models
{
    public class Giphy
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
