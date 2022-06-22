namespace WordSearch.Bootstrapper.Core
{
    using System;
    using System.Diagnostics;

    using Prism.Ioc;

    public partial class App
    {
        private const string StartPageName = "MainPageView";

        static App() => new PrismBootstrapper();

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
        }
    }
}
