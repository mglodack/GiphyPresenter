﻿using Newtonsoft.Json;

namespace GiphyPresenter.GiphyApi.Models
{
    class Random
    {
        [JsonProperty("data")]
        public Giphy Result { get; set; }
    }
}
