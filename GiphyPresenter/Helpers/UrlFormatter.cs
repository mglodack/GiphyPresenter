using GiphyPresenter.GiphyApi;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Web;

namespace GiphyPresenter.Helpers
{
    public static class UrlFormatter
    {
        public static string UrlEncodeParameters(IEnumerable<Parameter> parameters)
        {
            return HttpUtility.UrlEncode(BuildParamString(parameters));
        }

        public static string BuildParamString(IEnumerable<Parameter> parameters)
        {
            return _Join(parameters.Select(_Assign).ToArray());
        }

        static string _Assign(Parameter parameter)
        {
            return string.Join("=", parameter.Name, parameter.Value);
        }

        static string _Join(IEnumerable<string> parameters)
        {
            return string.Join("&", parameters);
        }
    }
}
