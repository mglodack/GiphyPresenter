using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiphyPresenter.ViewModels
{
    public class MainGiphyViewVM : BindableBase
    {
        public MainGiphyViewVM()
        {
            _gifs.Add(new GifVM(@"C:\Users\Mathew Glodack\Desktop\LoadingScreen.gif"));
            _gifs.Add(new GifVM(@"C:\Users\Mathew Glodack\Desktop\LoadingScreen.gif"));
            _gifs.Add(new GifVM(@"C:\Users\Mathew Glodack\Desktop\LoadingScreen.gif"));
            _gifs.Add(new GifVM(@"C:\Users\Mathew Glodack\Desktop\LoadingScreen.gif"));
            _gifs.Add(new GifVM(@"C:\Users\Mathew Glodack\Desktop\LoadingScreen.gif"));
            Search = new DelegateCommand(DoNothingForNow);
        }

        ObservableCollection<GifVM> _gifs = new ObservableCollection<GifVM>();

        public ObservableCollection<GifVM> Gifs
        {
            get { return _gifs; }
        }

        string _query = string.Empty;

        public string Query
        {
            get { return _query; }
            set { SetProperty(ref _query, value); }
        }

        public DelegateCommand Search { get; private set; }

        public void DoNothingForNow() { }
    }
}
