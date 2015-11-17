using Newtonsoft.Json;

namespace GiphyPresenter.GiphyApi.Models
{
    public class Attribute
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
