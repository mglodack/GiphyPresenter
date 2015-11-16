using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiphyPresenter.Helpers;
using GiphyPresenter.GiphyApi;

namespace GiphyPresenter.Tests.Helpers
{
    class UrlFormatterTests
    {
        static IDictionary<string, string> _Params = new Dictionary<string, string>()
        {
            { "something", "Holy Cow" },
            { "key", "value" },
        };

        static string expected = "something=Holy Cow&key=value";

        [Test]
        public void BuildParamString_ShouldReturn_CorrectString()
        {
            var result = UriFormatter.BuildParamString(_Params);
            Assert.AreEqual(expected, result);
        }
    }
}
