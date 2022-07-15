namespace WordSearch.Bootstrapper.Core
{
    using System;
    using System.Diagnostics;

    using Microsoft.Extensions.Configuration;

    using Prism.Ioc;

    using WordSearch.Bootstrapper.Extensions;
    using WordSearch.Assets.Interfaces;

    public partial class App
    {
        private const string StartPageName = "MainPageView";

        static App() => new AppBootstrapper();

        protected override async void OnInitialized()
        {
            try
            {
                InitializeComponent();

                var result = await NavigationService
                    .NavigateAsync(StartPageName);

                if (!result.Success)
                    Debugger.Break();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                Debugger.Break();
            }
        }

        protected override void RegisterTypes(
            IContainerRegistry containerRegistry)
        {
            IConfiguration configuration = GetConfiguration();

            containerRegistry.RegisterSqliteDbContext(configuration);
        }

        private IConfiguration GetConfiguration()
        {
            string path = Container.Resolve<IAppSettingsResource>().AbsolutePath;

            var configuration = new ConfigurationBuilder()
                .AddJsonFile(path)
                .Build();

            return configuration;
        }
    }
}
