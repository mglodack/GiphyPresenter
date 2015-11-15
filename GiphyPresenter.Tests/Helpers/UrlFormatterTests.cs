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
        static IEnumerable<Parameter> _Parameters = new Parameter[]
        {
            new Parameter() { Name = "something", Value = "Holy Cow" },
            new Parameter() { Name = "key", Value = "value" },
        };

        static string expected = "something=Holy Cow&key=value";

        [Test]
        public void BuildParamString_ShouldReturn_CorrectString()
        {
            var result = UrlFormatter.BuildParamString(_Parameters);
            Assert.AreEqual(expected, result);
        }
    }
}
