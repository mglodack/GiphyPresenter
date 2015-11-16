using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiphyPresenter.ViewModels
{
    public class GifVM : BindableBase
    {
        public GifVM(string filePath)
        {
            _type = "gif";
            _filePath = filePath;
        }

        string _type;

        public string Type { get { return _type; } }

        // NOTE: Temporary until I get giphy api set up
        string _filePath;

        public string FilePath { get { return _filePath; } }
    }
}
