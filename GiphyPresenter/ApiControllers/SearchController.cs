using GiphyPresenter.GiphyApi.Models;
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

        public Search GetSearchResults(string query)
        {
            throw new NotImplementedException();
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
