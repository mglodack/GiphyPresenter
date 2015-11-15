using Newtonsoft.Json;

namespace GiphyPresenter.GiphyApi.Models
{
    class Random
    {
        [JsonConstructor]
        public Random() { }

        [JsonProperty("data")]
        public Giphy Result { get; set; }
    }
}
