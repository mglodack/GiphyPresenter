using GiphyPresenter.GiphyApi;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Web;

namespace GiphyPresenter.Helpers
{
    public static class UriFormatter
    {
        public static string UrlEncodeParamters(IDictionary<string, string> parameters)
        {
            return HttpUtility.UrlEncode(BuildParamString(parameters));
        }

        public static string BuildParamString(IDictionary<string, string> parameters)
        {
            return _Join(parameters.Select(_Assign).ToArray());
        }

        static string _Assign(KeyValuePair<string, string> kvp)
        {
            return string.Join("=", kvp.Key, kvp.Value);
        }

        static string _Join(IEnumerable<string> parameters)
        {
            return string.Join("&", parameters);
        }
    }
}
