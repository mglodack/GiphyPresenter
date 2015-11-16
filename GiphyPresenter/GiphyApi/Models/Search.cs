using Newtonsoft.Json;
using System.Collections.Generic;

namespace GiphyPresenter.GiphyApi.Models
{
    public class Search
    {
        [JsonConstructor]
        public Search() { }

        [JsonProperty("data")]
        public IEnumerable<Giphy> Results { get; set; }
    }
}
