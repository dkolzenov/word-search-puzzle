using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prism.Ioc;
using WordSearch.Application;
using WordSearch.Application.Common.Interfaces;
using WordSearch.Infrastructure;

namespace WordSearch.Bootstrapper
{
    public partial class App
    {
        private const string StartPageName = "MainPageView";
        
        protected override async void OnInitialized()
        {
            try
            {
                InitializeComponent();
                await MigrateDatabaseAsync();

                var result = await NavigationService.NavigateAsync(StartPageName);

                if (!result.Success)
                {
                    Debugger.Break();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                Debugger.Break();
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry
                .AddApplication()
                .AddInfrastructure(AppSettings.Configuration);
        }

        private static async Task MigrateDatabaseAsync()
        {
            await Current.Container.Resolve<IApplicationDbContext>().Database.MigrateAsync();
        }
    }
}
