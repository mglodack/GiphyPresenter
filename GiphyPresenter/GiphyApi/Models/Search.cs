using Newtonsoft.Json;
using System.Collections.Generic;

namespace GiphyPresenter.GiphyApi.Models
{
    class Search
    {
        [JsonConstructor]
        public Search() { }

        [JsonProperty("data")]
        public IEnumerable<Giphy> Results { get; set; }
    }
}
