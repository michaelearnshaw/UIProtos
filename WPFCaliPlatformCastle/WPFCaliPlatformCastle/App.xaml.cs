using Caliburn.Castle;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Microsoft.Practices.ServiceLocation;
using WPFCaliPlatformCastle.ViewModels;

namespace WPFCaliPlatformCastle
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private IWindsorContainer _container;

        public App()
        {
            RegisterComponents();
        }

        protected override IServiceLocator CreateContainer()
        {
            _container = new WindsorContainer();
            return new WindsorAdapter(_container);
        }

        protected override object CreateRootModel()
        {
            return _container.Resolve<IShellViewModel>();
        }

        protected void RegisterComponents()
        {
            _container.Register(Component.For<IShellViewModel>()
                                         .ImplementedBy<ShellViewModel>()
                                         .LifeStyle.Singleton);
        }
    }
}
