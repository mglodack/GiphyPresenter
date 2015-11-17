using GiphyPresenter.GiphyApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GiphyPresenter.GiphyApi.Clients
{
    public class GiphyGET
    {
        string _host = "http://api.giphy.com/v1/gifs/";

        public string Host { get { return _host; } }
     
        public Uri _GetBaseUri()
        {
            return new Uri(Host);
        }

        Uri _GetUriToSend(string query)
        {
            return new Uri(_GetBaseUri(), query);
        }

        public Task<Search> Send(string query)
        {
            return _Fetch(_GetUriToSend(query))
                .ContinueWith(task => _Read(task.Result))
              .ContinueWith(task => _Deserialize(task.Result));
        }

        async Task<HttpResponseMessage> _Fetch(Uri uri)
        {
            using (var client = new HttpClient())
            {
                return await client.GetAsync(uri);
            }
        }

        string _Read(HttpResponseMessage response)
        {
            return response.Content.ReadAsStringAsync().Result;
        }

        Search _Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<Search>(json);
        }
    }
}
