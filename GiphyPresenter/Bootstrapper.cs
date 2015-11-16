using Microsoft.Practices.Unity;
using Prism.Mvvm;
using Prism.Unity;
using System;
using System.Globalization;
using System.Reflection;
using System.Windows;
using GiphyPresenter.Views;

namespace GiphyPresenter
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            {
                var viewName = viewType.FullName;
                viewName = viewName.Replace(".Views.", ".ViewModels.");
                var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                var viewModelName = string.Format(CultureInfo.InvariantCulture, "{0}VM, {1}", viewName, viewAssemblyName);
                return Type.GetType(viewModelName);
            });

            ViewModelLocationProvider.SetDefaultViewModelFactory((type) => Container.Resolve(type));
        }
    }
}
