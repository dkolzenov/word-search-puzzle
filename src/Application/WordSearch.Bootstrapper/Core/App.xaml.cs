namespace WordSearch.Bootstrapper.Core
{
    using System;
    using System.Reflection;

    using Prism.Ioc;
    using Prism.DryIoc;
    using Prism.Modularity;

    using WordSearch.Ioc;
    using WordSearch.Presentation.ViewModels.MainPage;
    using WordSearch.Helpers.Interfaces;
    using WordSearch.Data.Properties;
    using WordSearch.Data.Database.Constants;
    using WordSearch.Services.Interfaces;

    public partial class App : PrismApplication
    {
        public App() { }

        protected override async void OnInitialized()
        {
            try
            {
                InitializeComponent();

                var dbPathHelper = Container.Resolve<IDatabasePathHelper>();

                var writerService = Container.Resolve<IEmbeddedResourceWriterService>(
                    (typeof(Assembly), _ = DataProperties.Assembly),
                    (typeof(string), _ = WordsDatabaseConstants.DbResourcePath));

                writerService.Write(dbPathHelper.GetDatabasePath(WordsDatabaseConstants.DbName));

                var wordService = Container.Resolve<IWordService>();

                this.BindingContext = new MainPageViewModel(null, wordService);

                var result = await NavigationService.NavigateAsync("MainPageView");

                if (!result.Success)
                {
                    System.Diagnostics.Debugger.Break();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debugger.Break();
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
