using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiphyPresenter.ApiControllers
{
    public abstract class BaseController
    {
        IDictionary<string, string> _baseParams = new Dictionary<string, string>()
        {
            { "api_key", "dc6zaTOxFJmzC" },
        };

        public abstract string EndPoint { get; set; }
    }
}
