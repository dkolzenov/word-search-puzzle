namespace WordSearch.Assets.Settings
{
    using Microsoft.Extensions.Configuration;

    using WordSearch.Assets.Interfaces;
    using WordSearch.Assets.ResourceBase;
    using WordSearch.Helpers.Interfaces;

    public class AppSettings : EmbeddedResourceBase, IAppSettings
    {
        private readonly IConfiguration _configuration;

        public AppSettings(
            IPlatformPathHelper platformPathHelper,
            IResourceWriterHelper resourceWriterHelper)
            : base(platformPathHelper, resourceWriterHelper)
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile(AbsoluteDestinationPath)
                .Build();
        }

        public override string Name => "appsettings.json";

        public IConfiguration Configuration => _configuration;
    }
}
