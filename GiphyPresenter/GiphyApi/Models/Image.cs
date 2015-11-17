using Newtonsoft.Json;

namespace GiphyPresenter.GiphyApi.Models
{
    public class Image
    {
        [JsonProperty("fixed_height")]
        public Attribute FixedHeight { get; set; }
    }
}
