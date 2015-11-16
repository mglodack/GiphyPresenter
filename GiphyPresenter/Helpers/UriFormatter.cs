using GiphyPresenter.GiphyApi;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Web;

namespace GiphyPresenter.Helpers
{
    public static class UriFormatter
    {
        [Obsolete("No longer going to be using this")]
        public static string UrlEncodeParameters(IEnumerable<Parameter> parameters)
        {
            return HttpUtility.UrlEncode(BuildParamString(parameters));
        }

        [Obsolete("No longer like this style")]
        public static string BuildParamString(IEnumerable<Parameter> parameters)
        {
            return _Join(parameters.Select(_Assign).ToArray());
        }

        [Obsolete("No longer going to use this")]
        static string _Assign(Parameter parameter)
        {
            return string.Join("=", parameter.Name, parameter.Value);
        }

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
