using GiphyPresenter.GiphyApi.Clients;
using GiphyPresenter.GiphyApi.Models;
using GiphyPresenter.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiphyPresenter.ApiControllers
{
    public class SearchController : BaseController
    {
        readonly string _parameter = "q";

        readonly string _endpoint = "search";

        public override string EndPoint
        {
            get { return _endpoint; }
            set { }
        }

        public async Task<Search> GetSearchResults(string query)
        {
            var pathAndQuery = _CombinePathAndQuery(UriFormatter.UrlEncodeParamters(_GetParameters(query)));
            return await new GiphyGET().Send(pathAndQuery);
        }

        string _CombinePathAndQuery(string query)
        {
            return string.Format("{0}?{1}", EndPoint, query);
        }

        IDictionary<string,string> _GetParameters(string query)
        {
            return BaseParams.Concat(_GetQueryKVP(query))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }

        IDictionary<string, string> _GetQueryKVP(string query)
        {
            return new Dictionary<string, string>()
            {
                { _parameter, query },
            };
        }
    }
}
