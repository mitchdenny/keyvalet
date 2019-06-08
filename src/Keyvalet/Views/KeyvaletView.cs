using Autofac;
using Keyvalet.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Keyvalet.Views
{
    public class KeyvaletView : Page
    {
        private static IContainer container;

        private void RegisterViewModels(ContainerBuilder builder)
        {
            builder.RegisterType<WelcomeViewModel>();
        }

        private ContainerBuilder GetBuilder()
        {
            var builder = new ContainerBuilder();
            RegisterViewModels(builder);

            return builder;
        }

        public IContainer GetContainer()
        {
            if (container == null)
            {
                var builder = GetBuilder();
                container = builder.Build();
            }

            return container;
        }

        public TViewModel GetViewModel<TViewModel>(Uri uri)
        {
            var container = GetContainer();
            var viewModel = container.Resolve<TViewModel>(new NamedParameter("uri", uri));
            return viewModel;
        }
    }
}
