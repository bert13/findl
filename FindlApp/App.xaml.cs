using FindlApp.Constants;
using FindlApp.Servceis;
using FindlApp.Views;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;
using Unity.Lifetime;

namespace FindlApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell() => Container.Resolve<MainWindow>();
        private IContainerRegistry m_container;

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ICheckWordService, CheckWordService>();
        }

        protected override void OnInitialized()
        {
            var regionManager = Container.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.GuessingRegion, () => Container.Resolve<GuessingView>());
            regionManager.RegisterViewWithRegion(RegionNames.HeaderRegion, () => Container.Resolve<HeaderView>());
            regionManager.RegisterViewWithRegion(RegionNames.KeyboardRegion, () => Container.Resolve<KeyboardView>());

            MainWindow?.Show();
            base.OnInitialized();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }
    }
}
