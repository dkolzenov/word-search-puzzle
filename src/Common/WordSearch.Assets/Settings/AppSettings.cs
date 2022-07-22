namespace WordSearch.Assets.Settings
{
    using Microsoft.Extensions.Configuration;

    using WordSearch.Assets.Interfaces;
    using WordSearch.Assets.ResourceBase;
    using WordSearch.Helpers.Interfaces;

    public class AppSettings : EmbeddedResourceBase, IAppSettings
    {
        public AppSettings(
            IPlatformPathHelper platformPathHelper,
            IResourceWriterHelper resourceWriterHelper)
            : base(platformPathHelper, resourceWriterHelper)
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile(AbsoluteDestinationPath)
                .Build();
        }

        public override string Name => "appsettings.json";

        public IConfiguration Configuration { get; }
    }
}
