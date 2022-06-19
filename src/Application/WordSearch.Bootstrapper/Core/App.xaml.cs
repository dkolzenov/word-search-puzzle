namespace WordSearch.Bootstrapper.Core
{
    using System;
    using System.Diagnostics;

    using Prism.Ioc;
    using Prism.DryIoc;
    using Prism.Modularity;

    using WordSearch.Ioc.Modules;

    public partial class App : PrismApplication
    {
        public App() { }

        protected override async void OnInitialized()
        {
            try
            {
                InitializeComponent();

                new Startup();

                var result = await NavigationService.NavigateAsync("MainPageView");

                if (!result.Success)
                    Debugger.Break();
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                Debugger.Break();
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<IocModule>();
        }
    }
}
